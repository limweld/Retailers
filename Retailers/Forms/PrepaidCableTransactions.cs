using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace Retailers.Forms
{
    public partial class PrepaidCableTransactions : MetroForm
    {
        public PrepaidCableTransactions()
        {
            InitializeComponent();
        }

        private void PrepaidCableTransactions_Load(object sender, EventArgs e)
        {
            this.metroDateTime_Past.Value = this.metroDateTime_Present.Value = DateTime.Now;
        }

        private void cmd_Reload_Click(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void loadgrid()
        {
            Cursor.Current = Cursors.WaitCursor;

            BindingSource bindingsource = new BindingSource();

            List<Database.DBTransactions.DBPrepaidCableTransactions> rec = Database.DBTransactions.DBPrepaidCableTransactions.GetDataByDate(metroDateTime_Past.Value,metroDateTime_Present.Value);
            foreach (Database.DBTransactions.DBPrepaidCableTransactions data in rec)

                bindingsource.Add(new Database.DBTransactions.DBPrepaidCableTransactions(
                data.Id,
                data.Wallet_id,
                data.Code,
                data.Box_number,
                data.Amount,
                data.Pin,
                data.Date,
                data.Status,
                data.Discount,
                data.Customer_number
                ));

            this.dataGridView_PCTransac.AutoGenerateColumns = false;
            this.dataGridView_PCTransac.DataSource = bindingsource;

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
    }
}
