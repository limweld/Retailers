using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Retailers.Forms
{
    public partial class BillsPrefixAdd : MetroForm
    {
        public BillsPrefixAdd()
        {
            InitializeComponent();
        }

        public string Id
        {
            get { return metroTextBox_Id.Text; }
            set { metroTextBox_Id.Text = value; }
        }

        public int CategoryCode
        {
            get { return comboBox_Category.SelectedIndex+1; }
            set { comboBox_Category.SelectedIndex = value-1;}
        }

        public string BillerTag
        {
            get { return metroTextBox_BillerTag.Text; }
            set { metroTextBox_BillerTag.Text = value;}

        }

        public string Description
        { 
            get { return metroTextBox_Description.Text; }
            set { metroTextBox_Description.Text = value;}

        }

        public string FirstField
        {
            get { return metroTextBox_FirstField.Text; }
            set { metroTextBox_FirstField.Text = value;}

        }

        public string FirstFieldFormat
        {
            get { return metroTextBox_FirstFieldFormat.Text; }
            set { metroTextBox_FirstFieldFormat.Text = value;}
        }

        public string FirstFieldWidth
        {
            get{ return  metroTextBox_FirstField.Text; }
            set{ metroTextBox_FirstFieldWidth.Text = value; }
        }

        public string SecondField
        {
            get { return metroTextBox_SecondField.Text; }
            set { metroTextBox_SecondField.Text = value;}
        }

        public string SecondFieldFormat
        {
            get { return metroTextBox_SecondFieldFormat.Text; }
            set { metroTextBox_SecondFieldFormat.Text = value;}
        }

        public string SecondFieldWidth
        {
            get{ return metroTextBox_SecondField.Text; }
            set{ metroTextBox_SecondFieldWidth.Text = value; }
        }

        public DateTime Date
        {
            get { return dateTimePicker_dateReg.Value; }
            set { dateTimePicker_dateReg.Value = value; }
        }

        public string ServiceCharge
        {
            get{ return this.metroTextBox_ServiceCharcge.Text; }
            set{ this.metroTextBox_ServiceCharcge.Text = value; }
        }

        private void BillsPrefixAdd_Load(object sender, EventArgs e)
        {
            loadlist_category();
            Date = DateTime.Now;
        }

        private void loadlist_category()
        {
            BindingSource bindingsource = new BindingSource();

            List<Database.DBPostpaidBill.DBPostPaidBillCategory> rec = Database.DBPostpaidBill.DBPostPaidBillCategory.GetData();

            foreach (Database.DBPostpaidBill.DBPostPaidBillCategory data in rec)
            {
                this.comboBox_Category.Items.Add(data.Category);
            }
        }

        public void group1Visibility(bool visibility)
        {
            this.cmd_Add.Visible = this.cmd_Cancel.Visible = visibility;
        }

        public void group2Visibility(bool visibility)
        {
            this.cmd_Delete.Visible = this.cmd_Save.Visible = this.metroTextBox_Id.Visible = visibility;
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            Database.DBPostpaidBill.DBPostpaidBill add = new Database.DBPostpaidBill.DBPostpaidBill();
            add.Add(
                CategoryCode,
                BillerTag,
                Description,
                FirstField,
                FirstFieldFormat,
                FirstFieldWidth,
                SecondField,
                SecondFieldFormat,
                SecondFieldWidth,
                ServiceCharge,
                Date
                );

            this.Close();
        }

        private void cmd_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(" Are You Sure ? ", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                Database.DBPostpaidBill.DBPostpaidBill del = new Database.DBPostpaidBill.DBPostpaidBill();
                del.Delete(Id);

                this.Close();
            }

            
         
        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            Database.DBPostpaidBill.DBPostpaidBill up = new Database.DBPostpaidBill.DBPostpaidBill();
            up.Update(
                    Id,
                    CategoryCode,
                    BillerTag,
                    Description,
                    FirstField,
                    FirstFieldFormat,
                    FirstFieldWidth,
                    SecondField,
                    SecondFieldFormat,
                    SecondFieldWidth,
                    ServiceCharge,
                    Date
                );

            
        }

        private void BillsPrefixAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.BillsPrefixes obj = (BillsPrefixes)Application.OpenForms["BillsPrefixes"];
            obj.loadGrid();
        }



    }
}
