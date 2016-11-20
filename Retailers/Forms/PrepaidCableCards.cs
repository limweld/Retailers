using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Threading;

namespace Retailers.Forms
{
    public partial class PrepaidCableCards : MetroForm
    {
        Thread thread = null;

        public DateTime DateRegister
        {
            get { return Convert.ToDateTime(this.dateTimePicker_dateReg.Value.ToShortDateString()); }
            set { this.dateTimePicker_dateReg.Value = value; }
        }

        public DateTime DateExpire
        {
            get { return Convert.ToDateTime(this.dateTimePicker_Expire.Value.ToShortDateString()); }
            set { this.dateTimePicker_Expire.Value = value; }
        }

        public string Pin
        {
            get { return textbox_Pin.Text; }
            set { this.textbox_Pin.Text = value; }
        }

        public string CableType
        {
            get { return this.comboBox_CableType.Text; }
            set { this.comboBox_CableType.Text = value; }
                
        }


        public string AmountType
        {
            get { return this.metroComboBox_TextAmount.Text; }
            set { this.metroComboBox_TextAmount.Text = value; }

        }



        //public int Amount
        //{
        //    get 
        //    {
        //        try
        //        {
        //            return Convert.ToInt32(this.textBox_Amount.Text);
        //        }
        //        catch (Exception ex)
        //        {
        //            ex.ToString();
        //            MessageBox.Show("Large Amount , Invalid !");
        //            return 0;
        //        }
                
        //    }
        //    set 
        //    {
        //        this.textBox_Amount.Text = Convert.ToString(value); 
        //    }
        //}

        public PrepaidCableCards()
        {
            InitializeComponent();
        }

        private void link_CodeSetting_Click(object sender, EventArgs e)
        {
            PrepaidCablePrefixes p = new PrepaidCablePrefixes();
            p.Show();
        }

        private void link_Transaction_Click(object sender, EventArgs e)
        {
            PrepaidCableTransactions pt = new PrepaidCableTransactions();
            pt.Show();
        }

        private void PrepaidCableCards_Load(object sender, EventArgs e)
        {
                load_dataGridView_PrepaidCards();
                loadcomboBox_CableType();
                buttonEnable(false);
                cmd_Add.Enabled = true; 
        }

     

        private void loadcomboBox_CableType()
        {
            List<Database.DBPrepaidCable.DBPrepaidCable> obj;

            obj = Database.DBPrepaidCable.DBPrepaidCable.GetData();
            comboBox_CableType.Items.Clear();


            foreach (Database.DBPrepaidCable.DBPrepaidCable rec in obj)
            {
                comboBox_CableType.Items.Add(rec.Code);
            }
        }

        public void load_dataGridView_PrepaidCards()
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                BindingSource bindingsource = new BindingSource();

                List<Database.DBPrepaidCable.DBPrepaidCards> rec = Database.DBPrepaidCable.DBPrepaidCards.GetData();
                foreach (Database.DBPrepaidCable.DBPrepaidCards data in rec)

                    bindingsource.Add(new Database.DBPrepaidCable.DBPrepaidCards(
                    data.Id,
                    data.CableType,
                    data.Amount,
                    data.Pin,
                    data.Status,
                    data.Date_Registered,
                    data.Date_Expired
                    ));

                this.dataGridView_PrepaidCards.Refresh();
                this.dataGridView_PrepaidCards.AutoGenerateColumns = false;
                this.dataGridView_PrepaidCards.DataSource = bindingsource;
                this.dataGridView_PrepaidCards.ClearSelection();

