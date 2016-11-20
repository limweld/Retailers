using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Retailers.Database.DBLocalAddress
{ 
    class DBBarangays
    {
        private static string tablename = "barangay";

        private int id;
        private string name;
        private string city;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public string CITY
        {
            get { return city; }
            set { city = value; }
        }

        public static List<DBBarangays> GetData()
        {
            List<DBBarangays> data = new List<DBBarangays>();

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBBarangays rawData = new DBBarangays();
                        rawData.ID = reader.GetInt32(0);
                        rawData.NAME = reader.GetString(1);
                        rawData.CITY = reader.GetString(2);
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

        public static List<DBBarangays> GetDataByCity(int idx)
        {
            List<DBBarangays> data = new List<DBBarangays>();

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE city_id=" + idx, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBBarangays rawData = new DBBarangays();
                        rawData.ID = reader.GetInt32(0);
                        rawData.NAME = reader.GetString(1);
                        rawData.CITY = reader.GetString(2);
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

        public static DBBarangays GetDataById(int idx)
        {
            DBBarangays data = null;

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE barangay_id=" + idx, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBBarangays();
                    data.ID = reader.GetInt32(0);
                    data.NAME = reader.GetString(1);
                    data.CITY = reader.GetString(2);
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

        public static DBBarangays GetDataByName(string idx)
        {
            DBBarangays data = null;

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE barangay='" + idx + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBBarangays();
                    data.ID = reader.GetInt32(0);
                    data.NAME = reader.GetString(1);
                    data.CITY = reader.GetString(2);
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

        public override string ToString()
        {
            // Generates the text shown in the combo box
            return this.NAME;
        }
    }
}


