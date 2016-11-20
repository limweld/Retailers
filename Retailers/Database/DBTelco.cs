using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Retailers.Database
{
    class DBTelco
    {
        private string tablename = "telco";

        private string telconame;


        public string TelcoName
        {
            get { return telconame; }
            set { telconame = value; }
        }

        public void Add(string telconame)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(@telconame)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@telconame", telconame);

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

        public void Update(string previousname, string newname)
        {
            string cmdText = "UPDATE " + tablename + " SET telconame = @newname WHERE telconame = @previousname";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@previousname", previousname);
                cmd.Parameters.AddWithValue("@newname", newname);
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

        public void Delete(string telconame)
        {
            MySqlConnection con = DBConnection.ConnectDatabase();
            string command = "DELETE FROM " + tablename + " WHERE telconame=@telconame";

            try
            {
                MySqlCommand cmd = new MySqlCommand(command, con);
                cmd.Parameters.AddWithValue("@telconame", telconame);

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

        public List<DBTelco> GetData()
        {
            List<DBTelco> data = new List<DBTelco>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                cmd.Parameters.AddWithValue("@telconame", telconame);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBTelco rawData = new DBTelco();
                        rawData.TelcoName = reader.GetString(0);

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
    }
}