                Cursor.Current = Cursors.Default;
            }
            catch(Exception ex){
                ex.ToString();
            }
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
            if (input_validity() == true)
            {
                buttonEnable(false);

                try
                {
                   
                    Database.DBPrepaidCable.DBPrepaidCards add = new Database.DBPrepaidCable.DBPrepaidCards();
                    add.Add(CableType, Convert.ToInt32(AmountType), Pin, "Available", DateRegister, DateExpire);

                    load_dataGridView_PrepaidCards();
                }catch(Exception ex){
                   MessageBox.Show( ex.ToString());

                }
                    
                    cmd_Add.Enabled = cmd_Cancel.Enabled = true;
                    input_Clear();
                
            }
        }

        private void cmd_Delete_Click(object sender, EventArgs e)
        {
             DialogResult dialogResult = MessageBox.Show(" Are You Sure ? ", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
             if (dialogResult == DialogResult.Yes)
             {

                 try
                 {
                     Database.DBPrepaidCable.DBPrepaidCards del = new Database.DBPrepaidCable.DBPrepaidCards();
                     del.Delete(this.dataGridView_PrepaidCards.SelectedCells[0].Value.ToString());

                     load_dataGridView_PrepaidCards();
                 }
                 catch (Exception ex)
                 {
                     ex.ToString();
                 }


                 buttonEnable(false);
                 cmd_Delete.Enabled = false;
                 cmd_Add.Enabled = true;
                 input_Clear();
             }
        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            if (input_validity() == true)
            {
                Database.DBPrepaidCable.DBPrepaidCards update = new Database.DBPrepaidCable.DBPrepaidCards();

                update.Update(dataGridView_PrepaidCards.SelectedCells[0].Value.ToString(), CableType, Convert.ToInt32(AmountType), Pin, "Available", DateRegister, DateExpire);
                
                load_dataGridView_PrepaidCards();

                buttonEnable(false);
                cmd_Edit.Enabled = true;
            }
        }

        private void cmd_Edit_Click(object sender, EventArgs e)
        {
            input_Enable(true);
            buttonEnable(false);
            cmd_Delete.Enabled = cmd_Save.Enabled = true;
        }

        private void cmd_Cancel_Click(object sender, EventArgs e)
        {
            buttonEnable(false);
            cmd_Add.Enabled = true;
            input_Clear();
            input_Enable(true);
        }

        private void buttonEnable(bool enable)
        {
            this.cmd_Add.Enabled = this.cmd_Delete.Enabled =
            this.cmd_Save.Enabled = this.cmd_Edit.Enabled =
            enable;
        }

        private void dataGridView_PrepaidCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            input_Enable(false);

           
            try
            {
                int index = e.RowIndex;
                if (index > -1)
                {

                    DataGridViewRow selectedRow = dataGridView_PrepaidCards.Rows[index];
                    CableType = selectedRow.Cells[1].Value.ToString();
                    AmountType = selectedRow.Cells[2].Value.ToString();
                    Pin = selectedRow.Cells[3].Value.ToString();
                    DateRegister = Convert.ToDateTime(selectedRow.Cells[5].Value.ToString());
                    DateExpire = Convert.ToDateTime(selectedRow.Cells[6].Value.ToString());
                }
                
            }
            catch (ArgumentException  ex)
            {
                ex.ToString();
            }

            buttonEnable(false);
            cmd_Edit.Enabled = true;
        }

        private void input_Enable(bool enable)
        {
            this.comboBox_CableType.Enabled =
            this.metroComboBox_TextAmount.Enabled =
            this.textbox_Pin.Enabled =
            this.dateTimePicker_dateReg.Enabled =
            this.dateTimePicker_Expire.Enabled = enable;    
        }

        private void input_Clear()
        {
            Pin = "";
            this.metroComboBox_TextAmount.SelectedIndex =
            this.comboBox_CableType.SelectedIndex = -1;
          
            DateRegister = DateExpire = DateTime.Now;
            
        }

        private bool input_validity()
        {
            if (Pin=="" || AmountType=="" || CableType == "")
            {

                MessageBox.Show("Incomplete Fields !");
                return false;
            }
            return true;
        }

        private void metroButton_Reload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            BindingSource bindingsource = new BindingSource();

            List<Database.DBPrepaidCable.DBPrepaidCardslog> rec = Database.DBPrepaidCable.DBPrepaidCardslog.GetData();
            foreach (Database.DBPrepaidCable.DBPrepaidCardslog data in rec)

            bindingsource.Add(new Database.DBPrepaidCable.DBPrepaidCardslog(        
            data.Id,
            data.CableType,
            data.Amount,
            data.Pin,
            data.Status,
            data.Date_Used
            ));

            this.dataGridView_PrepaidCardsLogs.AutoGenerateColumns = false;
            this.dataGridView_PrepaidCardsLogs.DataSource = bindingsource;

            Cursor.Current = Cursors.Default;
               
          }

        private void dataGridView_PrepaidCardsLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton_refresh_Click(object sender, EventArgs e)
        {
            load_dataGridView_PrepaidCards();
        }

 

        private void PrepaidCableCards_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread != null && thread.IsAlive)
            {
                thread.Abort();
            }
        }

        private void metroDateTime_Present_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroDateTime_Past_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmd_Reload_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_CableType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Database.DBPrepaidCable.DBPrepaidCableAmount> obj;

            obj = Database.DBPrepaidCable.DBPrepaidCableAmount.GetDataType(comboBox_CableType.Text);
            this.metroComboBox_TextAmount.Items.Clear();


            foreach (Database.DBPrepaidCable.DBPrepaidCableAmount rec in obj)
            {
                this.metroComboBox_TextAmount.Items.Add(rec.Amount);
            }
        }

      
    }
}
