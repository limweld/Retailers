using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Retailers.Database.DBPrepaidCable
{
    class DBPrepaidCableAmount
    {
        private static string tablename = "prepaidcableamounts";

        private int id;
        private string type;
        private int amount;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public DBPrepaidCableAmount()
        {

        }

        public DBPrepaidCableAmount( int id, string type, int amount)
        {
            this.id = id;
            this.type = type;
            this.amount = amount;
        }

        public void Add(string type, int amount)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0,@type,@amount)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@amount", amount);
                
                MessageBox.Show("Insert Successfully !");
                
                cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

                MessageBox.Show("Delete !");

                cmd.ExecuteNonQuery(); //execute the mysql command

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public static List<DBPrepaidCableAmount> GetData()
        {
            List<DBPrepaidCableAmount> data = new List<DBPrepaidCableAmount>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " ORDER BY type, amount DESC", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrepaidCableAmount rawData = new DBPrepaidCableAmount();
                        rawData.Id = reader.GetInt32(0);
                        rawData.Type = reader.GetString(1);
                        rawData.Amount = reader.GetInt32(2);
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

        public static List<DBPrepaidCableAmount> GetDataType(string type)
        {
            List<DBPrepaidCableAmount> data = new List<DBPrepaidCableAmount>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE type='" + type + "' ORDER BY amount DESC", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrepaidCableAmount rawData = new DBPrepaidCableAmount();
                        rawData.Id = reader.GetInt32(0);
                        rawData.Type = reader.GetString(1);
                        rawData.Amount = reader.GetInt32(2);
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
    }
}
