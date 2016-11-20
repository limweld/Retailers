using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Retailers.Database
{
    class DBConnection
    {
        public static MySqlConnection ConnectDatabase()
        {
            MySqlConnection con = null;
            String connectionStr = @"server=localhost; database=my_db; userid=root; password=;pooling = false; convert zero datetime=True";

            try
            {
                con = new MySqlConnection(connectionStr);
                con.Open(); //open the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection : "+ex.Message);
            }

            return con;
        }

        public static MySqlConnection ConnectLocalAddressDatabase()
        {
            MySqlConnection con = null;
            String connectionStr = @"server=localhost; database=local_address; userid=root; password=;";

            try
            {
                con = new MySqlConnection(connectionStr);
                con.Open(); //open the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return con;
        }
    }
}
