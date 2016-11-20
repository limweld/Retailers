using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace Retailers.Database.DBLocalAddress
{
    class DBProvinces
    {
        private static string tablename = "province";

        private int id;
        private string name;
        
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


        public static List<DBProvinces> GetData()
        {
            List<DBProvinces> data = new List<DBProvinces>();

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBProvinces rawData = new DBProvinces();
                        rawData.ID = reader.GetInt32(0);
                        rawData.NAME = reader.GetString(1);
                        
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

        public static DBProvinces GetDataById(int idx)
        {
            DBProvinces data = null;

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE province=" + idx, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBProvinces();
                    data.ID = reader.GetInt32(0);
                    data.NAME = reader.GetString(1);

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

        public static DBProvinces GetDataByName(string idx)
        {
            DBProvinces data = null;

            MySqlConnection con = DBConnection.ConnectLocalAddressDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE province='" + idx +"'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBProvinces();
                    data.ID = reader.GetInt32(0);
                    data.NAME = reader.GetString(1);
                   
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


