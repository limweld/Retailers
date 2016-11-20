using MetroFramework.Forms;
using System;
using System.IO.Ports;
using Retailers.SMS;
using Retailers.Database;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.PduConverter;
using GsmComm.Server;

namespace Retailers.Forms
{
    public partial class SenderForm : MetroForm
    {
        SMSCommands SMSCommands = new SMSCommands();

        public static GsmCommMain comm;

        SimPortsConnection SimPortsConnection = new SimPortsConnection();
        SerialPort port = null;

        DBTelco DBTelco = new DBTelco();
        Database.DBMessages.DBOutbox DBOutbox = new Database.DBMessages.DBOutbox();
        Class.Message Message = new Class.Message();

        Thread thread = null;
        Thread thread2 = null; 
        int cntmessageReceived;
        int messageSent;
        int limit = 0;
        string selectedNetwork = "";

        public SenderForm()
        {
            InitializeComponent();
        }

        private void SenderForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                this.metroComboBox1.Items.Add(port);
            }

            metroComboBox2.Items.Add("ALL NETWORK");
            metroComboBox2.Items.Add("Smart/TNT/SUN");
            List<DBTelco> dataList = DBTelco.GetData();
            foreach (DBTelco data in dataList)
            {
                metroComboBox2.Items.Add(data.TelcoName);
            }
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            //Database.DBStat stat = Database.DBStat.GetDataById(1);

            //if (stat.STAT != "okla") {
            //    MessageBox.Show("Error in loading the system, please contact the administrator!");
            //    Environment.Exit(0);
            //}
            
