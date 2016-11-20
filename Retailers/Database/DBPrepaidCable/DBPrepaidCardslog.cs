using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Retailers.Database.DBPrepaidCable
{
    class DBPrepaidCardslog
    {
        private static string tablename = "prepaidcardslog";


        private int id;
        private string cableType;
        private int amount;
        private string pin;
        private string status;
        private DateTime date_Used;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string CableType
        {
            get { return cableType; }
            set { cableType = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime Date_Used
        {
            get { return date_Used; }
            set { date_Used = value; }
        }

        public DBPrepaidCardslog()
        {

        }

        public DBPrepaidCardslog(int id, string cableType, int amount, string pin, string status,DateTime date_Used)
        {
            this.id = id;
            this.cableType = cableType;
            this.amount = amount;
            this.pin = pin;
            this.status = status;
            this.date_Used = date_Used;
        }

        public void Add(string cableType, int amount, string pin, DateTime date, string stat)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0,@cableType,@amount,@pin,@status,@date_used)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@cableType", cableType);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@pin", pin);
                cmd.Parameters.AddWithValue("@status", stat);
                cmd.Parameters.AddWithValue("@date_used", date);

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

        public void Edit()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public static List<DBPrepaidCardslog> GetData()
        {
            List<DBPrepaidCardslog> data = new List<DBPrepaidCardslog>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrepaidCardslog rawData = new DBPrepaidCardslog();
                        rawData.Id = reader.GetInt32(0);
                        rawData.CableType = reader.GetString(1);
                        rawData.Amount = reader.GetInt32(2);
                        rawData.Pin = reader.GetString(3);
                        rawData.Status = reader.GetString(4);
                        rawData.Date_Used = reader.GetDateTime(5);

                        data.Add(rawData);
                    }
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return data;
        }

    }
}
