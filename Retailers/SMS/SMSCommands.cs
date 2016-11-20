using System;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Retailers.SMS
{
    class SMSCommands
    {
        SerialPort port = new SerialPort();
        string response = "";

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
        }

        public string Execute(string command, int duration)
        {
            int retry = 0;
            do
            {
                response = "";

                port.Write(command + "\r");
                TimeOut(duration);

                retry++;
            }
            while (response.Contains("ERROR") && retry < 5);

            return response;
        }

        public string ExecuteLine(string command, int duration)
        {
            int retry = 0;
            do
            {
                response = "";

                port.WriteLine(command);
                TimeOut(duration);

                retry++;
            }
            while (response.Contains("ERROR") && retry < 5);

            return response;
        }

        public void TimeOut(int duration)
        {
            int timeout = 0;
            while (!response.EndsWith("\r\nOK\r\n") && timeout < duration)
            {
                timeout++;
                Thread.Sleep(100);
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
                Console.WriteLine(ex.Message);
            }

            return messages;
        }

        public bool SendMsg(string phone, string message)
        {
            try
            {
                if (phone.Count() > 11) //CHECK THE RETAILERS NUMBER IF IT HAS "+63"
                    phone = "0" + phone.Substring(phone.IndexOf("9"));
                response = "";
                port.Write("AT" + Char.ConvertFromUtf32(13));
                Thread.Sleep(1000);
                port.Write("AT+CMGF=1" + Char.ConvertFromUtf32(13));
                Thread.Sleep(1000);
                string str = "AT+CMGS=" + (char)34 + phone + (char)34 + Char.ConvertFromUtf32(13);
                port.Write(str);
                //Thread.Sleep(200);
                port.Write(message + Char.ConvertFromUtf32(26) + Char.ConvertFromUtf32(13));

                Thread.Sleep(1000);
                /*
                if (response.ToString().Contains(">"))
                    return true;
                else
                    return false;
                */
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
                Console.WriteLine(ex.Message);
                return false;
            }
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
    }
}
