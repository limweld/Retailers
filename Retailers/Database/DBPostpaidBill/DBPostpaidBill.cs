using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Retailers.Database.DBPostpaidBill
{
    class DBPostpaidBill
    {
        private static string tablename = "tblbillers";

        private int id;
        private int categorycode;
        private string billerTag;
        private string description; 
        private string firstField;
        private string firstFieldFormat;
        private int firstFieldWidth;
        private string secondField;
        private string secondFieldFormat;
        private int secondFieldWidth;
        private float serviceCharge;
        private DateTime lastupdated;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Categorycode
        {
            get { return categorycode; }
            set { categorycode = value; }
        }

        public string BillerTag
        {
            get { return billerTag; }
            set { billerTag = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string FirstField
        {
            get { return firstField; }
            set { firstField = value; }
        }

        public string FirstFieldFormat
        {
            get { return firstFieldFormat; }
            set { firstFieldFormat = value; }
        }

        public int FirstFieldWidth
        {
            get { return firstFieldWidth; }
            set { firstFieldWidth = value; }
        }

        public string SecondField
        {
            get { return secondField; }
            set { secondField = value; }
        }

        public string SecondFieldFormat
        {
            get { return secondFieldFormat; }
            set { secondFieldFormat = value; }
        }

        public int SecondFieldWidth
        {
            get { return secondFieldWidth; }
            set { secondFieldWidth = value; }
        }

        public float ServiceCharge
        {
            get { return serviceCharge; }
            set { serviceCharge = value; }
        }

        public DateTime Lastupdated
        {
            get { return lastupdated; }
            set { lastupdated = value; }
        }

        public DBPostpaidBill()
        {

        }

        public DBPostpaidBill( int id, int categorycode, string billerTag, string description, string firstField, string firstFieldFormat,
        int firstFieldWidth, string secondField, string secondFieldFormat, int secondFieldWidth, float serviceCharge, DateTime lastupdated)
        {
            this.id = id;
            this.categorycode = categorycode;
            this.billerTag = billerTag;
            this.description = description;
            this.firstField = firstField;
            this.FirstFieldFormat = firstFieldFormat;
            this.firstFieldWidth = firstFieldWidth;
            this.secondField = secondField;
            this.secondFieldFormat = secondFieldFormat;
            this.secondFieldWidth =  secondFieldWidth;
            this.serviceCharge = serviceCharge;
            this.lastupdated = lastupdated;
        }

        public void Add(int categorycode, string billerTag, string description, string firstField, string firstFieldFormat, string firstFieldWidth, string secondField, string secondFieldFormat, string secondFieldWidth, string serviceCharge, DateTime lastupdated)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0,@categorycode, @BillerTag, @Description, @FirstField, @FirstFieldFormat, @FirstFieldWidth, @SecondField, @SecondFieldFormat, @SecondFieldWidth, @ServiceCharge, @lastupdated )";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
               MySqlCommand cmd = new MySqlCommand(cmdText, con);
               cmd.Parameters.AddWithValue("@categorycode",categorycode); 
               cmd.Parameters.AddWithValue("@BillerTag",billerTag); 
               cmd.Parameters.AddWithValue("@Description",description); 
               cmd.Parameters.AddWithValue("@FirstField",firstField);
               cmd.Parameters.AddWithValue("@FirstFieldFormat",firstFieldFormat); 
               cmd.Parameters.AddWithValue("@FirstFieldWidth",firstFieldWidth); 
               cmd.Parameters.AddWithValue("@SecondField",secondField); 
               cmd.Parameters.AddWithValue("@SecondFieldFormat",secondFieldFormat); 
               cmd.Parameters.AddWithValue("@SecondFieldWidth",secondFieldWidth); 
               cmd.Parameters.AddWithValue("@ServiceCharge",serviceCharge);
               cmd.Parameters.AddWithValue("@lastupdated", lastupdated);

               MessageBox.Show("New Insert Data !");
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

        public void Update(string id, int categorycode, string billerTag, string description, string firstField, string firstFieldFormat, string firstFieldWidth, string secondField, string secondFieldFormat, string secondFieldWidth, string serviceCharge, DateTime lastupdated)
        {
            string cmdText = "UPDATE " + tablename + " SET categorycode = @categorycode, BillerTag = @BillerTag, Description = @Description, FirstField = @FirstField, FirstFieldFormat = @FirstFieldFormat, FirstFieldWidth = @FirstFieldWidth, SecondField = @SecondField, SecondFieldFormat = @SecondFieldFormat, SecondFieldWidth = @SecondFieldWidth, ServiceCharge = @ServiceCharge, lastupdated = @lastupdated WHERE id = @id ";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@categorycode", categorycode);
                cmd.Parameters.AddWithValue("@BillerTag", billerTag);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@FirstField", firstField);
                cmd.Parameters.AddWithValue("@FirstFieldFormat", firstFieldFormat);
                cmd.Parameters.AddWithValue("@FirstFieldWidth", firstFieldWidth);
                cmd.Parameters.AddWithValue("@SecondField", secondField);
                cmd.Parameters.AddWithValue("@SecondFieldFormat", secondFieldFormat);
                cmd.Parameters.AddWithValue("@SecondFieldWidth", secondFieldWidth);
                cmd.Parameters.AddWithValue("@ServiceCharge", serviceCharge);
                cmd.Parameters.AddWithValue("@lastupdated", lastupdated);

                MessageBox.Show("Update Successfully");
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static List<DBPostpaidBill> GetData()
        {
            List<DBPostpaidBill> data = new List<DBPostpaidBill>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPostpaidBill rawData = new DBPostpaidBill();

                        rawData.Id = reader.GetInt32(0);
                        rawData.Categorycode = reader.GetInt32(1);
                        rawData.BillerTag = reader.GetString(2);
                        rawData.Description = reader.GetString(3);
                        rawData.FirstField = reader.GetString(4);
                        rawData.FirstFieldFormat = reader.GetString(5);
                        rawData.FirstFieldWidth = reader.GetInt32(6);
                        rawData.SecondField = reader.GetString(7);
                        rawData.SecondFieldFormat = reader.GetString(8);
                        rawData.SecondFieldWidth = reader.GetInt32(9);
                        rawData.ServiceCharge = reader.GetFloat(10);
                        rawData.Lastupdated = reader.GetDateTime(11);

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

        public static DBPostpaidBill GetDataByCode(string code)
        {
            DBPostpaidBill data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE BillerTag ='" + code+"'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBPostpaidBill();
					data.Id = reader.GetInt32(0);
					data.Categorycode = reader.GetInt32(1);
					data.BillerTag = reader.GetString(2);
					data.Description = reader.GetString(3);
					data.FirstField = reader.GetString(4);
					data.FirstFieldFormat = reader.GetString(5);
					data.FirstFieldWidth = reader.GetInt32(6);
					data.SecondField = reader.GetString(7);
					data.SecondFieldFormat = reader.GetString(8);
					data.SecondFieldWidth = reader.GetInt32(9);
                    data.ServiceCharge = reader.GetFloat(10);
                    data.Lastupdated = reader.GetDateTime(11);
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

        public static List<DBPostpaidBill> GetDataBillerTag(string code)
        {
            List<DBPostpaidBill> data = new List<DBPostpaidBill>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE  BillerTag LIKE '%" + code + "%'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPostpaidBill rawData = new DBPostpaidBill();

                        rawData.Id = reader.GetInt32(0);
                        rawData.Categorycode = reader.GetInt32(1);
                        rawData.BillerTag = reader.GetString(2);
                        rawData.Description = reader.GetString(3);
                        rawData.FirstField = reader.GetString(4);
                        rawData.FirstFieldFormat = reader.GetString(5);
                        rawData.FirstFieldWidth = reader.GetInt32(6);
                        rawData.SecondField = reader.GetString(7);
                        rawData.SecondFieldFormat = reader.GetString(8);
                        rawData.SecondFieldWidth = reader.GetInt32(9);
                        rawData.ServiceCharge = reader.GetFloat(10);
                        rawData.Lastupdated = reader.GetDateTime(11);

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
