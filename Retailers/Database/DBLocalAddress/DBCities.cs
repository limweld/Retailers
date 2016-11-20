using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace Retailers.Database.DBLocalAddress
{
    class DBCities
    {
        private static string tablename = "city";

        private int id;
        private string name;
        private int province_id;

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

        public int PROVID
        {
            get { return province_id; }
            set { province_id = value; }
        }



        public static List<DBCities> GetData()
        {
            List<DBCities> data = new List<DBCities>();

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBCities rawData = new DBCities();
                        rawData.ID = reader.GetInt32(0);
                        rawData.NAME = reader.GetString(1);
                        rawData.PROVID = reader.GetInt32(2);
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

        public static List<DBCities> GetDataByProvice(int idx)
        {
            List<DBCities> data = new List<DBCities>();

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE province_id=" + idx, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBCities rawData = new DBCities();
                        rawData.ID = reader.GetInt32(0);
                        rawData.NAME = reader.GetString(1);
                        rawData.PROVID = reader.GetInt32(2);
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

        public static DBCities GetDataById(int idx)
        {
            DBCities data = null;

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE city_id=" + idx, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBCities();
                    data.ID = reader.GetInt32(0);
                    data.NAME = reader.GetString(1);
                    data.PROVID = reader.GetInt32(2);
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

        public static DBCities GetDataByName(string idx)
        {
            DBCities data = null;

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE city='" + idx + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBCities();
                    data.ID = reader.GetInt32(0);
                    data.NAME = reader.GetString(1);
                    data.PROVID = reader.GetInt32(2);
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

