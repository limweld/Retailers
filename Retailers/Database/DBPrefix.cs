using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Retailers.Database
{
    class DBPrefix
    {
        private string tablename = "prefixes";
        
        private string smart;
        private string globe;
        private string sun;

        public string Smart
        {
            get { return smart; }
            set { smart = value; }
        }

        public string Globe
        {
            get { return globe; }
            set { globe = value; }
        }

        public string Sun
        {
            get { return sun; }
            set { sun = value; }
        }

        public void Add(string smart, string globe, string sun)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0,@smart,@globe,@sun)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@smart", smart);
                cmd.Parameters.AddWithValue("@globe", globe);
                cmd.Parameters.AddWithValue("@sun", sun);

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

        public void Update(string column, string data)
        {
            string cmdText = "UPDATE " + tablename + " SET " + column + " = @data WHERE id = 1";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@data", data);
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public List<DBPrefix> GetData()
        {
            List<DBPrefix> data = new List<DBPrefix>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrefix rawData = new DBPrefix();
                        rawData.Smart = reader.GetString(1);
                        rawData.Globe = reader.GetString(2);
                        rawData.Sun = reader.GetString(3);

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

        public DBPrefix SearchPrefix()
        {
            DBPrefix data = new DBPrefix();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data.Smart = reader.GetString(1);
                        data.Globe = reader.GetString(2);
                        data.Sun = reader.GetString(3);
                    }
                }
                else
                    data = null;

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
