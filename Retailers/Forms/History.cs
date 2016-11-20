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
    public partial class History : MetroForm
    {
        public DateTime DatePast
        {
            get { return this.metroDateTime_Past.Value; }
            set { this.metroDateTime_Past.Value = value; }
        }

        public DateTime DatePresent
        {
            get { return this.metroDateTime_Present.Value; }
            set { this.metroDateTime_Present.Value = value; }
        }

        public string Wallet
        {
            get { return Regex.Replace(this.maskedTextBox_Wallet_Id.Text, "-", ""); }
            set { this.maskedTextBox_Wallet_Id.Text = value; }
        }

        public History()
        {
            InitializeComponent();
        }

        private void LoadFund_Load(object sender, EventArgs e)
        {
            load_UnsuccessfullMessageGrid();
            metroDateTimePastBill.Value = metroDateTimePresentBill.Value = DatePast = DatePresent = DateTime.Now;
          
          
        }

        private void metroTextButton_Reload_Click(object sender, EventArgs e)
        {
            DatePast = DatePresent = DateTime.Now;
            load_historyGrid();
            
        }
         
        private void load_historyGrid()
        {

            Cursor.Current = Cursors.WaitCursor;
            BindingSource bindingsource = new BindingSource();

            List<Database.DBTransactions.DBPrepaidCableTransactions> rec = Database.DBTransactions.DBPrepaidCableTransactions.GetDataByWallet(Wallet, DatePast, DatePresent);
            foreach (Database.DBTransactions.DBPrepaidCableTransactions data in rec)

                bindingsource.Add(new Database.DBTransactions.DBPrepaidCableTransactions(
                data.Wallet_id,
                data.Code,
                data.Amount,
                data.Date,
                data.Discount,
                data.Customer_number
                ));

            this.dataGridView_PrepaidHistory.Refresh();
            this.dataGridView_PrepaidHistory.AutoGenerateColumns = false;
            this.dataGridView_PrepaidHistory.DataSource = bindingsource;
            this.dataGridView_PrepaidHistory.ClearSelection();

            Cursor.Current = Cursors.Default;
        }

        private void load_UnsuccessfullMessageGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            BindingSource bindingsource = new BindingSource();

            List<Database.DBMessages.DBOutbox> rec = Database.DBMessages.DBOutbox.GetUnsentMessagesByRecipeint(Wallet);
            foreach (Database.DBMessages.DBOutbox data in rec)

                bindingsource.Add(new Database.DBMessages.DBOutbox(
                data.ID,
                data.Date,
                data.Message,
                data.Sent
                ));

           
            this.dataGridViewUnsent.AutoGenerateColumns = false;
            this.dataGridViewUnsent.DataSource = bindingsource;
            this.dataGridViewUnsent.ClearSelection();

            Cursor.Current = Cursors.Default;
        }

        private void metroDateTime_Past_ValueChanged(object sender, EventArgs e)
        {

            load_historyGrid();
        }

        private void metroDateTime_Present_ValueChanged(object sender, EventArgs e)
        {

            load_historyGrid();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButtonResent_Click(object sender, EventArgs e)
        {
            //Database.DBMessages.DBOutbox send =Database.DBMessages.DBOutbox.ReSendMessage(Wallet);

            Database.DBMessages.DBOutbox send = new Database.DBMessages.DBOutbox();
            send.ReSendMessage(Wallet);
            load_UnsuccessfullMessageGrid();
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

            load_UnsuccessfullMessageGrid();
        }

        private void metroTabPage3_MouseClick(object sender, MouseEventArgs e)
        {
            load_UnsuccessfullMessageGrid();
        }

        private void metroTextButtonDelete_Click(object sender, EventArgs e)
        {

            try
            {
                string value = this.dataGridViewUnsent.SelectedCells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show(" Are You Sure ? ", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    Database.DBMessages.DBOutbox del = new Database.DBMessages.DBOutbox();
                    del.Delete(value);

                    load_UnsuccessfullMessageGrid();


                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void metroTextRefresh_Click(object sender, EventArgs e)
        {
            load_UnsuccessfullMessageGrid();
        }

        private void metroTextButtonRefresh_Click(object sender, EventArgs e)
        {
            load_historyGrid();
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButton1Fresh_Click(object sender, EventArgs e)
        {
            loadbillgrid();
        }

        private void loadbillgrid()
        {
            Cursor.Current = Cursors.WaitCursor;

            BindingSource bindingsource = new BindingSource();

            List<Database.DBTransactions.DBPostpaidBillTransaction> rec = Database.DBTransactions.DBPostpaidBillTransaction.GetDataByWalletStatus(Wallet,metroDateTimePastBill.Value, metroDateTimePresentBill.Value);
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

            this.dataGridViewBill.AutoGenerateColumns = false;
            this.dataGridViewBill.DataSource = bindingsource;

            Cursor.Current = Cursors.Default;
        }
 
    }
}
