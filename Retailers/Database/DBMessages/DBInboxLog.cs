using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Retailers.Database.DBMessages
{
    class DBInboxLog
    {
        private static string tablename = "inboxlog";

        private int id;
        private DateTime date;
        private string phone;
        private string message;

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

        public string Sender
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public void Add(DateTime date, string phone, string message, string status)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0,@date,@phone,@message,@status)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.Parameters.AddWithValue("@status", status);

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

        public void Update(string id, string column, string data)
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

        public List<DBInbox> GetData()
        {
            List<DBInbox> data = new List<DBInbox>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBInbox rawData = new DBInbox();
                        rawData.ID = reader.GetInt32(0);
                        rawData.Date = reader.GetDateTime(1);
                        rawData.Sender = reader.GetString(2);
                        rawData.Message = reader.GetString(3);

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

        public static DBInboxLog GetPrevLoad(string sender, string message)
        {
            DBInboxLog data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE (sender='"+sender+"' AND message='"+message+"' AND (TIMESTAMPDIFF(MINUTE,date,now())<120)) LIMIT 1", con);
           

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    data = new DBInboxLog();
                    data.ID = reader.GetInt32(0);
                    data.Date = reader.GetDateTime(1);
                    data.Sender = reader.GetString(2);
                    data.Message = reader.GetString(3);
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
    }
}
