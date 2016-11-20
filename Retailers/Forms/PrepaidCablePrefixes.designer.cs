namespace Retailers.Forms
{
    partial class PrepaidCablePrefixes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.cmd_codeSave = new MetroFramework.Controls.MetroButton();
            this.cmd_codeEdit = new MetroFramework.Controls.MetroButton();
            this.cmd_codeClear = new MetroFramework.Controls.MetroButton();
            this.cmd_codeDelete = new MetroFramework.Controls.MetroButton();
            this.cmd_codeAdd = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_Gateway = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Code = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView_PrepaidCable = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox_SerchType = new MetroFramework.Controls.MetroComboBox();
            this.cmd_clear = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmd_delete = new MetroFramework.Controls.MetroButton();
            this.cmd_Add = new MetroFramework.Controls.MetroButton();
            this.comboBox_CableType = new MetroFramework.Controls.MetroComboBox();
            this.textbox_Amount = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView_PreapaidAmount = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTextBox_Description = new MetroFramework.Controls.MetroTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrepaidCable)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PreapaidAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Controls.Add(this.metroTabPage2);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(360, 383);
            this.metroTabControl.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl.TabIndex = 2;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTextBox_Description);
            this.metroTabPage1.Controls.Add(this.cmd_codeSave);
            this.metroTabPage1.Controls.Add(this.cmd_codeEdit);
            this.metroTabPage1.Controls.Add(this.cmd_codeClear);
            this.metroTabPage1.Controls.Add(this.cmd_codeDelete);
            this.metroTabPage1.Controls.Add(this.cmd_codeAdd);
            this.metroTabPage1.Controls.Add(this.metroTextBox_Gateway);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroTextBox_Code);
            this.metroTabPage1.Controls.Add(this.dataGridView_PrepaidCable);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(352, 341);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Prefix";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // cmd_codeSave
            // 
            this.cmd_codeSave.Location = new System.Drawing.Point(119, 310);
            this.cmd_codeSave.Name = "cmd_codeSave";
            this.cmd_codeSave.Size = new System.Drawing.Size(52, 25);
            this.cmd_codeSave.TabIndex = 73;
            this.cmd_codeSave.Text = "SAVE";
            this.cmd_codeSave.UseSelectable = true;
            this.cmd_codeSave.Click += new System.EventHandler(this.cmd_codeSave_Click);
            // 
            // cmd_codeEdit
            // 
            this.cmd_codeEdit.Location = new System.Drawing.Point(239, 310);
            this.cmd_codeEdit.Name = "cmd_codeEdit";
            this.cmd_codeEdit.Size = new System.Drawing.Size(52, 25);
            this.cmd_codeEdit.TabIndex = 72;
            this.cmd_codeEdit.Text = "EDIT";
            this.cmd_codeEdit.UseSelectable = true;
            this.cmd_codeEdit.Click += new System.EventHandler(this.cmd_codeEdit_Click);
            // 
            // cmd_codeClear
            // 
            this.cmd_codeClear.Location = new System.Drawing.Point(297, 310);
            this.cmd_codeClear.Name = "cmd_codeClear";
            this.cmd_codeClear.Size = new System.Drawing.Size(52, 25);
            this.cmd_codeClear.TabIndex = 71;
            this.cmd_codeClear.Text = "CLEAR";
            this.cmd_codeClear.UseSelectable = true;
            this.cmd_codeClear.Click += new System.EventHandler(this.cmd_codeClear_Click);
            // 
            // cmd_codeDelete
            // 
            this.cmd_codeDelete.Location = new System.Drawing.Point(58, 310);
            this.cmd_codeDelete.Name = "cmd_codeDelete";
            this.cmd_codeDelete.Size = new System.Drawing.Size(52, 25);
            this.cmd_codeDelete.TabIndex = 70;
            this.cmd_codeDelete.Text = "DELETE";
            this.cmd_codeDelete.UseSelectable = true;
            this.cmd_codeDelete.Click += new System.EventHandler(this.cmd_codeDelete_Click);
            // 
            // cmd_codeAdd
            // 
            this.cmd_codeAdd.Location = new System.Drawing.Point(0, 310);
            this.cmd_codeAdd.Name = "cmd_codeAdd";
            this.cmd_codeAdd.Size = new System.Drawing.Size(52, 25);
            this.cmd_codeAdd.TabIndex = 69;
            this.cmd_codeAdd.Text = "ADD";
            this.cmd_codeAdd.UseSelectable = true;
            this.cmd_codeAdd.Click += new System.EventHandler(this.cmd_codeAdd_Click);
            // 
            // metroTextBox_Gateway
            // 
            // 
            // 
            // 
            this.metroTextBox_Gateway.CustomButton.Image = null;
            this.metroTextBox_Gateway.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.metroTextBox_Gateway.CustomButton.Name = "";
            this.metroTextBox_Gateway.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.metroTextBox_Gateway.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Gateway.CustomButton.TabIndex = 1;
            this.metroTextBox_Gateway.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Gateway.CustomButton.UseSelectable = true;
            this.metroTextBox_Gateway.CustomButton.Visible = false;
            this.metroTextBox_Gateway.Lines = new string[0];
            this.metroTextBox_Gateway.Location = new System.Drawing.Point(130, 209);
            this.metroTextBox_Gateway.MaxLength = 32767;
            this.metroTextBox_Gateway.Multiline = true;
            this.metroTextBox_Gateway.Name = "metroTextBox_Gateway";
            this.metroTextBox_Gateway.PasswordChar = '\0';
            this.metroTextBox_Gateway.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Gateway.SelectedText = "";
            this.metroTextBox_Gateway.SelectionLength = 0;
            this.metroTextBox_Gateway.SelectionStart = 0;
            this.metroTextBox_Gateway.ShortcutsEnabled = true;
            this.metroTextBox_Gateway.Size = new System.Drawing.Size(222, 83);
            this.metroTextBox_Gateway.TabIndex = 68;
            this.metroTextBox_Gateway.UseSelectable = true;
            this.metroTextBox_Gateway.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Gateway.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(0, 209);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 67;
            this.metroLabel6.Text = "Gateway :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 183);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(81, 19);
            this.metroLabel5.TabIndex = 66;
            this.metroLabel5.Text = "Description :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 158);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 65;
            this.metroLabel4.Text = "Code :";
            // 
            // metroTextBox_Code
            // 
            // 
            // 
            // 
            this.metroTextBox_Code.CustomButton.Image = null;
            this.metroTextBox_Code.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.metroTextBox_Code.CustomButton.Name = "";
            this.metroTextBox_Code.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBox_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Code.CustomButton.TabIndex = 1;
            this.metroTextBox_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Code.CustomButton.UseSelectable = true;
            this.metroTextBox_Code.CustomButton.Visible = false;
            this.metroTextBox_Code.Lines = new string[0];
            this.metroTextBox_Code.Location = new System.Drawing.Point(131, 157);
            this.metroTextBox_Code.MaxLength = 32767;
            this.metroTextBox_Code.Name = "metroTextBox_Code";
            this.metroTextBox_Code.PasswordChar = '\0';
            this.metroTextBox_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Code.SelectedText = "";
            this.metroTextBox_Code.SelectionLength = 0;
            this.metroTextBox_Code.SelectionStart = 0;
            this.metroTextBox_Code.ShortcutsEnabled = true;
            this.metroTextBox_Code.Size = new System.Drawing.Size(222, 20);
            this.metroTextBox_Code.TabIndex = 61;
            this.metroTextBox_Code.UseSelectable = true;
            this.metroTextBox_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView_PrepaidCable
            // 
            this.dataGridView_PrepaidCable.AllowUserToAddRows = false;
            this.dataGridView_PrepaidCable.AllowUserToDeleteRows = false;
            this.dataGridView_PrepaidCable.AllowUserToResizeColumns = false;
            this.dataGridView_PrepaidCable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Thistle;
            this.dataGridView_PrepaidCable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_PrepaidCable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PrepaidCable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6});
            this.dataGridView_PrepaidCable.Location = new System.Drawing.Point(-1, 4);
            this.dataGridView_PrepaidCable.Name = "dataGridView_PrepaidCable";
            this.dataGridView_PrepaidCable.ReadOnly = true;
            this.dataGridView_PrepaidCable.RowHeadersVisible = false;
            this.dataGridView_PrepaidCable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_PrepaidCable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PrepaidCable.Size = new System.Drawing.Size(353, 147);
            this.dataGridView_PrepaidCable.TabIndex = 41;
            this.dataGridView_PrepaidCable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PrepaidCable_CellClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroComboBox_SerchType);
            this.metroTabPage2.Controls.Add(this.cmd_clear);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.cmd_delete);
            this.metroTabPage2.Controls.Add(this.cmd_Add);
            this.metroTabPage2.Controls.Add(this.comboBox_CableType);
            this.metroTabPage2.Controls.Add(this.textbox_Amount);
            this.metroTabPage2.Controls.Add(this.dataGridView_PreapaidAmount);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(352, 341);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Amount";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(150, 11);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 67;
            this.metroLabel3.Text = "Search Type :";
            // 
            // metroComboBox_SerchType
            // 
            this.metroComboBox_SerchType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox_SerchType.FormattingEnabled = true;
            this.metroComboBox_SerchType.ItemHeight = 19;
            this.metroComboBox_SerchType.Location = new System.Drawing.Point(242, 5);
            this.metroComboBox_SerchType.Name = "metroComboBox_SerchType";
            this.metroComboBox_SerchType.Size = new System.Drawing.Size(107, 25);
            this.metroComboBox_SerchType.TabIndex = 66;
            this.metroComboBox_SerchType.UseSelectable = true;
            this.metroComboBox_SerchType.SelectedIndexChanged += new System.EventHandler(this.metroComboBox_SerchType_SelectedIndexChanged);
            // 
            // cmd_clear
            // 
            this.cmd_clear.Location = new System.Drawing.Point(297, 313);
            this.cmd_clear.Name = "cmd_clear";
            this.cmd_clear.Size = new System.Drawing.Size(52, 25);
            this.cmd_clear.TabIndex = 65;
            this.cmd_clear.Text = "CLEAR";
            this.cmd_clear.UseSelectable = true;
            this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 287);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 64;
            this.metroLabel1.Text = "Amount :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 255);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 63;
            this.metroLabel2.Text = "Cable Type :";
            // 
            // cmd_delete
            // 
            this.cmd_delete.Location = new System.Drawing.Point(69, 313);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(52, 25);
            this.cmd_delete.TabIndex = 62;
            this.cmd_delete.Text = "DELETE";
            this.cmd_delete.UseSelectable = true;
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmd_Add
            // 
            this.cmd_Add.Location = new System.Drawing.Point(11, 313);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(52, 25);
            this.cmd_Add.TabIndex = 61;
            this.cmd_Add.Text = "ADD";
            this.cmd_Add.UseSelectable = true;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // comboBox_CableType
            // 
            this.comboBox_CableType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBox_CableType.FormattingEnabled = true;
            this.comboBox_CableType.ItemHeight = 19;
            this.comboBox_CableType.Location = new System.Drawing.Point(127, 249);
            this.comboBox_CableType.Name = "comboBox_CableType";
            this.comboBox_CableType.Size = new System.Drawing.Size(222, 25);
            this.comboBox_CableType.TabIndex = 60;
            this.comboBox_CableType.UseSelectable = true;
            // 
            // textbox_Amount
            // 
            // 
            // 
            // 
            this.textbox_Amount.CustomButton.Image = null;
            this.textbox_Amount.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.textbox_Amount.CustomButton.Name = "";
            this.textbox_Amount.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textbox_Amount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_Amount.CustomButton.TabIndex = 1;
            this.textbox_Amount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_Amount.CustomButton.UseSelectable = true;
            this.textbox_Amount.CustomButton.Visible = false;
            this.textbox_Amount.Lines = new string[0];
            this.textbox_Amount.Location = new System.Drawing.Point(127, 282);
            this.textbox_Amount.MaxLength = 32767;
            this.textbox_Amount.Name = "textbox_Amount";
            this.textbox_Amount.PasswordChar = '\0';
            this.textbox_Amount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_Amount.SelectedText = "";
            this.textbox_Amount.SelectionLength = 0;
            this.textbox_Amount.SelectionStart = 0;
            this.textbox_Amount.ShortcutsEnabled = true;
            this.textbox_Amount.Size = new System.Drawing.Size(222, 20);
            this.textbox_Amount.TabIndex = 59;
            this.textbox_Amount.UseSelectable = true;
            this.textbox_Amount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_Amount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView_PreapaidAmount
            // 
            this.dataGridView_PreapaidAmount.AllowUserToAddRows = false;
            this.dataGridView_PreapaidAmount.AllowUserToDeleteRows = false;
            this.dataGridView_PreapaidAmount.AllowUserToResizeColumns = false;
            this.dataGridView_PreapaidAmount.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Thistle;
            this.dataGridView_PreapaidAmount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_PreapaidAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PreapaidAmount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView_PreapaidAmount.Location = new System.Drawing.Point(7, 36);
            this.dataGridView_PreapaidAmount.Name = "dataGridView_PreapaidAmount";
            this.dataGridView_PreapaidAmount.ReadOnly = true;
            this.dataGridView_PreapaidAmount.RowHeadersVisible = false;
            this.dataGridView_PreapaidAmount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_PreapaidAmount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PreapaidAmount.Size = new System.Drawing.Size(342, 207);
            this.dataGridView_PreapaidAmount.TabIndex = 43;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Id";
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "Type";
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // metroTextBox_Description
            // 
            // 
            // 
            // 
            this.metroTextBox_Description.CustomButton.Image = null;
            this.metroTextBox_Description.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.metroTextBox_Description.CustomButton.Name = "";
            this.metroTextBox_Description.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBox_Description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_Description.CustomButton.TabIndex = 1;
            this.metroTextBox_Description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_Description.CustomButton.UseSelectable = true;
            this.metroTextBox_Description.CustomButton.Visible = false;
            this.metroTextBox_Description.Lines = new string[0];
            this.metroTextBox_Description.Location = new System.Drawing.Point(130, 183);
            this.metroTextBox_Description.MaxLength = 32767;
            this.metroTextBox_Description.Name = "metroTextBox_Description";
            this.metroTextBox_Description.PasswordChar = '\0';
            this.metroTextBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_Description.SelectedText = "";
            this.metroTextBox_Description.SelectionLength = 0;
            this.metroTextBox_Description.SelectionStart = 0;
            this.metroTextBox_Description.ShortcutsEnabled = true;
            this.metroTextBox_Description.Size = new System.Drawing.Size(222, 20);
            this.metroTextBox_Description.TabIndex = 74;
            this.metroTextBox_Description.UseSelectable = true;
            this.metroTextBox_Description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_Description.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "Code";
            this.Column2.HeaderText = "Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 57;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "Description";
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 85;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Gateway";
            this.Column6.HeaderText = "Gateway";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // PrepaidCablePrefixes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 463);
            this.Controls.Add(this.metroTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrepaidCablePrefixes";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Prepaid Cable";
            this.Load += new System.EventHandler(this.PrepaidCableCode_Load);
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrepaidCable)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PreapaidAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dataGridView_PrepaidCable;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBox_SerchType;
        private MetroFramework.Controls.MetroButton cmd_clear;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton cmd_delete;
        private MetroFramework.Controls.MetroButton cmd_Add;
        private MetroFramework.Controls.MetroComboBox comboBox_CableType;
        private MetroFramework.Controls.MetroTextBox textbox_Amount;
        private System.Windows.Forms.DataGridView dataGridView_PreapaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Code;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Gateway;
        private MetroFramework.Controls.MetroButton cmd_codeClear;
        private MetroFramework.Controls.MetroButton cmd_codeDelete;
        private MetroFramework.Controls.MetroButton cmd_codeAdd;
        private MetroFramework.Controls.MetroButton cmd_codeSave;
        private MetroFramework.Controls.MetroButton cmd_codeEdit;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}