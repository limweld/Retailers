using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Retailers
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void metroTile_Reciever_Click(object sender, EventArgs e)
        {
            Forms.ReceiverForm r = new Forms.ReceiverForm();
            r.Show();
        }

        private void metroTile_Sender_Click(object sender, EventArgs e)
        {
            Forms.SenderForm s = new Forms.SenderForm();
            s.Show();
        }

        private void metroTile_PrepaidCable_Click(object sender, EventArgs e)
        {
            Forms.PrepaidCableCards c = new Forms.PrepaidCableCards();
            c.Show();
        }

        private void metroTile_Retailers_Click(object sender, EventArgs e)
        {
            Forms.Retailers ret = new Forms.Retailers();
            ret.Show();
        }

        private void metroTileBillsPayment_Click(object sender, EventArgs e)
        {
            Forms.BillsPaymentTransaction bill = new Forms.BillsPaymentTransaction();
            bill.Show();
        }
    }
}