            if (metroComboBox1.SelectedIndex > -1 && metroComboBox2.SelectedIndex > -1)
            {
                //port = SimPortsConnection.OpenPort(metroComboBox1.SelectedItem.ToString());

                comm = new GsmCommMain(metroComboBox1.SelectedItem.ToString(), 115200, 300);

                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    comm.Open();

                    if (chkReceived.Checked == true)
                    {
                        comm.MessageReceived += new MessageReceivedEventHandler(comm_MessageReceived);
                        comm.EnableMessageNotifications();
                    }
                    metroTextButton1.Enabled ^= true;
                    metroTextButton2.Enabled ^= true;
                    metroComboBox1.Enabled ^= true;
                    metroComboBox2.Enabled ^= true;
                    selectedNetwork = metroComboBox2.SelectedItem.ToString();
                    limit = int.Parse(txtLimit.Text);
                    thread = new Thread(Process);
                    thread.Start();
                    thread2 = new Thread(TransactProcess);
                    thread2.Start();
                    richTextBox1.Text += "Ok. Ready...\n";

                    Cursor.Current = Cursors.Default;
                    
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Error opening port! " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("No Port / Network selected");
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
                MessageBox.Show(ex.Message.ToString());
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

                if (messages.Length == 0)
                {
                    messages = comm.ReadMessages(PhoneMessageStatus.All, "ME");
                }

                foreach (DecodedShortMessage msg in messages)
                {
                    SmsPdu pdu = msg.Data;

                    if (pdu is SmsDeliverPdu)
                    {
                        // Received message
                        SmsDeliverPdu data = (SmsDeliverPdu)pdu;

                        String SenderNo = data.OriginatingAddress.ToString();
                        SenderNo = SenderNo.Replace("+63", "0");
                        string sdate = "20" + data.SCTimestamp.Year + "-" + data.SCTimestamp.Month + "-" + data.SCTimestamp.Day + " " + data.SCTimestamp.Hour + ":" + data.SCTimestamp.Minute + ":" + data.SCTimestamp.Second;

                        //add to database
                        //Database.DBMessages.DBInbox obj = new Database.DBMessages.DBInbox();
                        //obj.Add(DateTime.Parse(sdate), SenderNo, data.UserDataText.ToString());

                        cntmessageReceived++;
                        ReceiveUpdates();
                        
                       
                    }

                }
                // delete all messages
                DeleteAllMessages();

            }
            catch (Exception ex)
            {
                ex.ToString();
                ReceiveUpdatesError();
            }
            //pb.IsIndeterminate = false;
        }

        public void ReceiveUpdates()
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblReceived.Text = cntmessageReceived.ToString();
            });
        }
        public void ReceiveUpdatesError()
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblReceived.Text = cntmessageReceived.ToString() + " - Error";
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
            catch (Exception ex)
            {
                ex.ToString();
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

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Abort();
                //thread2.Abort();
                //port = SimPortsConnection.ClosePort(port);
                comm.Close();
                metroTextButton1.Enabled ^= true;
                metroTextButton2.Enabled ^= true;
                metroComboBox1.Enabled ^= true;
                metroComboBox2.Enabled ^= true;
                richTextBox1.Clear();
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        public void TransactProcess()
        {
            while (true)
            {
                Class.Message.PrepaidCableConfirmationCustomer();
            }
        }
        public void Process()
        {
            
            while (true)
            {
                List<Database.DBMessages.DBOutbox> dataList = DBOutbox.GetData();

                foreach (Database.DBMessages.DBOutbox data in dataList)
                {
                    switch (selectedNetwork)
                    {
                        case "Globe":
                            if (Message.Prefix(data.Recipient) == "Globe")
                                SendProcess(data.ID, data.Recipient, data.Message, data.Sent);
                            break;

                        case "Smart":
                            if (Message.Prefix(data.Recipient) == "Smart")
                                SendProcess(data.ID, data.Recipient, data.Message, data.Sent);
                            break;

                        case "Sun":
                            if (Message.Prefix(data.Recipient) == "Sun")
                                SendProcess(data.ID, data.Recipient, data.Message, data.Sent);
                            break;

                        case "Smart/TNT/SUN":
                            if (Message.Prefix(data.Recipient) == "Sun")
                                SendProcess(data.ID, data.Recipient, data.Message, data.Sent);
                            if (Message.Prefix(data.Recipient) == "Smart")
                                SendProcess(data.ID, data.Recipient, data.Message, data.Sent);
                            break;

                        default:
                            SendProcess(data.ID, data.Recipient, data.Message, data.Sent);
                            break;
                    }

                    if (messageSent > limit) {
                        MessageBox.Show("Limit reached, Please try again later!");
                        thread.Abort();
                        thread2.Abort();

                        comm.Close();
                        metroTextButton1.Enabled ^= true;
                        metroTextButton2.Enabled ^= true;
                        metroComboBox1.Enabled ^= true;
                        metroComboBox2.Enabled ^= true;
                        richTextBox1.Clear();
                    }
                }
                
            }
        }

        private void sendAuthor(string recipient, string message)
        {
            int retry = 0;
            bool reply = false;
            do
            {

                reply = sendMessage(recipient, message);
                if (reply == false)
                {
                    RichTextboxUpdate2("Retry Sending to " + recipient + "...");
                    retry++;
                }
            } while (reply == false && retry < 5);
        }

        public void SendProcess(int id, string recipient, string message, string status)
        {
            string sent = "";
            bool reply = false;

            if (status == "Pending")
            {
                RichTextboxUpdate2("Sending to " + recipient + "...");

                int retry = 0;
                
                do {

                    reply = sendMessage(recipient, message);
                    if (reply == false)
                    {
                        RichTextboxUpdate2("Retry Sending to " + recipient + "...");
                        retry++;
                    }
                } while (reply == false && retry < 5);

                
                if (reply)
                {

                    Class.Message m = new Class.Message();
                    Database.DBMessages.DBOutbox temp = DBOutbox.GetDataId(id);
                  
                    Database.DBMessages.DBOutboxLog obj = new Database.DBMessages.DBOutboxLog();
                    obj.Add(temp.Date, temp.Recipient, temp.Message, "Sent"); // add to log



                    DBOutbox.Delete(id.ToString()); // delete from table outbox

                    messageSent++;
                    LabelUpdate();
                    sent = "Sent";
                }
                else
                {
                    DBOutbox.Update(id.ToString(), "status", "Unsuccessful");
                    sent = "Unsuccessful";
                }

                RichTextboxUpdate(sent);
            }
        }

        public bool sendMessage(string num, string msg) {
            SmsSubmitPdu pdu = null;

            try
            {
                pdu = new SmsSubmitPdu(msg, num, "");
                comm.SendMessage(pdu);

            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
            return true;
        }

        public void RichTextboxUpdate(string report)
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.Text += report + "\n";
                richTextBox1.Text += "Ok. Ready..." + "\n";
            });
        }

        public void RichTextboxUpdate2(string report)
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.Text += report + "\n";
            });
        }

        public void LabelUpdate()
        {
            this.Invoke((MethodInvoker)delegate
            {
                metroLabel4.Text = messageSent.ToString();
            });
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length; //Set the current caret position at the end
            richTextBox1.ScrollToCaret();
        }

        private void SenderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread != null && thread.IsAlive && thread2 != null && thread2.IsAlive)
            {
                thread.Abort();
                thread2.Abort();
                comm.Close();
                //port = SimPortsConnection.ClosePort(port);
            }

          

            this.Dispose();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkReceived_CheckedChanged(object sender, EventArgs e)
        {
            if (comm != null && comm.IsOpen()==true)
            {
                if (chkReceived.Checked == true)
                {
                    comm.MessageReceived += new MessageReceivedEventHandler(comm_MessageReceived);
                    comm.EnableMessageNotifications();
                }
                else
                {
                    comm.DisableMessageNotifications();

                }
            }
        }
    }
}
