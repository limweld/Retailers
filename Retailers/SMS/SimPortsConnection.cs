using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Retailers.SMS
{
    class SimPortsConnection
    {
        public SerialPort port = new SerialPort();

        public SerialPort OpenPort(string ports_Name)
        {
            try
            {
                port.PortName = ports_Name;
                //port.BaudRate = 115200;
                port.BaudRate = 9600;
                port.DataBits = 8;
                port.StopBits = StopBits.One;
                port.Parity = Parity.None;
                port.ReadTimeout = 300;
                port.WriteTimeout = 300;
                port.Encoding = Encoding.GetEncoding("iso-8859-1");
                port.DtrEnable = true;
                port.RtsEnable = true;
                port.Handshake = Handshake.XOnXOff;
                port.NewLine = Environment.NewLine;

                port.Open();
                //port = new SerialPort();
                //return port;
                
                bool checkport = CheckExistingModemOnComPort(port);
                if (!checkport)
                {
                    MessageBox.Show("No SIM Card detected in this port");
                    port.Close();
                    port = new SerialPort();
                    return null;
                }
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return port;
        }

        public SerialPort ClosePort(SerialPort port)
        {
            try
            {
                port.Close();
                port = null;
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private bool CheckExistingModemOnComPort(SerialPort serialPort)
        {
            if ((serialPort == null) || !serialPort.IsOpen)
                return false;

            // Commands for modem checking
            string[] modemCommands = new string[] { "AT",       // Check connected modem. After 'AT' command some modems autobaud their speed.
                                            "ATQ0" };   // Switch on confirmations
            serialPort.DtrEnable = true;    // Set Data Terminal Ready (DTR) signal 
            serialPort.RtsEnable = true;    // Set Request to Send (RTS) signal

            string answer = "";
            bool retOk = false;
            for (int rtsInd = 0; rtsInd < 2; rtsInd++)
            {
                foreach (string command in modemCommands)
                {
                    serialPort.Write(command + "\r");
                    retOk = false;
                    answer = "";
                    int timeout = (command == "AT") ? 10 : 20;

                    // Waiting for response 1-2 sec
                    for (int i = 0; i < timeout; i++)
                    {
                        Thread.Sleep(100);
                        answer += serialPort.ReadExisting();
                        //answer += serialPort.ReadLine();
                        if (answer.IndexOf("OK") >= 0)
                        {
                            retOk = true;
                            break;
                        }
                    }
                }
                // If got responses, we found a modem
                if (retOk)
                    return true;

                // Trying to execute the commands without RTS
                serialPort.RtsEnable = false;
            }
            return false;
        }
    }
}
