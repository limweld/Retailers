using MetroFramework.Forms;
using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.PduConverter;
using GsmComm.Server;

namespace Retailers.Forms
{
    public partial class ReceiverForm : MetroForm
    {
        GsmCommMain comm = null;

        //SMSCommands SMSCommands = new SMSCommands();
        //SimPortsConnection SimPortsConnection = new SimPortsConnection();
        //SerialPort port = new SerialPort();

        SMS.ShortMessageCollection ShortMessageCollection = new SMS.ShortMessageCollection();
        Class.Message Message = new Class.Message();

        Thread thread = null;
        int cntmessageReceived;

        public ReceiverForm()
        {
            InitializeComponent();
        }

        private void ReceiverForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();

                // Add all port names to the combo box:
                foreach (string port in ports)
                {
                    this.metroComboBox1.Items.Add(port);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            //SimPortsConnection = new SimPortsConnection();
            //SMSCommands = new SMSCommands();
            //port = new SerialPort();

            if (metroComboBox1.SelectedIndex > -1)
            {
                //port = SimPortsConnection.OpenPort(metroComboBox1.SelectedItem.ToString());
                comm = new GsmCommMain(metroComboBox1.SelectedItem.ToString(), 115200, 200);
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    comm.Open();
                    comm.MessageReceived += new MessageReceivedEventHandler(comm_MessageReceived);
                    comm.EnableMessageNotifications();

                    Cursor.Current = Cursors.Default;
                    metroTextButton1.Enabled ^= true;
                    metroTextButton2.Enabled ^= true;
                    metroComboBox1.Enabled ^= true;
                    Read_message();
                    thread = new Thread(Process);
                    thread.Start();
                    richTextBox1.Text += "Receiving...\n";
                }
                catch
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("not available");
                }

            }
            else
            {
                MessageBox.Show("No port selected");
            }
        }


        private void comm_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            try
            {
                IMessageIndicationObject obj = e.IndicationObject;
                if (obj is GsmComm.GsmCommunication.ShortMessage)
                {
                    GsmComm.GsmCommunication.ShortMessage msg = (GsmComm.GsmCommunication.ShortMessage)obj;
                    SmsPdu pdu = comm.DecodeReceivedMessage(msg);
                }
                if (obj is MemoryLocation)
                {
                    MemoryLocation loc = (MemoryLocation)obj;
                    //statusBar1.Text = "New message received in storage "+loc.Storage + ", index " + loc.Index;
                }
                Read_message();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message.ToString());
                ex.ToString();
            }
        }

        private void Read_message()
        {
            //pb.IsIndeterminate = true;
            string storage = GetMessageStorage();
            //txtmessage.Text = "";
            try
            {
                // Read all SMS messages from the storage
                DecodedShortMessage[] messages = comm.ReadMessages(PhoneMessageStatus.All, "SM");

                foreach (DecodedShortMessage msg in messages)
                {
                    SmsPdu pdu = msg.Data;
                    Database.DBMessages.DBInbox obj1 = new Database.DBMessages.DBInbox();
                    Database.DBMessages.DBInboxLog obj2 = new Database.DBMessages.DBInboxLog();
                    if (pdu is SmsDeliverPdu)
                    {
                        // Received message
                        SmsDeliverPdu data = (SmsDeliverPdu)pdu;

                        String SenderNo = data.OriginatingAddress.ToString();
                        String SenderNo2 = SenderNo;
                        SenderNo = SenderNo.Replace("+63", "0");
                        string sdate = "20" + data.SCTimestamp.Year + "-" + data.SCTimestamp.Month + "-" + data.SCTimestamp.Day + " " + data.SCTimestamp.Hour + ":" + data.SCTimestamp.Minute + ":" + data.SCTimestamp.Second;


                        Class.Message m = new Class.Message();

                          if (m.MessageParsing(data.UserDataText.ToString(), SenderNo) == true)
                          {

                              obj2.Add(DateTime.Parse(sdate), SenderNo, data.UserDataText.ToString(), "Valid");
                          }
                          else
                          {
                              obj1.Add(DateTime.Parse(sdate), SenderNo, data.UserDataText.ToString());
                          }
                 
                        cntmessageReceived++;
                        ReceiveUpdates();

                    }

                }
                // delete all messages
                DeleteAllMessages();

            }
            catch (Exception e)
            {
                e.ToString();
                ReceiveUpdatesError();
            }
            //pb.IsIndeterminate = false;
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Abort();

                //port = SimPortsConnection.ClosePort(port);
                comm.Close();
                metroTextButton1.Enabled ^= true;
                metroTextButton2.Enabled ^= true;
                metroComboBox1.Enabled ^= true;
                richTextBox1.Clear();
            }catch(Exception ex){
                ex.ToString();
            }
        }

        public void Process()
        {

            while (true)
            {
                if (comm.IsConnected() == false)
                {
                    thread.Abort();

                    metroTextButton1.Enabled ^= true;
                    metroTextButton2.Enabled ^= true;
                    metroComboBox1.Enabled ^= true;
                    richTextBox1.Clear();
                    MessageBox.Show("Communication is disconnected!");
                }

                //Read_message();
            }
        }

        public void ReceiveUpdatesError()
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.Text += "Error Receiving...\n";
                richTextBox1.Text += "Receiving...\n";
                metroLabel4.Text = cntmessageReceived.ToString();

            });
        }

        public void ReceiveUpdates()
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.Text += "Message Receive\n";
                richTextBox1.Text += "Receiving...\n";
                metroLabel4.Text = cntmessageReceived.ToString();
            });
        }

        private void DeleteAllMessages()
        {

            string storage = GetMessageStorage();
            try
            {
                // Delete all messages from phone memory
                comm.DeleteMessages(DeleteScope.All, "SM");
                comm.DeleteMessages(DeleteScope.All, "ME");
                //MessageBox.Show("All Messages Deleted from SIM");
            }
            catch (Exception e)
            {
                e.ToString();
                ReceiveUpdatesError();
            }

        }

        private string GetMessageStorage()
        {
            string storage = string.Empty;

            storage = PhoneStorageType.Sim;

            if (storage.Length == 0)
                throw new ApplicationException("Unknown message storage.");
            else
                return storage;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
            richTextBox1.ScrollToCaret();
        }

        private void ReceiverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread != null && thread.IsAlive)
            {
                thread.Abort();
                comm.Close();
                //port = SimPortsConnection.ClosePort(port);
            }

            this.Dispose();
        }

    }
}

