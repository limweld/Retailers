using System;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Retailers.SMS
{
    class SMSControl
    {
        SerialPort port = new SerialPort();
        String response = "";

        public SerialPort Port
        {
            set { port = value; }
        }

        public void InitializePort()
        {
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            response += port.ReadExisting();
            //response += port.ReadLine();
        }

        public bool TimeOut()
        {
            int timeout = 0;
            while (!response.EndsWith("\r\nOK\r\n") && !response.Contains("ERROR") && timeout < 40)
            {
                timeout++;
                Thread.Sleep(100);
            }

            if (response.Contains("ERROR"))
                return true;

            if (timeout >= 40)
                return true;

            return false;
        }

        public ShortMessageCollection ReadSMS()
        {
            ShortMessageCollection messages = null;
            try
            {
                port.WriteLine("AT+CMGF=1" + System.Environment.NewLine);
                port.WriteLine("AT+CMGL=\"ALL\"\r" + System.Environment.NewLine);

                Thread.Sleep(1000);
                TimeOut();
             
                messages = ParseMessages(response);
                response = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (messages != null)
                return messages;
            else
                return null;
        }

        public bool SendMsg(string phone, string message)
        {
            try
            {
                if (phone.Count() > 11) //CHECK THE RETAILERS NUMBER IF IT HAS "+63"
                    phone = "0" + phone.Substring(phone.IndexOf("9"));

                port.WriteLine("AT+CMGF=1" + "\r");
                Thread.Sleep(300);
                port.WriteLine(string.Format("AT+CMGS=\"{0}\"\r", phone));
                Thread.Sleep(300);
                port.WriteLine(message + "\x1A");

                Thread.Sleep(1000);

                if (TimeOut())
                {
                    response = "";
                    return false;
                }

                response = "";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void DeleteMsg()
        {
            try
            {
                port.Write("AT+CMGF=1\r");
                port.Write("AT+CMGD=1,3\r");

                Thread.Sleep(1000);
                TimeOut();

                response = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteAllMsg()
        {
            try
            {
                port.Write("AT+CMGF=1\r");
                port.Write("AT+CMGD=1,4\r");

                Thread.Sleep(1000);
                TimeOut();

                response = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ShortMessageCollection ParseMessages(string response)
        {
            ShortMessageCollection messages = new ShortMessageCollection();
            
            try
            {
                Regex r = new Regex(@"\+CMGL: (\d+),""(.+)"",""(.+)"",(.*),""(.+)""\r\n(.+)\r\n");
                Match m = r.Match(response);

                while (m.Success)
                {
                    ShortMessage msg = new ShortMessage();
                    msg.Index = int.Parse(m.Groups[1].Value);
                    msg.Status = m.Groups[2].Value;
                    msg.Sender = m.Groups[3].Value;
                    msg.Alphabet = m.Groups[4].Value;
                    msg.Sent = m.Groups[5].Value;
                    msg.Message = m.Groups[6].Value;
                    messages.Add(msg);

                    m = m.NextMatch();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return messages;
        }
    }
}
