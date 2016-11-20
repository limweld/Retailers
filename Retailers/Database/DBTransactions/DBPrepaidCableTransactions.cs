using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Retailers.Database.DBTransactions
{
    class DBPrepaidCableTransactions
    {
        private static string tablename = "prepaidcabletransaction";

        private int id;
        private string wallet_id;
        private string code;
        private string box_number;
        private int amount;
        private string pin;
        private DateTime date;
        private string status;
        private float discount;
        private string customer_number;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Wallet_id
        {
            get { return wallet_id; }
            set { wallet_id = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Box_number
        {
            get { return box_number; }
            set { box_number = value; }
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

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public string Customer_number
        {
            get { return customer_number; }
            set { customer_number = value; }
        }

        public DBPrepaidCableTransactions()
        {

        }

        public DBPrepaidCableTransactions(string wallet_id, string code,  int amount, DateTime date, float discount, string customer_number)
        {
           
            this.wallet_id = wallet_id;
            this.code = code;
            this.amount = amount;
            this.date = date;
            this.discount = discount;
            this.customer_number = customer_number;
        }

        public DBPrepaidCableTransactions(int id, string wallet_id, string code, string box_number, int amount, string pin, DateTime date, string status, float discount, string customer_number)
        {
            this.id = id;
            this.wallet_id = wallet_id;
            this.code = code;
            this.box_number = box_number;
            this.amount = amount;
            this.pin = pin;
            this.date = date;
            this.status = status;
            this.discount = discount;
            this.customer_number = customer_number;
        }

        public void Add(string wallet, string code, string box, float amount, float discount, string pin, string customer_num, DateTime date, string status)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0, @wallet_id, @code, @box_number, @amount, @discount, @pin, @customer_number, @date, @status)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@wallet_id", wallet);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@box_number", box);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@discount", discount);
                cmd.Parameters.AddWithValue("@pin", pin);
                cmd.Parameters.AddWithValue("@customer_number", customer_num);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (Exception ex)
            {
                ex.ToString();
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Update(int id, string column, string data)
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

        public void Delete(string status)
        {
            MySqlConnection con = DBConnection.ConnectDatabase();
            string command = "DELETE FROM " + tablename + " WHERE status=@status";

            try
            {
                MySqlCommand cmd = new MySqlCommand(command, con);
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

        public static List<DBPrepaidCableTransactions> GetData()
        {
            List<DBPrepaidCableTransactions> data = new List<DBPrepaidCableTransactions>();

            MySqlConnection con = DBConnection.ConnectDatabase();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " ORDER BY id DESC", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrepaidCableTransactions rawData = new DBPrepaidCableTransactions();
                        rawData.Id = reader.GetInt32(0);
                        rawData.Wallet_id = reader.GetString(1);
                        rawData.Code = reader.GetString(2);
                        rawData.Box_number = reader.GetString(3);
                        rawData.Amount = reader.GetInt32(4);
                        rawData.Discount = reader.GetFloat(5);
                        rawData.Pin = reader.GetString(6);
                        rawData.Customer_number = reader.GetString(7);
                        rawData.Date = reader.GetDateTime(8);
                        rawData.Status = reader.GetString(9);

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

        public static List<DBPrepaidCableTransactions> GetDataByDate(DateTime past, DateTime present)
        {
            List<DBPrepaidCableTransactions> data = new List<DBPrepaidCableTransactions>();

            MySqlConnection con = DBConnection.ConnectDatabase();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE date BETWEEN '" + past.ToString("yyyy-MM-dd") + " 0:0:0" + "' AND '" + present.ToString("yyyy-MM-dd") + " 23:59:59" + "' ORDER BY id DESC", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrepaidCableTransactions rawData = new DBPrepaidCableTransactions();
                        rawData.Id = reader.GetInt32(0);
                        rawData.Wallet_id = reader.GetString(1);
                        rawData.Code = reader.GetString(2);
                        rawData.Box_number = reader.GetString(3);
                        rawData.Amount = reader.GetInt32(4);
                        rawData.Discount = reader.GetFloat(5);
                        rawData.Pin = reader.GetString(6);
                        rawData.Customer_number = reader.GetString(7);
                        rawData.Date = reader.GetDateTime(8);
                        rawData.Status = reader.GetString(9);

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

        public static List<DBPrepaidCableTransactions> GetDataByWallet(string wallet,DateTime past, DateTime present)
        {
            
            List<DBPrepaidCableTransactions> data = new List<DBPrepaidCableTransactions>();

            MySqlConnection con = DBConnection.ConnectDatabase();
            try
            {   // AND
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE (date BETWEEN '" + past.ToString("yyyy-MM-dd") + " 0:0:0" + "' AND '" + present.ToString("yyyy-MM-dd") + " 23:59:59" + "') AND wallet_id ='" + wallet + "' ORDER BY id DESC", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrepaidCableTransactions rawData = new DBPrepaidCableTransactions();
                        rawData.Id = reader.GetInt32(0);
                        rawData.Wallet_id = reader.GetString(1);
                        rawData.Code = reader.GetString(2);
                        rawData.Box_number = reader.GetString(3);
                        rawData.Amount = reader.GetInt32(4);
                        rawData.Discount = reader.GetFloat(5);
                        rawData.Pin = reader.GetString(6);
                        rawData.Customer_number = reader.GetString(7);
                        rawData.Date = reader.GetDateTime(8);
                        rawData.Status = reader.GetString(9);

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

        public static DBPrepaidCableTransactions GetDataById(int idx)
        {
            DBPrepaidCableTransactions data = null;

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE id=" + idx, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBPrepaidCableTransactions();
                    data.Id = reader.GetInt32(0);
                    data.Wallet_id = reader.GetString(1);
                    data.Code = reader.GetString(2);
                    data.Box_number = reader.GetString(3);
                    data.Amount = reader.GetInt32(4);
                    data.Discount = reader.GetFloat(5);
                    data.Pin = reader.GetString(6);
                    data.Customer_number = reader.GetString(7);
                    data.Date = reader.GetDateTime(8);
                    data.Status = reader.GetString(9);

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

        public static DBPrepaidCableTransactions GetDataSendingStatus(string s)
        {
            DBPrepaidCableTransactions data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE status='" + s + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBPrepaidCableTransactions();
                    data.Id = reader.GetInt32(0);
                    data.Wallet_id = reader.GetString(1);
                    data.Code = reader.GetString(2);
                    data.Box_number = reader.GetString(3);
                    data.Amount = reader.GetInt32(4);
                    data.Discount = reader.GetFloat(5);
                    data.Pin = reader.GetString(6);
                    data.Customer_number = reader.GetString(7);
                    data.Date = reader.GetDateTime(8);
                    data.Status = reader.GetString(9);

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
