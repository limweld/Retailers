using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Retailers.Forms
{
    public partial class BillsPaymentTransaction : MetroForm
    {
        public BillsPaymentTransaction()
        {
            InitializeComponent();
        }

        private void cmd_Reload_Click(object sender, EventArgs e)
        {
            loadgrid();
            metroDateTime_Past.Value = metroDateTime_Present.Value = DateTime.Now;
        }


        public void loadgrid()
        {
            Cursor.Current = Cursors.WaitCursor;

            BindingSource bindingsource = new BindingSource();

            List<Database.DBTransactions.DBPostpaidBillTransaction> rec = Database.DBTransactions.DBPostpaidBillTransaction.GetDataByDate(metroDateTime_Past.Value, metroDateTime_Present.Value);
            foreach (Database.DBTransactions.DBPostpaidBillTransaction data in rec)

                bindingsource.Add(new Database.DBTransactions.DBPostpaidBillTransaction(
                    data.Id,
                    data.Date,
                    data.BillsCode,
                    data.Parameter1,
                    data.Parameter2,
                    data.Amount,
                    data.Wallet_Id,
                    data.Status,
                    data.Ecpaytrackingno,
                    data.Customer_Fullname,
                    data.Convenience_fee,
                    data.Total,
                    data.Customer_Number
                ));

            this.dataGridView_BillsPaymentTransac.AutoGenerateColumns = false;
            this.dataGridView_BillsPaymentTransac.DataSource = bindingsource;

            Cursor.Current = Cursors.Default;
        }

        private void metroDateTime_Past_ValueChanged(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void metroDateTime_Present_ValueChanged(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void dataGridView_BillsPaymentTransac_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Database.DBRetailers rec = Database.DBRetailers.GetDataByWallet(this.dataGridView_BillsPaymentTransac.SelectedCells[1].Value.ToString());

            Forms.BillsPayment bill = new Forms.BillsPayment();
            bill.Show();
            bill.TrackingNumber = this.dataGridView_BillsPaymentTransac.SelectedCells[0].Value.ToString(); 
            bill.Wallet = this.dataGridView_BillsPaymentTransac.SelectedCells[1].Value.ToString();
            bill.BillsCode = this.dataGridView_BillsPaymentTransac.SelectedCells[2].Value.ToString();
            bill.Parameter = this.dataGridView_BillsPaymentTransac.SelectedCells[3].Value.ToString() + "/" + this.dataGridView_BillsPaymentTransac.SelectedCells[4].Value.ToString();
            bill.Amount = this.dataGridView_BillsPaymentTransac.SelectedCells[5].Value.ToString();
            bill.ConvFee = this.dataGridView_BillsPaymentTransac.SelectedCells[6].Value.ToString();
            bill.Customer_Fullname = this.dataGridView_BillsPaymentTransac.SelectedCells[8].Value.ToString();
            bill.Customer_Number =  this.dataGridView_BillsPaymentTransac.SelectedCells[10].Value.ToString();
            bill.DateTransact = Convert.ToDateTime(this.dataGridView_BillsPaymentTransac.SelectedCells[9].Value.ToString());
            bill.WalletUser = rec.Fname + " " + rec.Lname;
            bill.Total = this.dataGridView_BillsPaymentTransac.SelectedCells[5].Value.ToString() + this.dataGridView_BillsPaymentTransac.SelectedCells[6].Value.ToString();
            bill.Status = this.dataGridView_BillsPaymentTransac.SelectedCells[11].Value.ToString();
            bill.BoxBillerReciept = this.dataGridView_BillsPaymentTransac.SelectedCells[7].Value.ToString();

            if (this.dataGridView_BillsPaymentTransac.SelectedCells[11].Value.ToString() == "Paid" || this.dataGridView_BillsPaymentTransac.SelectedCells[11].Value.ToString() == "Unsuccessful")
            bill.ControlDisable();
            
        }

        private void BillsPaymentTransaction_Load(object sender, EventArgs e)
        {
            metroDateTime_Past.Value = metroDateTime_Present.Value = DateTime.Now;
        }


        private void link_CodeSetting_Click(object sender, EventArgs e)
        {
            Forms.BillsPrefixes form = new Forms.BillsPrefixes();
            form.ShowDialog();
        }

  
    }
}
