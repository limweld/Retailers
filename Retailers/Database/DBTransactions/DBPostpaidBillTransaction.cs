using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Retailers.Database.DBTransactions
{
    class DBPostpaidBillTransaction
    {
        private static string tablename = "tblpostpaidtransaction";

        private int id;
        private DateTime date;
        private string billscode;
        private string parameter1;
        private string parameter2;
        private float amount;
        private string wallet_Id;
        private string status;
        private string ecpaytrackingno;
        private string customers_fullname;
        private float convenience_fee;
        private float total;
        private string customer_number;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string BillsCode
        {
            get { return billscode; }
            set { billscode = value; }
        }

        public string Parameter1
        {
            get { return parameter1; }
            set { parameter1 = value; }
        }

        public string Parameter2
        {
            get { return parameter2; }
            set { parameter2 = value; }
        }

        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Wallet_Id
        {
            get { return wallet_Id; }
            set { wallet_Id = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Ecpaytrackingno
        {
            get { return ecpaytrackingno; }
            set { ecpaytrackingno = value; }
        }

        public string Customer_Fullname
        {
            get { return customers_fullname; }
            set { customers_fullname = value; }
        }

        public float Convenience_fee
        {
            get { return convenience_fee; }
            set { convenience_fee = value; }
        }

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Customer_Number
        {
            get { return customer_number; }
            set { customer_number = value; }
        }

        public DBPostpaidBillTransaction()
        {

        }

        public DBPostpaidBillTransaction( int id,DateTime date,string billscode,string parameter1,string parameter2,float amount,string wallet_Id,string status,
        string ecpaytrackingno,string fullname, float convenience_fee, float total, string customer_number)
        {
             this.id = id;
             this.date = date;
             this.billscode = billscode;
             this.parameter1 = parameter1;
             this.parameter2 = parameter2;
             this.amount = amount;
             this.wallet_Id = wallet_Id;
             this.status = status;
             this.ecpaytrackingno = ecpaytrackingno;
             this.customers_fullname = fullname;
             this.convenience_fee = convenience_fee;
             this.total = total;
             this.customer_number = customer_number;
        }

        public void Update(int id, string ecpayNumber, string status)
        {
            string cmdText = "UPDATE " + tablename + " SET ecpaytrackingno=@ecpaytrackingno, status=@status WHERE id = @id";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@ecpaytrackingno", ecpayNumber);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery(); //execute the mysql command

                MessageBox.Show("Save !");
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

        public void Add(DateTime date,string billscode,string parameter1,string parameter2,float amount,string wallet_Id,string status,
        string ecpaytrackingno,string fullname, float convenience_fee, float total, string customer)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0, @date, @billscode, @parameter1, @parameter2, @amount, @convenience_fee, @wallet_id, @ecpaytrackingno, @customers_fullname, @total, @status, @customer_number)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@billscode",billscode);
                cmd.Parameters.AddWithValue("@parameter1",parameter1);
                cmd.Parameters.AddWithValue("@parameter2",parameter2);
                cmd.Parameters.AddWithValue("@amount",amount);
                cmd.Parameters.AddWithValue("@convenience_fee",convenience_fee);
                cmd.Parameters.AddWithValue("@wallet_id",wallet_Id);
                cmd.Parameters.AddWithValue("@ecpaytrackingno",ecpaytrackingno);
                cmd.Parameters.AddWithValue("@customers_fullname",fullname);
                cmd.Parameters.AddWithValue("@total",total);
                cmd.Parameters.AddWithValue("@status",status);
                cmd.Parameters.AddWithValue("@customer_number", customer);   

                 cmd.ExecuteNonQuery(); //execute the mysql command
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static List<DBPostpaidBillTransaction> GetData()
        {
            List<DBPostpaidBillTransaction> data = new List<DBPostpaidBillTransaction>();

            MySqlConnection con = DBConnection.ConnectDatabase();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " ORDER BY id DESC", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPostpaidBillTransaction rawData = new DBPostpaidBillTransaction();
                            rawData.Id = reader.GetInt32(0);
                            rawData.Date = reader.GetDateTime(1);
                            rawData.BillsCode = reader.GetString(2);
                            rawData.Parameter1 = reader.GetString(3);
                            rawData.Parameter2 = reader.GetString(4);
                            rawData.Amount = reader.GetFloat(5);
                            rawData.Convenience_fee = reader.GetFloat(6);
                            rawData.Wallet_Id = reader.GetString(7);
                            rawData.Ecpaytrackingno = reader.GetString(8);
                            rawData.Customer_Fullname = reader.GetString(9);
                            rawData.Total = reader.GetFloat(10);
                            rawData.Status = reader.GetString(11);
                            rawData.Customer_Number = reader.GetString(12);

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

        public static List<DBPostpaidBillTransaction> GetDataByDate(DateTime past, DateTime present)
        {
            List<DBPostpaidBillTransaction> data = new List<DBPostpaidBillTransaction>();

            MySqlConnection con = DBConnection.ConnectDatabase();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE date BETWEEN '" + past.ToString("yyyy-MM-dd") + " 0:0:0" + "' AND '" + present.ToString("yyyy-MM-dd") + " 23:59:59" + "' ORDER BY id DESC", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPostpaidBillTransaction rawData = new DBPostpaidBillTransaction();
                        rawData.Id = reader.GetInt32(0);
                        rawData.Date = reader.GetDateTime(1);
                        rawData.BillsCode = reader.GetString(2);
                        rawData.Parameter1 = reader.GetString(3);
                        rawData.Parameter2 = reader.GetString(4);
                        rawData.Amount = reader.GetFloat(5);
                        rawData.Convenience_fee = reader.GetFloat(6);
                        rawData.Wallet_Id = reader.GetString(7);
                        rawData.Ecpaytrackingno = reader.GetString(8);
                        rawData.Customer_Fullname = reader.GetString(9);
                        rawData.Total = reader.GetFloat(10);
                        rawData.Status = reader.GetString(11);
                        rawData.Customer_Number = reader.GetString(12);

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

        public static List<DBPostpaidBillTransaction> GetDataByWallet(string wallet, DateTime past, DateTime present)
        {

            List<DBPostpaidBillTransaction> data = new List<DBPostpaidBillTransaction>();

            MySqlConnection con = DBConnection.ConnectDatabase();
            try
            {   // AND
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE (date BETWEEN '" + past.ToString("yyyy-MM-dd") + " 0:0:0" + "' AND '" + present.ToString("yyyy-MM-dd") + " 23:59:59" + "') AND wallet_id ='" + wallet + "' ORDER BY id DESC", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPostpaidBillTransaction rawData = new DBPostpaidBillTransaction();
                        rawData.Id = reader.GetInt32(0);
                        rawData.Date = reader.GetDateTime(1);
                        rawData.BillsCode = reader.GetString(2);
                        rawData.Parameter1 = reader.GetString(3);
                        rawData.Parameter2 = reader.GetString(4);
                        rawData.Amount = reader.GetFloat(5);
                        rawData.Convenience_fee = reader.GetFloat(6);
                        rawData.Wallet_Id = reader.GetString(7);
                        rawData.Ecpaytrackingno = reader.GetString(8);
                        rawData.Customer_Fullname = reader.GetString(9);
                        rawData.Total = reader.GetFloat(10);
                        rawData.Status = reader.GetString(11);
                        rawData.Customer_Number = reader.GetString(12);

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


        public static List<DBPostpaidBillTransaction> GetDataByWalletStatus(string wallet, DateTime past, DateTime present)
        {

            List<DBPostpaidBillTransaction> data = new List<DBPostpaidBillTransaction>();

            MySqlConnection con = DBConnection.ConnectDatabase();
            try
            {   // AND
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE (date BETWEEN '" + past.ToString("yyyy-MM-dd") + " 0:0:0" + "' AND '" + present.ToString("yyyy-MM-dd") + " 23:59:59" + "') AND wallet_id ='" + wallet + "' AND (status='Paid' OR status='Pending')", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPostpaidBillTransaction rawData = new DBPostpaidBillTransaction();
                        rawData.Id = reader.GetInt32(0);
                        rawData.Date = reader.GetDateTime(1);
                        rawData.BillsCode = reader.GetString(2);
                        rawData.Parameter1 = reader.GetString(3);
                        rawData.Parameter2 = reader.GetString(4);
                        rawData.Amount = reader.GetFloat(5);
                        rawData.Convenience_fee = reader.GetFloat(6);
                        rawData.Wallet_Id = reader.GetString(7);
                        rawData.Ecpaytrackingno = reader.GetString(8);
                        rawData.Customer_Fullname = reader.GetString(9);
                        rawData.Total = reader.GetFloat(10);
                        rawData.Status = reader.GetString(11);
                        rawData.Customer_Number = reader.GetString(12);

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

        public static DBPostpaidBillTransaction GetDataById(int idx)
        {
            DBPostpaidBillTransaction data = null;

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE id=" + idx, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    data.Id = reader.GetInt32(0);
                    data.Date = reader.GetDateTime(1);
                    data.BillsCode = reader.GetString(2);
                    data.Parameter1 = reader.GetString(3);
                    data.Parameter2 = reader.GetString(4);
                    data.Amount = reader.GetFloat(5);
                    data.Convenience_fee = reader.GetFloat(6);
                    data.Wallet_Id = reader.GetString(7);
                    data.Ecpaytrackingno = reader.GetString(8);
                    data.Customer_Fullname = reader.GetString(9);
                    data.Total = reader.GetFloat(10);
                    data.Status = reader.GetString(11);
                    data.Customer_Number = reader.GetString(12);

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

        public static DBPostpaidBillTransaction GetDataSendingStatus(string s)
        {
            DBPostpaidBillTransaction data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE id=(SELECT MIN(id) from " + tablename + " WHERE status='" + s + "')", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data.Id = reader.GetInt32(0);
                    data.Date = reader.GetDateTime(1);
                    data.BillsCode = reader.GetString(2);
                    data.Parameter1 = reader.GetString(3);
                    data.Parameter2 = reader.GetString(4);
                    data.Amount = reader.GetFloat(5);
                    data.Convenience_fee = reader.GetFloat(6);
                    data.Wallet_Id = reader.GetString(7);
                    data.Ecpaytrackingno = reader.GetString(8);
                    data.Customer_Fullname = reader.GetString(9);
                    data.Total = reader.GetFloat(10);
                    data.Status = reader.GetString(11);
                    data.Customer_Number = reader.GetString(12);

                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return data;
        }

        public static DBPostpaidBillTransaction GetDataBytrackIdWallet(int idx, string wallet)
        {
            DBPostpaidBillTransaction data = null;

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE id='" + idx+ "' AND wallet_id='"+wallet+"'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data.Id = reader.GetInt32(0);
                    data.Date = reader.GetDateTime(1);
                    data.BillsCode = reader.GetString(2);
                    data.Parameter1 = reader.GetString(3);
                    data.Parameter2 = reader.GetString(4);
                    data.Amount = reader.GetFloat(5);
                    data.Convenience_fee = reader.GetFloat(6);
                    data.Wallet_Id = reader.GetString(7);
                    data.Ecpaytrackingno = reader.GetString(8);
                    data.Customer_Fullname = reader.GetString(9);
                    data.Total = reader.GetFloat(10);
                    data.Status = reader.GetString(11);
                    data.Customer_Number = reader.GetString(12);

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

        public static DBPostpaidBillTransaction GetDataLast()
        {
            DBPostpaidBillTransaction data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " ORDER BY id DESC LIMIT 1", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBPostpaidBillTransaction();
                    data.Id = reader.GetInt32(0);
                    data.Date = reader.GetDateTime(1);
                    data.BillsCode = reader.GetString(2);
                    data.Parameter1 = reader.GetString(3);
                    data.Parameter2 = reader.GetString(4);
                    data.Amount = reader.GetFloat(5);
                    data.Convenience_fee = reader.GetFloat(6);
                    data.Wallet_Id = reader.GetString(7);
                    data.Ecpaytrackingno = reader.GetString(8);
                    data.Customer_Fullname = reader.GetString(9);
                    data.Total = reader.GetFloat(10);
                    data.Status = reader.GetString(11);
                    data.Customer_Number = reader.GetString(12);

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
