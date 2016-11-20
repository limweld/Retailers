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
    public partial class BillsPrefixes : MetroForm
    {
        public BillsPrefixes()
        {
            InitializeComponent();
        }

        private void BillsPrefix_Load(object sender, EventArgs e)
        {

        }

        private void cmd_Reload_Click(object sender, EventArgs e)
        {
            loadGrid();
            this.metroTextBoxBillerTag.Text = "";
        }

        public void loadGrid()
        {
            Cursor.Current = Cursors.WaitCursor;

            BindingSource bindingsource = new BindingSource();

            List<Database.DBPostpaidBill.DBPostpaidBill> rec = Database.DBPostpaidBill.DBPostpaidBill.GetData();
            foreach (Database.DBPostpaidBill.DBPostpaidBill data in rec)

                bindingsource.Add(new Database.DBPostpaidBill.DBPostpaidBill(
                data.Id,
                data.Categorycode,
                data.BillerTag,
                data.Description,
                data.FirstField,
                data.FirstFieldFormat,
                data.FirstFieldWidth,
                data.SecondField,
                data.SecondFieldFormat,
                data.SecondFieldWidth,
                data.ServiceCharge,
                data.Lastupdated
                ));

            this.dataGridView_BillsPrefix.AutoGenerateColumns = false;
            this.dataGridView_BillsPrefix.DataSource = bindingsource;

            Cursor.Current = Cursors.Default;
        }

        private void metroTextBoxBillerTag_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            BindingSource bindingsource = new BindingSource();

            List<Database.DBPostpaidBill.DBPostpaidBill> rec = Database.DBPostpaidBill.DBPostpaidBill.GetDataBillerTag(metroTextBoxBillerTag.Text);
            foreach (Database.DBPostpaidBill.DBPostpaidBill data in rec)

                bindingsource.Add(new Database.DBPostpaidBill.DBPostpaidBill(
                data.Id,
                data.Categorycode,
                data.BillerTag,
                data.Description,
                data.FirstField,
                data.FirstFieldFormat,
                data.FirstFieldWidth,
                data.SecondField,
                data.SecondFieldFormat,
                data.SecondFieldWidth,
                data.ServiceCharge,
                data.Lastupdated
                ));

            this.dataGridView_BillsPrefix.AutoGenerateColumns = false;
            this.dataGridView_BillsPrefix.DataSource = bindingsource;

            Cursor.Current = Cursors.Default;
        }

        private void metroTextBoxBillerTag_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_BillsPrefix_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Forms.BillsPrefixAdd view = new Forms.BillsPrefixAdd();
            view.Show();

            view.Id = this.dataGridView_BillsPrefix.SelectedCells[0].Value.ToString();
            view.CategoryCode = Convert.ToInt32(this.dataGridView_BillsPrefix.SelectedCells[1].Value.ToString());
            view.BillerTag = this.dataGridView_BillsPrefix.SelectedCells[2].Value.ToString();
            view.Description = this.dataGridView_BillsPrefix.SelectedCells[3].Value.ToString();
            view.FirstField = this.dataGridView_BillsPrefix.SelectedCells[4].Value.ToString();
            view.FirstFieldFormat = this.dataGridView_BillsPrefix.SelectedCells[5].Value.ToString();
            view.FirstFieldWidth = this.dataGridView_BillsPrefix.SelectedCells[6].Value.ToString();
            view.SecondField = this.dataGridView_BillsPrefix.SelectedCells[7].Value.ToString();
            view.SecondFieldFormat = this.dataGridView_BillsPrefix.SelectedCells[8].Value.ToString();
            view.SecondFieldWidth = this.dataGridView_BillsPrefix.SelectedCells[9].Value.ToString();
            view.ServiceCharge = this.dataGridView_BillsPrefix.SelectedCells[10].Value.ToString(); 
            view.Date = Convert.ToDateTime(this.dataGridView_BillsPrefix.SelectedCells[11].Value.ToString());

            view.group1Visibility(false);
        }

        private void cmd_AddPrefix_Click(object sender, EventArgs e)
        {
            Forms.BillsPrefixAdd addf = new Forms.BillsPrefixAdd();
            addf.Show();
            addf.group2Visibility(false);
        }
    }
}
