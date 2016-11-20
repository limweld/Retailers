using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;


namespace Retailers.Database.DBMessages
{
    class DBOutbox
    {
        private static string tablename = "outbox";

        private int id;
        private DateTime date;
        private string recipient;
        private string message;
        private string sent;
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Recipient
        {
            get { return recipient; }
            set { recipient = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string Sent
        {
            get { return sent; }
            set { sent = value; }
        }

        public DBOutbox()
        {
        
        }

        public DBOutbox(int id,DateTime date,string message, string status)
        {
            this.date = date;
            this.message = message;
            this.sent = status;
            this.id = id;
        }

        public void Add(DateTime date, string recipient, string message, string status)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0,@date,@recipient,@message,@status)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@recipient", recipient);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Update(string id, string column, object data)
        {
            string cmdText = "UPDATE " + tablename + " SET " + column + " = @data WHERE id = @id";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void ReSendMessage(string wallet)
        {
            string cmdText = "UPDATE " + tablename + " SET status = 'Pending' " + " WHERE status = 'Unsuccessful' AND recipient = '"+ wallet+"'";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(string id)
        {
            MySqlConnection con = DBConnection.ConnectDatabase();
            string command = "DELETE FROM " + tablename + " WHERE id=@id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery(); //execute the mysql command

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public List<DBOutbox> GetData()
        {
            List<DBOutbox> data = new List<DBOutbox>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBOutbox rawData = new DBOutbox();
                        rawData.ID = reader.GetInt32(0);
                        string sdate = reader.GetString(1).ToString();
                        DateTime dddate = DateTime.Parse(sdate);
                        rawData.Date = dddate;
                        rawData.Recipient = reader.GetString(2);
                        rawData.Message = reader.GetString(3);
                        rawData.Sent = reader.GetString(4);

                        data.Add(rawData);
                    }
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return data;
        }

        public static List<DBOutbox> GetUnsentMessages()
        {
            List<DBOutbox> data = new List<DBOutbox>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE status='Unsuccessful'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBOutbox rawData = new DBOutbox();
                        rawData.ID = reader.GetInt32(0);
                        string sdate = reader.GetString(1).ToString();
                        DateTime dddate = DateTime.Parse(sdate);
                        rawData.Date = dddate;
                        rawData.Recipient = reader.GetString(2);
                        rawData.Message = reader.GetString(3);
                        rawData.Sent = reader.GetString(4);

                        data.Add(rawData);
                    }
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return data;
        }



        public DBOutbox GetDataId(int id)
        {
            DBOutbox data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE id=" + id, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    data = new DBOutbox();
                    data.ID = reader.GetInt32(0);
                    data.Date = DateTime.Parse(reader.GetDateTime(1).ToString());
                    data.Recipient = reader.GetString(2);
                    data.Message = reader.GetString(3);
                    data.Sent = reader.GetString(4);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return data;
        }



  

        public static List<DBOutbox> GetUnsentMessagesByRecipeint(string sender)
        {
            List<DBOutbox> data = new List<DBOutbox>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE 	recipient='" + sender + "' AND status='Unsuccessful'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBOutbox rawData = new DBOutbox();
                        rawData.ID = reader.GetInt32(0);
                        string sdate = reader.GetString(1).ToString();
                        DateTime dddate = DateTime.Parse(sdate);
                        rawData.Date = dddate;
                        rawData.Recipient = reader.GetString(2);
                        rawData.Message = reader.GetString(3);
                        rawData.Sent = reader.GetString(4);

                        data.Add(rawData);
                    }
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return data;
        }

        public static DBOutbox GetDataMessage(string message,string status)
        {
            DBOutbox data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE message LIKE '%" + message + "%' AND status='"+ status+"'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    data = new DBOutbox();
                    data.ID = reader.GetInt32(0);
                    data.Date = DateTime.Parse(reader.GetDateTime(1).ToString());
                    data.Recipient = reader.GetString(2);
                    data.Message = reader.GetString(3);
                    data.Sent = reader.GetString(4);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                con.Close();
            }

            return data;
        }   
        
    }
}
