using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Text.RegularExpressions;

namespace Retailers.Forms
{
    public partial class Retailers : MetroForm
    {
        public Retailers()
        {
            InitializeComponent();
        }

        public string Wallet_ID
        {
            get { return Regex.Replace(this.maskedTextBox_Wallet_Id.Text, "-", ""); }
            set { this.maskedTextBox_Wallet_Id.Text = value; }
        }

        public string Sponsor_ID
        {
            get{ return Regex.Replace(this.maskedText_Sponsor_ID.Text, "-", ""); }
            set{ this.maskedText_Sponsor_ID.Text = value; }
        }

        public string Firstname
        {
            get { return this.textBox_Firstname.Text; }
            set { this.textBox_Firstname.Text = value; }
        }

        public string Lastname
        {
            get { return this.textBox_Lastname.Text; }
            set { this.textBox_Lastname.Text = value; }
        }

        public DateTime DateRegistered
        {
            get { return this.dateTimePicker_dateReg.Value; }
            set { this.dateTimePicker_dateReg.Value = value; }
        }

        public DateTime Birthdate
        {
            get { return Convert.ToDateTime(this.dateTimePicker_BirthDate.Value.ToShortDateString()); }
            set { this.dateTimePicker_BirthDate.Value = value; }
        }

        public float Balance
        {
            get { return 0; }
            set { this.textbox_Balance.Text = Convert.ToString(value); }
        }

        public float Frozen
        {
            get { return (float)(Convert.ToDouble(this.textbox_Frozen.Text)); }
            set { this.textbox_Frozen.Text = Convert.ToString(value); }
        }

        public string BlockStr
        {
            get { return this.textBox_Street.Text; }
            set { this.textBox_Street.Text = value; }
        }

        public string City
        {
            get 
            {
                this.textbox_City.Text = this.comboBox_City.Text;
                return this.textbox_City.Text; 
            }
            set 
            {
                
                this.textbox_City.Text = value; 
            }
        }

        public string Barangay
        {
            get 
            {    
                return this.textbox_Barangay.Text; 
            }
            set 
            {
                this.textbox_Barangay.Text = value; 
            }
        }

        public string Province
        {
            get
            {
                return this.textbox_Province.Text; 
            }
            set 
            {
                this.textbox_Province.Text = value;
            }
        }

        private void Retailers_Load(object sender, EventArgs e)
        {
            load_ProviceList();
            load_dataGridView_Retailer();
            buttonEnable(false);
            this.cmd_Add.Enabled = this.cmd_Cancel.Enabled = true;
        }

        public void load_dataGridView_Retailer()
        {
            Cursor.Current = Cursors.WaitCursor;
            BindingSource bindingsource = new BindingSource();

            List<Database.DBRetailers> rec = Database.DBRetailers.GetData();
            foreach (Database.DBRetailers data in rec)

                bindingsource.Add(new Database.DBRetailers(
                data.Wallet_Id,
                data.Date,
                data.Fname,
                data.Lname,
                data.Balance,
                data.Frozen,
                data.Sponsor_Id,
                data.Province,
                data.City,
                data.Barangay,
                data.BlockStr,
                data.Birth_Date
                ));

            this.dataGridView_Retailer.AutoGenerateColumns = false;
            this.dataGridView_Retailer.DataSource = bindingsource;
            this.dataGridView_Retailer.ClearSelection();

            Cursor.Current = Cursors.Default;
        }


        private void load_ProviceList(){
            List<Database.DBLocalAddress.DBProvinces> obj;

            obj = Database.DBLocalAddress.DBProvinces.GetData();
            this.comboBox_Province.Items.Clear();
            foreach (Database.DBLocalAddress.DBProvinces rec in obj)
            {
                this.comboBox_Province.Items.Add(rec);
            }
        }

        private void cmd_Cancel_Click(object sender, EventArgs e)
        {
           

            input_enableStatus(true);
            input_clear();
            buttonEnable(false);
            cmd_Add.Enabled = true;

            load_ProviceList();
            this.maskedTextBox_Wallet_Id.Enabled = true;
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            load_ProviceList();
            if(input_Validity()==true){
                Database.DBRetailers r =new Database.DBRetailers();
                r.Add(DateRegistered,Wallet_ID,Firstname,Lastname,Birthdate,Barangay,City,Province,BlockStr,Balance,Frozen,Sponsor_ID);

                load_dataGridView_Retailer();
                input_clear();
            
                this.cmd_Save.Enabled = this.cmd_Delete.Enabled = false;
            }
        }

 

        private void comboBox_Province_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Database.DBLocalAddress.DBProvinces itm = (Database.DBLocalAddress.DBProvinces)this.comboBox_Province.SelectedItem;
            List<Database.DBLocalAddress.DBCities> obj;

