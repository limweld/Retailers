using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Retailers.Database.DBPostpaidBill
{
    class DBPostPaidBillCategory
    {
        private static string tablename = "tblbillercategory";

        private int id;
        private string category;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public DBPostPaidBillCategory()
        {

        }

        public DBPostPaidBillCategory(int id,string category)
        {
            this.category = category;
            this.id = id;
        }

        public static List<DBPostPaidBillCategory> GetData()
        {
            List<DBPostPaidBillCategory> data = new List<DBPostPaidBillCategory>();

            MySqlConnection con = DBConnection.ConnectDatabase();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tablename, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DBPostPaidBillCategory rawData = new DBPostPaidBillCategory();
                        rawData.Id = reader.GetInt32(0);
                        rawData.Category = reader.GetString(1);
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
