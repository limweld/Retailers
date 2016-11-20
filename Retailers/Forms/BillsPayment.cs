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
    public partial class BillsPayment : MetroForm
    {
        Forms.BillsPaymentTransaction obj = (BillsPaymentTransaction)Application.OpenForms["BillsPaymentTransaction"];
      
        public string Wallet
        {
            get { return Regex.Replace(this.maskedTextBox_Wallet_Id.Text, "-", ""); }
            set { this.maskedTextBox_Wallet_Id.Text = value; }
        }

        public string TrackingNumber
        {
            get { return trackingNumber.Text; }
            set 
            {
                trackingNumber.Text = String.Format("{0:00000}", Convert.ToInt32(value)); 
            }
        }

        public string ConvFee
        {
            get { return metroTextBoxConvfee.Text; }
            set { metroTextBoxConvfee.Text = value; }
        }

        public string Total
        {
            get { return metroTextBoxTotal.Text; }
            set 
            {
                value = Convert.ToString(Convert.ToDouble(Amount) + Convert.ToDouble(ConvFee));
                metroTextBoxTotal.Text = value; 
            }
        }

        public string Parameter
        {
            get 
            {
                string para1 =metroTextBoxParameters.Text.ToUpper();
                string[] words = para1.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                
                return words[0];
            }
            set { metroTextBoxParameters.Text = value; }
        }

        public string BillsCode
        {
            get { return textBox_BillCode.Text; }
            set { textBox_BillCode.Text = value; }
        }

        public string Amount
        {
            get { return metroTextBoxAmount.Text; }
            set { metroTextBoxAmount.Text = value; }
        }


        public string Status
        {
            get { return comboBox_Status.Text; }
            set { comboBox_Status.PromptText = value; }
        }


        public string Customer_Fullname
        {
            get { return metroTextBoxCustomerFullname.Text; }
            set { metroTextBoxCustomerFullname.Text = value; }
        }

        public String Customer_Number
        {
            get { return Regex.Replace(maskedTextBoxCustomerNumber.Text, "-", ""); }
            set { maskedTextBoxCustomerNumber.Text = value; }
        }

        public DateTime DateTransact
        {
            get { return dateTimePicker_dateReg.Value; }
            set { dateTimePicker_dateReg.Value = value; }
        }

        public string WalletUser
        {
            get { return metroTextBoxWalletName.Text; }
            set { metroTextBoxWalletName.Text = value; }
        }

        public string CustomerMessage
        {
            get { return metroTextBoxCustomerMess.Text; }
            set { metroTextBoxCustomerMess.Text = value; }
        }

        public string WalletMessage
        {
            get { return metroTextBoxWalletMess.Text; }
            set { metroTextBoxWalletMess.Text = value; }
        }

        public string BoxBillerReciept
        {
            get { return metroTextBoxBillerReciept.Text; }
            set { metroTextBoxBillerReciept.Text = value;}
        }

        public BillsPayment()
        {
            InitializeComponent();
        }

        private void BillsPayment_Load(object sender, EventArgs e)
        {
            cmd_Save.Enabled = false;
        }

        private void metroTextBoxBillerReciept_TextChanged(object sender, EventArgs e)
        {
            WalletMessage = UpdatePaidWalletCustomerUserMessage();
            if(Customer_Number.ToString()!="")
                CustomerMessage = UpdatePaidWalletCustomerUserMessage();
            comboBox_Status.Text = "Paid"; 
        }

        private string UpdateUnsuccessfulCustomerMessage()
        {
            return ("Sorry your "+ BillsCode +" bill w/ acct#"+Parameter+ " is not successful. Pls contact A1+ dealer for refund." );
        }

        private string UpdateUnsuccessfulWalletUserMessage()
        {
            Database.DBRetailers rec = Database.DBRetailers.GetDataByWallet(Wallet);
            float refund = rec.Balance + (float)Convert.ToDouble(Total);
            return ("Sorry your " + BillsCode + "bill w/ acct#" + Parameter + " is not successful. " + Total + " is refunded to your wallet. Current bal "+Convert.ToString(refund)+" .");
        }

        private string UpdatePaidWalletCustomerUserMessage()
        {
            return ("Your " + BillsCode + " bill with acct#" + Parameter + " is already posted to the biller with ref#" + BoxBillerReciept + ". Pls keep your tracking#"+TrackingNumber+" as your reciept.");
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Status.SelectedIndex == 0)
            {
                CustomerMessage = WalletMessage = UpdatePaidWalletCustomerUserMessage();
               
                metroTextBoxBillerReciept.Enabled = true;
            }
            else if (comboBox_Status.SelectedIndex == 1)
            {
                BoxBillerReciept = "";
                metroTextBoxBillerReciept.Enabled = false;
                WalletMessage = UpdateUnsuccessfulWalletUserMessage();
                if (maskedTextBoxCustomerNumber.MaskCompleted)
                {
                    CustomerMessage = UpdateUnsuccessfulCustomerMessage();
                }
            }
        }

        public void ControlDisable()
        {
            cmd_Save.Enabled = metroTextBoxBillerReciept.Enabled = comboBox_Status.Enabled = false;
        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            if (input_Validity() == true)
            {
                Database.DBTransactions.DBPostpaidBillTransaction update = new Database.DBTransactions.DBPostpaidBillTransaction();
                update.Update(Convert.ToInt32(TrackingNumber), BoxBillerReciept, Status);


                Database.DBRetailers ret = Database.DBRetailers.GetDataByWallet(Wallet);

                if (comboBox_Status.Text == "Unsuccessful")
                {
                    float refund = (float)(Convert.ToDouble(Total)) + ret.Balance;

                    Database.DBRetailers upd = new Database.DBRetailers();
                    upd.UpdateBalance(Wallet, refund);

                    Class.Message add = new Class.Message();
                    add.AddtoOutBox(DateTime.Now, Wallet, WalletMessage, "Pending");
                
                    if (maskedTextBoxCustomerNumber.MaskCompleted)
                    {
                        add.AddtoOutBox(DateTime.Now, Customer_Number, CustomerMessage, "Pending");
                    }
                }
                if (comboBox_Status.Text == "Paid")
                {
                    Class.Message add = new Class.Message();
                    add.AddtoOutBox(DateTime.Now, Wallet, WalletMessage, "Pending");
                 
                    if (maskedTextBoxCustomerNumber.MaskCompleted)
                    {
                        add.AddtoOutBox(DateTime.Now, Customer_Number, CustomerMessage, "Pending");
                    }
                }

                ControlDisable();
            }

            this.Close();
        }

        private bool input_Validity()
        {
            if (BoxBillerReciept=="" && comboBox_Status.Text == "Paid")
            {
                MessageBox.Show("Bill Reciept Null !");
                return false;
            }

            return true;

        }

        private void BillsPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            obj.loadgrid();
        }

        private void comboBox_Status_Click(object sender, EventArgs e)
        {
            cmd_Save.Enabled = true;
        }

        private void metroTextBoxBillerReciept_Click(object sender, EventArgs e)
        {
            cmd_Save.Enabled = true;
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

  

        

    
    }
}
