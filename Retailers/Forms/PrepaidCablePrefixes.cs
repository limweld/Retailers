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
    public partial class PrepaidCablePrefixes : MetroForm
    {
        public string Code
        {
            get { return metroTextBox_Code.Text; }
            set { metroTextBox_Code.Text = value; }
        }

        public string Description
        {
            get { return metroTextBox_Description.Text; }
            set { metroTextBox_Description.Text = value; }
        }

        public string GateWay
        {
            get { return metroTextBox_Gateway.Text; }
            set { metroTextBox_Gateway.Text = value; }
        }

        public PrepaidCablePrefixes()
        {
            InitializeComponent();
            
        }

        private void PrepaidCableCode_Load(object sender, EventArgs e)
        {
            load_dataGridView_PrepaidCable();
            loadcomboBox_CableType();
            load_dataGridView_PrepaidAmount();
            buttonEnable(false);
            inputEnable(false);
        }

        public void load_dataGridView_PrepaidCable()
        {
            Cursor.Current = Cursors.WaitCursor;

            BindingSource bindingsource = new BindingSource();

            List<Database.DBPrepaidCable.DBPrepaidCable> rec = Database.DBPrepaidCable.DBPrepaidCable.GetData();
            foreach (Database.DBPrepaidCable.DBPrepaidCable data in rec)

                bindingsource.Add(new Database.DBPrepaidCable.DBPrepaidCable(
                    data.Id,
                    data.Code,
                    data.Description,
                    data.Gateway
                ));

            this.dataGridView_PrepaidCable.AutoGenerateColumns = false;
            this.dataGridView_PrepaidCable.DataSource = bindingsource;

            Cursor.Current = Cursors.Default;
        }

        private void loadcomboBox_CableType()
        {
            List<Database.DBPrepaidCable.DBPrepaidCable> obj;

            obj = Database.DBPrepaidCable.DBPrepaidCable.GetData();
            comboBox_CableType.Items.Clear();


            foreach (Database.DBPrepaidCable.DBPrepaidCable rec in obj)
            {
                comboBox_CableType.Items.Add(rec.Code);
                metroComboBox_SerchType.Items.Add(rec.Code);
            }
        }
      
        private void cmd_Add_Click(object sender, EventArgs e)
        {
            Database.DBPrepaidCable.DBPrepaidCableAmount add = new Database.DBPrepaidCable.DBPrepaidCableAmount();
            add.Add(comboBox_CableType.Text,Convert.ToInt32(textbox_Amount.Text));
            
            this.metroComboBox_SerchType.SelectedIndex = -1;
            load_dataGridView_PrepaidAmount();

      
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            Database.DBPrepaidCable.DBPrepaidCableAmount del = new Database.DBPrepaidCable.DBPrepaidCableAmount();
            del.Delete(this.dataGridView_PreapaidAmount.SelectedCells[0].Value.ToString());
            load_dataGridView_PrepaidAmount();

            this.comboBox_CableType.SelectedIndex = -1;
            this.textbox_Amount.Text = "";
        }

        private void cmd_clear_Click(object sender, EventArgs e)
        {
            comboBox_CableType.SelectedIndex = -1;
            textbox_Amount.Text = "";
      
        }

        private void load_dataGridView_PrepaidAmount()
        {
            Cursor.Current = Cursors.WaitCursor;

            BindingSource bindingsource = new BindingSource();

            List<Database.DBPrepaidCable.DBPrepaidCableAmount> rec = Database.DBPrepaidCable.DBPrepaidCableAmount.GetData();
            foreach (Database.DBPrepaidCable.DBPrepaidCableAmount data in rec)

                bindingsource.Add(new Database.DBPrepaidCable.DBPrepaidCableAmount(
                    data.Id,
                    data.Type,
                    data.Amount
                ));

            this.dataGridView_PreapaidAmount.AutoGenerateColumns = false;
            this.dataGridView_PreapaidAmount.DataSource = bindingsource;

            Cursor.Current = Cursors.Default;
        }

        private void load_dataGridView_PrepaidAmountType(string type)
        {
            Cursor.Current = Cursors.WaitCursor;

            BindingSource bindingsource = new BindingSource();

            List<Database.DBPrepaidCable.DBPrepaidCableAmount> rec = Database.DBPrepaidCable.DBPrepaidCableAmount.GetDataType(type);
            foreach (Database.DBPrepaidCable.DBPrepaidCableAmount data in rec)

                bindingsource.Add(new Database.DBPrepaidCable.DBPrepaidCableAmount(
                    data.Id,
                    data.Type,
                    data.Amount
                ));

            this.dataGridView_PreapaidAmount.AutoGenerateColumns = false;
            this.dataGridView_PreapaidAmount.DataSource = bindingsource;

            Cursor.Current = Cursors.Default;
        }

        private void metroComboBox_SerchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_dataGridView_PrepaidAmountType(this.metroComboBox_SerchType.Text);
        }

        private void cmd_codeAdd_Click(object sender, EventArgs e)
        {
            Database.DBPrepaidCable.DBPrepaidCable add = new Database.DBPrepaidCable.DBPrepaidCable();
            add.Add(Code,Description,GateWay);
            
            load_dataGridView_PrepaidCable();
            prefixClear();
        }

        private void cmd_codeDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(" Are You Sure ? ", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                Database.DBPrepaidCable.DBPrepaidCable del = new Database.DBPrepaidCable.DBPrepaidCable();
                del.Delete(this.dataGridView_PrepaidCable.SelectedCells[0].Value.ToString());
                load_dataGridView_PrepaidCable();
                buttonEnable(false);
                cmd_codeAdd.Enabled = true;
                prefixClear();
            }
        }

        private void cmd_codeSave_Click(object sender, EventArgs e)
        {
            buttonEnable(false);
            cmd_codeEdit.Enabled = true;
            inputEnable(false);
            Database.DBPrepaidCable.DBPrepaidCable upd = new Database.DBPrepaidCable.DBPrepaidCable();
            upd.Update( this.dataGridView_PrepaidCable.SelectedCells[0].Value.ToString(),Code,Description,GateWay);
           
            load_dataGridView_PrepaidCable();
            prefixClear();
        }

        private void cmd_codeEdit_Click(object sender, EventArgs e)
        {
            buttonEnable(false);
            inputEnable(true);
            cmd_codeDelete.Enabled = cmd_codeSave.Enabled = true;
        }

        private void cmd_codeClear_Click(object sender, EventArgs e)
        {
            prefixClear();
            buttonEnable(false);
            cmd_codeAdd.Enabled = true;
            inputEnable(true);
        }

        private void buttonEnable(bool enable)
        {
            cmd_codeAdd.Enabled = cmd_codeDelete.Enabled = cmd_codeSave.Enabled = cmd_codeEdit.Enabled  = enable;
        }

        private void inputEnable(bool enable)
        {
            metroTextBox_Code.Enabled = metroTextBox_Description.Enabled = metroTextBox_Gateway.Enabled = enable;
        }

        private void prefixClear()
        {
            this.dataGridView_PrepaidCable.ClearSelection();
            Code = Description = GateWay = "";
        }

        private void dataGridView_PrepaidCable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Code = this.dataGridView_PrepaidCable.SelectedCells[1].Value.ToString();
            Description = this.dataGridView_PrepaidCable.SelectedCells[2].Value.ToString();
            GateWay = this.dataGridView_PrepaidCable.SelectedCells[3].Value.ToString();
            inputEnable(false);
            buttonEnable(false);
            cmd_codeEdit.Enabled = true;
        }


    }
}
