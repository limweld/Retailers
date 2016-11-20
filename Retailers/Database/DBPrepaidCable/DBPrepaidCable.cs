using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Retailers.Database.DBPrepaidCable
{
    class DBPrepaidCable
    {
        private static string tablename = "prepaidcable";

        private int id;
        private string code;
        private string description;
        private string gateway;
       
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Gateway
        {
            get { return gateway; }
            set { gateway = value; }
        }

        public DBPrepaidCable()
        {

        }

        public DBPrepaidCable( int id, string code, string description, string gateway)
        {
            this.id = id;
            this.code = code;
            this.description = description;
            this.gateway = gateway;
        }

        public void Add(string code, string description, string gateway)
        {
            string cmdText = "INSERT INTO " + tablename + " VALUES(0,@code,@description,@gateway)";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@gateway",gateway);

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

        public void Update(string id, string code, string description, string gateway)
        {
            string cmdText = "UPDATE " + tablename + " SET code=@code, description=@description, gateway=@gateway WHERE id=@id";
            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@description",description);
                cmd.Parameters.AddWithValue("@gateway",gateway);
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

        public static List<DBPrepaidCable> GetData()
        {
            List<DBPrepaidCable> data = new List<DBPrepaidCable>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPrepaidCable rawData = new DBPrepaidCable();
                        rawData.Id = reader.GetInt32(0);
                        rawData.Code = reader.GetString(1);
                        rawData.Description = reader.GetString(2);
                        rawData.Gateway = reader.GetString(3);

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

        public static DBPrepaidCable GetDataById(int idx)
        {
            DBPrepaidCable data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE id =" + idx, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBPrepaidCable();
                    data.Id = reader.GetInt32(0);
                    data.Code = reader.GetString(1);
                    data.Description = reader.GetString(2);
                    data.Gateway = reader.GetString(3);
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

        public static DBPrepaidCable GetDataByCode(string code)
        {
            DBPrepaidCable data = null;

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename + " WHERE code ='" + code+"'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    data = new DBPrepaidCable();
                    data.Id = reader.GetInt32(0);
                    data.Code = reader.GetString(1);
                    data.Description = reader.GetString(2);
                    data.Gateway = reader.GetString(3);
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
            return this.Code;
        }

      
    }
}