            try
            {
                obj = Database.DBLocalAddress.DBCities.GetDataByProvice(itm.ID);
                this.comboBox_City.Items.Clear();
                foreach (Database.DBLocalAddress.DBCities rec in obj)
                {
                    this.comboBox_City.Items.Add(rec);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            Province = this.comboBox_Province.SelectedText;
        }

        private void comboBox_City_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Database.DBLocalAddress.DBCities itm = (Database.DBLocalAddress.DBCities)this.comboBox_City.SelectedItem;
            List<Database.DBLocalAddress.DBBarangays> obj;

            try
            {
                obj = Database.DBLocalAddress.DBBarangays.GetDataByCity(itm.ID);
                this.comboBox_Barangay.Items.Clear();
                foreach (Database.DBLocalAddress.DBBarangays rec in obj)
                {
                    this.comboBox_Barangay.Items.Add(rec);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private bool input_Validity()
        {
            if (Firstname.Equals("") || Lastname.Equals("")|| maskedTextBox_Wallet_Id.Equals("")|| 
                Province.Equals("")||City.Equals("")||Barangay.Equals("")||BlockStr.Equals(""))
                {
                    MessageBox.Show("Incomplete Fields");
                    return false;
                } 

                return true;
             
        }

        private void input_enableStatus(bool stat)
        {
            this.textBox_Firstname.Enabled =
            this.textBox_Lastname.Enabled =
            this.maskedTextBox_Wallet_Id.Enabled =
            this.textBox_Street.Enabled =
            this.comboBox_Province.Enabled =
            this.comboBox_City.Enabled =
            this.comboBox_Barangay.Enabled =
            this.dateTimePicker_dateReg.Enabled =
            this.dateTimePicker_BirthDate.Enabled = stat;
        }

        private void cmd_Edit_Click(object sender, EventArgs e)
        {
           
            input_enableStatus(true);
            this.maskedTextBox_Wallet_Id.Enabled = false;

            buttonEnable(false);
            input_enableStatus(true);
            this.cmd_Save.Enabled = this.cmd_Delete.Enabled = true;
            this.maskedTextBox_Wallet_Id.Enabled = false;
        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            if (input_Validity() == true)
            {
                Database.DBRetailers edit = new Database.DBRetailers();
                edit.Update(DateRegistered, Wallet_ID, Firstname, Lastname, Birthdate, Barangay, City, Province, BlockStr);

                int selectedIndex = this.dataGridView_Retailer.CurrentCell.RowIndex;
                this.dataGridView_Retailer.Rows[selectedIndex].SetValues(Wallet_ID, DateRegistered.ToShortDateString(), Firstname, Lastname, Birthdate.ToShortDateString(), BlockStr, Barangay, City, Province);


                input_enableStatus(false);
                buttonEnable(false);
                this.cmd_Edit.Enabled = true;

               
            }
        }

        private void cmd_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(" Are You Sure ? ", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                Database.DBRetailers del = new Database.DBRetailers();
                del.Delete(Wallet_ID);

                load_dataGridView_Retailer();

                this.cmd_Delete.Enabled = this.cmd_Save.Enabled = false;
                this.cmd_Add.Enabled = true;
                input_clear();
            }
        }

        private void input_clear()
        {
            
            Firstname = Lastname = Wallet_ID = BlockStr  = Province = City = Barangay = "";
            Balance = 0;
            DateRegistered = DateTime.Now;
            Birthdate = DateTime.Now;
        }

 
        private void dataGridView_Retailer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                DataGridViewRow selectedRow = dataGridView_Retailer.Rows[index];
                Wallet_ID = selectedRow.Cells[0].Value.ToString();
                DateRegistered = Convert.ToDateTime(selectedRow.Cells[1].Value.ToString());
                Firstname = selectedRow.Cells[2].Value.ToString();
                Lastname = selectedRow.Cells[3].Value.ToString();
                Birthdate = Convert.ToDateTime(selectedRow.Cells[4].Value.ToString());
                Province = selectedRow.Cells[8].Value.ToString();
                City = selectedRow.Cells[7].Value.ToString();
                Barangay = selectedRow.Cells[6].Value.ToString();
                BlockStr = selectedRow.Cells[5].Value.ToString();
                Balance = (float)(Convert.ToDouble(selectedRow.Cells[10].Value.ToString()));

                buttonEnable(false);
                input_enableStatus(false);
                this.cmd_Edit.Enabled = this.cmd_Cancel.Enabled = true;
                this.maskedTextBox_Wallet_Id.Enabled = false;
            }catch(Exception ex){
                ex.ToString();
            }
                  
        }

        private void buttonEnable(bool stat)
        {
            this.cmd_Add.Enabled = this.cmd_Edit.Enabled = this.cmd_Save.Enabled = this.cmd_Delete.Enabled = stat;
        }

        private void comboBox_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Database.DBLocalAddress.DBProvinces itm = (Database.DBLocalAddress.DBProvinces)comboBox_Province.SelectedItem;

                List<Database.DBLocalAddress.DBCities> obj;
                obj = Database.DBLocalAddress.DBCities.GetDataByProvice(itm.ID);

                this.comboBox_City.Items.Clear();

                foreach (Database.DBLocalAddress.DBCities rec in obj)
                {
                    this.comboBox_City.Items.Add(rec);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            Province = this.comboBox_Province.SelectedItem.ToString();
            
        }

        private void comboBox_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Database.DBLocalAddress.DBCities itm = (Database.DBLocalAddress.DBCities)comboBox_City.SelectedItem;

                List<Database.DBLocalAddress.DBBarangays> obj;

                obj = Database.DBLocalAddress.DBBarangays.GetDataByCity(itm.ID);
                this.comboBox_Barangay.Items.Clear();
                this.comboBox_Barangay.PromptText = "";

                foreach (Database.DBLocalAddress.DBBarangays rec in obj)
                {
                    this.comboBox_Barangay.Items.Add(rec);
                }
            }catch(Exception ex){
                ex.ToString();
            }
            City = this.comboBox_City.SelectedItem.ToString();
            
        }

        private void comboBox_Barangay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Barangay = this.comboBox_Barangay.SelectedItem.ToString();
        }

        private void dataGridView_Retailer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Forms.History l = new Forms.History();
            l.Show();
            l.Wallet = Wallet_ID;
        }

        private void dataGridView_Retailer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void metroButtonrefresh_Click(object sender, EventArgs e)
        {
            load_dataGridView_Retailer();
        }

      

    }
}
