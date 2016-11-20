using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Retailers.Database
{
    public class DBRetailers
    {
        private static string tablename = "retailers";

        private string wallet_id;
        private DateTime date;
        private string fname;
        private string lname;
        private float balance;
        private float frozen;
        private string sponsor_id;
        private string province;
        private string city;
        private string barangay;
        private string blockStr;
        private DateTime birthDate;

        public string Wallet_Id
        {
            get{ return wallet_id; }
            set{ wallet_id = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public float Frozen
        {
            get { return frozen; }
            set { frozen = value; }
        }

        public string Sponsor_Id
        {
            get { return sponsor_id; }
            set { sponsor_id = value; }
        }

        public DateTime Birth_Date
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Barangay
        {
            get { return barangay; }
            set { barangay = value; }
        }

        public string BlockStr
        {
            get { return blockStr; }
            set { blockStr = value; }
        }

        //DateRegistered,Wallet_ID,Firstname,Lastname,Birthdate,Barangay,City,Province,BlockStr,Balance,Frozen,Sponsor_ID
        public DBRetailers()
        {

        }

        public DBRetailers( string wallet_id,DateTime date,string fname,string lname,float balance,float frozen,string sponsor_id,string province, string city, string barangay, string blockStr, DateTime birthDate)
        {
            this.wallet_id = wallet_id;
            this.date = date;
            this.fname = fname;
            this.lname = lname;
            this.balance = balance;
            this.frozen = frozen;
            this.sponsor_id = sponsor_id;
            this.province = province;
            this.city = city;
            this.barangay = barangay;
            this.blockStr = blockStr;
            this.birthDate = birthDate;
        }

        public void Add(DateTime dater, string wallet, string fname, string lname, DateTime bDay, string barangay,
            string city, string province, string block, float bal, float froz, string sponsor)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(@date, @wallet_id, @fname, @lname, @birthdate, @province, @city, @barangay, @blockstr, @balance, @frozen, @sponsor_id)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@date", dater);
                cmd.Parameters.AddWithValue("@wallet_id", wallet);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@birthdate", bDay);
                cmd.Parameters.AddWithValue("@province", province);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@barangay", barangay);
                cmd.Parameters.AddWithValue("@blockStr", block);
                cmd.Parameters.AddWithValue("@balance", bal);
                cmd.Parameters.AddWithValue("@frozen", froz);
                cmd.Parameters.AddWithValue("@sponsor_id", sponsor);

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
            string command = "DELETE FROM " + tablename + " WHERE wallet_id=@wallet_id";

            try
            {
                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.Parameters.AddWithValue("@wallet_id", id);

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

        public void Update(DateTime dater, string wallet, string fname, string lname, DateTime bDay, string barangay,
            string city, string province, string block)
        {
            //String sql = "update tblproductcategory set SCode ='" + value1 + "' ,Description='" + value2 + "' ,Notes ='" + value3 + "' where Scode = '" + scode + "' ";
            string cmdText = "UPDATE " + tablename + " SET date=@date, fname=@fname, lname=@lname, birthdate=@birthdate, province=@province, city=@city, barangay=@barangay, blockstr=@blockstr WHERE wallet_id=@wallet_id";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@date", dater);
                cmd.Parameters.AddWithValue("@wallet_id", wallet);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@birthdate", bDay);
                cmd.Parameters.AddWithValue("@province", province);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@barangay", barangay);
                cmd.Parameters.AddWithValue("@blockStr", block);

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

        public void UpdateBalance(string wallet, float balance)
        {
            //String sql = "update tblproductcategory set SCode ='" + value1 + "' ,Description='" + value2 + "' ,Notes ='" + value3 + "' where Scode = '" + scode + "' ";
            string cmdText = "UPDATE " + tablename + " SET balance=@balance WHERE wallet_id=@wallet_id";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@balance", balance);
                cmd.Parameters.AddWithValue("@wallet_id", wallet);
             

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

        public static List<DBRetailers> GetData()
        {
            List<DBRetailers> data = new List<DBRetailers>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        DBRetailers rawData = new DBRetailers();
                        rawData.Date = reader.GetDateTime(0);
                        rawData.Wallet_Id = reader.GetString(1);
                        rawData.Fname = reader.GetString(2);
                        rawData.Lname = reader.GetString(3);
                        rawData.Birth_Date = reader.GetDateTime(4);
                        rawData.Province = reader.GetString(5);
                        rawData.City = reader.GetString(6);
                        rawData.Barangay = reader.GetString(7);
                        rawData.BlockStr = reader.GetString(8);
                        rawData.Balance = reader.GetFloat(9);
                        rawData.Frozen = reader.GetFloat(10);
                        rawData.Sponsor_Id = reader.GetString(11);

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

        public static DBRetailers GetDataByWallet(string wallet)
        {
            DBRetailers data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE wallet_id='" + wallet + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                        reader.Read();    
                        data = new DBRetailers();

                        data.Date = reader.GetDateTime(0);
                        data.Wallet_Id = reader.GetString(1);
                        data.Fname = reader.GetString(2);
                        data.Lname = reader.GetString(3);
                        data.Birth_Date = reader.GetDateTime(4);
                        data.Province = reader.GetString(5);
                        data.City = reader.GetString(6);
                        data.Barangay = reader.GetString(7);
                        data.BlockStr = reader.GetString(8);
                        data.Balance = reader.GetFloat(9);
                        data.Frozen = reader.GetFloat(10);
                        data.Sponsor_Id = reader.GetString(11);

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
