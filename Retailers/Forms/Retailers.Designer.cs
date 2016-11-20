namespace Retailers.Forms
{
    partial class Retailers
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
            this.dataGridView_Retailer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.cmd_Cancel = new MetroFramework.Controls.MetroButton();
            this.cmd_Add = new MetroFramework.Controls.MetroButton();
            this.cmd_Edit = new MetroFramework.Controls.MetroButton();
            this.cmd_Save = new MetroFramework.Controls.MetroButton();
            this.cmd_Delete = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker_dateReg = new MetroFramework.Controls.MetroDateTime();
            this.textBox_Firstname = new MetroFramework.Controls.MetroTextBox();
            this.textBox_Lastname = new MetroFramework.Controls.MetroTextBox();
            this.dateTimePicker_BirthDate = new MetroFramework.Controls.MetroDateTime();
            this.textBox_Street = new MetroFramework.Controls.MetroTextBox();
            this.textbox_Frozen = new MetroFramework.Controls.MetroTextBox();
            this.textbox_Balance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.maskedTextBox_Wallet_Id = new System.Windows.Forms.MaskedTextBox();
            this.maskedText_Sponsor_ID = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_Province = new MetroFramework.Controls.MetroComboBox();
            this.comboBox_City = new MetroFramework.Controls.MetroComboBox();
            this.comboBox_Barangay = new MetroFramework.Controls.MetroComboBox();
            this.textbox_City = new MetroFramework.Controls.MetroTextBox();
            this.textbox_Province = new MetroFramework.Controls.MetroTextBox();
            this.textbox_Barangay = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonrefresh = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Retailer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Retailer
            // 
            this.dataGridView_Retailer.AllowUserToAddRows = false;
            this.dataGridView_Retailer.AllowUserToDeleteRows = false;
            this.dataGridView_Retailer.AllowUserToResizeColumns = false;
            this.dataGridView_Retailer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView_Retailer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Retailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Retailer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridView_Retailer.Location = new System.Drawing.Point(373, 73);
            this.dataGridView_Retailer.Name = "dataGridView_Retailer";
            this.dataGridView_Retailer.ReadOnly = true;
            this.dataGridView_Retailer.RowHeadersVisible = false;
            this.dataGridView_Retailer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Retailer.Size = new System.Drawing.Size(728, 339);
            this.dataGridView_Retailer.TabIndex = 1;
            this.dataGridView_Retailer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Retailer_CellClick);
            this.dataGridView_Retailer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Retailer_CellContentClick);
            this.dataGridView_Retailer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Retailer_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "Wallet_ID";
            this.Column1.HeaderText = "Wallet ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "Date";
            this.Column2.HeaderText = "Date Registered";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "Fname";
            this.Column3.HeaderText = "Firstname";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 77;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.DataPropertyName = "Lname";
            this.Column4.HeaderText = "Lastname";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 78;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "Birth_Date";
            this.Column5.HeaderText = "BirthDate";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 76;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.DataPropertyName = "BlockStr";
            this.Column6.HeaderText = "Block / Str";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 65;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column7.DataPropertyName = "Barangay";
            this.Column7.HeaderText = "Barangay";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 77;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column8.DataPropertyName = "City";
            this.Column8.HeaderText = "City";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 49;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column9.DataPropertyName = "Province";
            this.Column9.HeaderText = "Province";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 74;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column10.DataPropertyName = "Frozen";
            this.Column10.HeaderText = "Frozen";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 64;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column11.DataPropertyName = "Balance";
            this.Column11.HeaderText = "Balance";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 71;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column12.DataPropertyName = "Sponsor_ID";
            this.Column12.HeaderText = "Sponsor Id";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Register :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firstname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lastname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wallet ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "BirthDate :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Province :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "City :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Barangay :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Block/ Str :";
            // 
            // cmd_Cancel
            // 
            this.cmd_Cancel.Location = new System.Drawing.Point(1006, 433);
            this.cmd_Cancel.Name = "cmd_Cancel";
            this.cmd_Cancel.Size = new System.Drawing.Size(95, 39);
            this.cmd_Cancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmd_Cancel.TabIndex = 12;
            this.cmd_Cancel.Text = "CANCEL";
            this.cmd_Cancel.UseSelectable = true;
            this.cmd_Cancel.Click += new System.EventHandler(this.cmd_Cancel_Click);
            // 
            // cmd_Add
            // 
            this.cmd_Add.Location = new System.Drawing.Point(57, 433);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(95, 39);
            this.cmd_Add.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmd_Add.TabIndex = 13;
            this.cmd_Add.Text = "ADD";
            this.cmd_Add.UseSelectable = true;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // cmd_Edit
            // 
            this.cmd_Edit.Location = new System.Drawing.Point(373, 433);
            this.cmd_Edit.Name = "cmd_Edit";
            this.cmd_Edit.Size = new System.Drawing.Size(95, 39);
            this.cmd_Edit.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmd_Edit.TabIndex = 38;
            this.cmd_Edit.Text = "EDIT";
            this.cmd_Edit.UseSelectable = true;
            this.cmd_Edit.Click += new System.EventHandler(this.cmd_Edit_Click);
            // 
            // cmd_Save
            // 
            this.cmd_Save.Location = new System.Drawing.Point(259, 433);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(95, 39);
            this.cmd_Save.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmd_Save.TabIndex = 15;
            this.cmd_Save.Text = "SAVE";
            this.cmd_Save.UseSelectable = true;
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Location = new System.Drawing.Point(158, 433);
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.Size = new System.Drawing.Size(95, 39);
            this.cmd_Delete.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmd_Delete.TabIndex = 16;
            this.cmd_Delete.Text = "DELETE";
            this.cmd_Delete.UseSelectable = true;
            this.cmd_Delete.Click += new System.EventHandler(this.cmd_Delete_Click);
            // 
            // dateTimePicker_dateReg
            // 
            this.dateTimePicker_dateReg.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dateTimePicker_dateReg.Location = new System.Drawing.Point(158, 73);
            this.dateTimePicker_dateReg.MinimumSize = new System.Drawing.Size(0, 25);
            this.dateTimePicker_dateReg.Name = "dateTimePicker_dateReg";
            this.dateTimePicker_dateReg.Size = new System.Drawing.Size(196, 25);
            this.dateTimePicker_dateReg.Style = MetroFramework.MetroColorStyle.Silver;
            this.dateTimePicker_dateReg.TabIndex = 29;
            // 
            // textBox_Firstname
            // 
            // 
            // 
            // 
            this.textBox_Firstname.CustomButton.Image = null;
            this.textBox_Firstname.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.textBox_Firstname.CustomButton.Name = "";
            this.textBox_Firstname.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox_Firstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Firstname.CustomButton.TabIndex = 1;
            this.textBox_Firstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Firstname.CustomButton.UseSelectable = true;
            this.textBox_Firstname.CustomButton.Visible = false;
            this.textBox_Firstname.Lines = new string[0];
            this.textBox_Firstname.Location = new System.Drawing.Point(158, 134);
            this.textBox_Firstname.MaxLength = 32767;
            this.textBox_Firstname.Name = "textBox_Firstname";
            this.textBox_Firstname.PasswordChar = '\0';
            this.textBox_Firstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Firstname.SelectedText = "";
            this.textBox_Firstname.SelectionLength = 0;
            this.textBox_Firstname.SelectionStart = 0;
            this.textBox_Firstname.ShortcutsEnabled = true;
            this.textBox_Firstname.Size = new System.Drawing.Size(196, 20);
            this.textBox_Firstname.TabIndex = 32;
            this.textBox_Firstname.UseSelectable = true;
            this.textBox_Firstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_Firstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox_Lastname
            // 
            // 
            // 
            // 
            this.textBox_Lastname.CustomButton.Image = null;
            this.textBox_Lastname.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.textBox_Lastname.CustomButton.Name = "";
            this.textBox_Lastname.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox_Lastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Lastname.CustomButton.TabIndex = 1;
            this.textBox_Lastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Lastname.CustomButton.UseSelectable = true;
            this.textBox_Lastname.CustomButton.Visible = false;
            this.textBox_Lastname.Lines = new string[0];
            this.textBox_Lastname.Location = new System.Drawing.Point(158, 160);
            this.textBox_Lastname.MaxLength = 32767;
            this.textBox_Lastname.Name = "textBox_Lastname";
            this.textBox_Lastname.PasswordChar = '\0';
            this.textBox_Lastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Lastname.SelectedText = "";
            this.textBox_Lastname.SelectionLength = 0;
            this.textBox_Lastname.SelectionStart = 0;
            this.textBox_Lastname.ShortcutsEnabled = true;
            this.textBox_Lastname.Size = new System.Drawing.Size(196, 20);
            this.textBox_Lastname.TabIndex = 30;
            this.textBox_Lastname.UseSelectable = true;
            this.textBox_Lastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_Lastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.AllowDrop = true;
            this.dateTimePicker_BirthDate.CustomFormat = "";
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(158, 186);
            this.dateTimePicker_BirthDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(196, 29);
            this.dateTimePicker_BirthDate.TabIndex = 33;
            // 
            // textBox_Street
            // 
            // 
            // 
            // 
            this.textBox_Street.CustomButton.Image = null;
            this.textBox_Street.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.textBox_Street.CustomButton.Name = "";
            this.textBox_Street.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBox_Street.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Street.CustomButton.TabIndex = 1;
            this.textBox_Street.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Street.CustomButton.UseSelectable = true;
            this.textBox_Street.CustomButton.Visible = false;
            this.textBox_Street.Lines = new string[0];
            this.textBox_Street.Location = new System.Drawing.Point(158, 314);
            this.textBox_Street.MaxLength = 32767;
            this.textBox_Street.Name = "textBox_Street";
            this.textBox_Street.PasswordChar = '\0';
            this.textBox_Street.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Street.SelectedText = "";
            this.textBox_Street.SelectionLength = 0;
            this.textBox_Street.SelectionStart = 0;
            this.textBox_Street.ShortcutsEnabled = true;
            this.textBox_Street.Size = new System.Drawing.Size(196, 20);
            this.textBox_Street.TabIndex = 37;
            this.textBox_Street.UseSelectable = true;
            this.textBox_Street.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_Street.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_Frozen
            // 
            // 
            // 
            // 
            this.textbox_Frozen.CustomButton.Image = null;
            this.textbox_Frozen.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.textbox_Frozen.CustomButton.Name = "";
            this.textbox_Frozen.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textbox_Frozen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_Frozen.CustomButton.TabIndex = 1;
            this.textbox_Frozen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_Frozen.CustomButton.UseSelectable = true;
            this.textbox_Frozen.CustomButton.Visible = false;
            this.textbox_Frozen.Enabled = false;
            this.textbox_Frozen.Lines = new string[] {
        "0"};
            this.textbox_Frozen.Location = new System.Drawing.Point(158, 340);
            this.textbox_Frozen.MaxLength = 32767;
            this.textbox_Frozen.Name = "textbox_Frozen";
            this.textbox_Frozen.PasswordChar = '\0';
            this.textbox_Frozen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_Frozen.SelectedText = "";
            this.textbox_Frozen.SelectionLength = 0;
            this.textbox_Frozen.SelectionStart = 0;
            this.textbox_Frozen.ShortcutsEnabled = true;
            this.textbox_Frozen.Size = new System.Drawing.Size(196, 20);
            this.textbox_Frozen.TabIndex = 39;
            this.textbox_Frozen.Text = "0";
            this.textbox_Frozen.UseSelectable = true;
            this.textbox_Frozen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_Frozen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_Balance
            // 
            // 
            // 
            // 
            this.textbox_Balance.CustomButton.Image = null;
            this.textbox_Balance.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.textbox_Balance.CustomButton.Name = "";
            this.textbox_Balance.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textbox_Balance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_Balance.CustomButton.TabIndex = 1;
            this.textbox_Balance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_Balance.CustomButton.UseSelectable = true;
            this.textbox_Balance.CustomButton.Visible = false;
            this.textbox_Balance.Enabled = false;
            this.textbox_Balance.Lines = new string[] {
        "0"};
            this.textbox_Balance.Location = new System.Drawing.Point(158, 366);
            this.textbox_Balance.MaxLength = 32767;
            this.textbox_Balance.Name = "textbox_Balance";
            this.textbox_Balance.PasswordChar = '\0';
            this.textbox_Balance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_Balance.SelectedText = "";
            this.textbox_Balance.SelectionLength = 0;
            this.textbox_Balance.SelectionStart = 0;
            this.textbox_Balance.ShortcutsEnabled = true;
            this.textbox_Balance.Size = new System.Drawing.Size(196, 20);
            this.textbox_Balance.TabIndex = 40;
            this.textbox_Balance.Text = "0";
            this.textbox_Balance.UseSelectable = true;
            this.textbox_Balance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_Balance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 341);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Frozen :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(53, 367);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Balance :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 393);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "Sponsor ID :";
            // 
            // maskedTextBox_Wallet_Id
            // 
            this.maskedTextBox_Wallet_Id.Location = new System.Drawing.Point(158, 108);
            this.maskedTextBox_Wallet_Id.Mask = "0000-000-0000";
            this.maskedTextBox_Wallet_Id.Name = "maskedTextBox_Wallet_Id";
            this.maskedTextBox_Wallet_Id.PromptChar = ' ';
            this.maskedTextBox_Wallet_Id.Size = new System.Drawing.Size(196, 20);
            this.maskedTextBox_Wallet_Id.TabIndex = 45;
            // 
            // maskedText_Sponsor_ID
            // 
            this.maskedText_Sponsor_ID.Enabled = false;
            this.maskedText_Sponsor_ID.Location = new System.Drawing.Point(158, 392);
            this.maskedText_Sponsor_ID.Mask = "0000-000-0000";
            this.maskedText_Sponsor_ID.Name = "maskedText_Sponsor_ID";
            this.maskedText_Sponsor_ID.Size = new System.Drawing.Size(196, 20);
            this.maskedText_Sponsor_ID.TabIndex = 46;
            this.maskedText_Sponsor_ID.Text = "00000000000";
            // 
            // comboBox_Province
            // 
            this.comboBox_Province.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBox_Province.FormattingEnabled = true;
            this.comboBox_Province.ItemHeight = 19;
            this.comboBox_Province.Location = new System.Drawing.Point(158, 221);
            this.comboBox_Province.Name = "comboBox_Province";
            this.comboBox_Province.Size = new System.Drawing.Size(196, 25);
            this.comboBox_Province.TabIndex = 48;
            this.comboBox_Province.UseSelectable = true;
            this.comboBox_Province.SelectedIndexChanged += new System.EventHandler(this.comboBox_Province_SelectedIndexChanged);
            // 
            // comboBox_City
            // 
            this.comboBox_City.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.ItemHeight = 19;
            this.comboBox_City.Location = new System.Drawing.Point(158, 252);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(196, 25);
            this.comboBox_City.TabIndex = 49;
            this.comboBox_City.UseSelectable = true;
            this.comboBox_City.SelectedIndexChanged += new System.EventHandler(this.comboBox_City_SelectedIndexChanged);
            // 
            // comboBox_Barangay
            // 
            this.comboBox_Barangay.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBox_Barangay.FormattingEnabled = true;
            this.comboBox_Barangay.ItemHeight = 19;
            this.comboBox_Barangay.Location = new System.Drawing.Point(158, 283);
            this.comboBox_Barangay.Name = "comboBox_Barangay";
            this.comboBox_Barangay.Size = new System.Drawing.Size(196, 25);
            this.comboBox_Barangay.TabIndex = 50;
            this.comboBox_Barangay.UseSelectable = true;
            this.comboBox_Barangay.SelectedIndexChanged += new System.EventHandler(this.comboBox_Barangay_SelectedIndexChanged);
            // 
            // textbox_City
            // 
            // 
            // 
            // 
            this.textbox_City.CustomButton.Image = null;
            this.textbox_City.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.textbox_City.CustomButton.Name = "";
            this.textbox_City.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textbox_City.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_City.CustomButton.TabIndex = 1;
            this.textbox_City.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_City.CustomButton.UseSelectable = true;
            this.textbox_City.CustomButton.Visible = false;
            this.textbox_City.Enabled = false;
            this.textbox_City.Lines = new string[0];
            this.textbox_City.Location = new System.Drawing.Point(158, 252);
            this.textbox_City.MaxLength = 32767;
            this.textbox_City.Name = "textbox_City";
            this.textbox_City.PasswordChar = '\0';
            this.textbox_City.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_City.SelectedText = "";
            this.textbox_City.SelectionLength = 0;
            this.textbox_City.SelectionStart = 0;
            this.textbox_City.ShortcutsEnabled = true;
            this.textbox_City.Size = new System.Drawing.Size(174, 25);
            this.textbox_City.TabIndex = 51;
            this.textbox_City.UseSelectable = true;
            this.textbox_City.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_City.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_Province
            // 
            // 
            // 
            // 
            this.textbox_Province.CustomButton.Image = null;
            this.textbox_Province.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.textbox_Province.CustomButton.Name = "";
            this.textbox_Province.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textbox_Province.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_Province.CustomButton.TabIndex = 1;
            this.textbox_Province.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_Province.CustomButton.UseSelectable = true;
            this.textbox_Province.CustomButton.Visible = false;
            this.textbox_Province.Enabled = false;
            this.textbox_Province.Lines = new string[0];
            this.textbox_Province.Location = new System.Drawing.Point(158, 221);
            this.textbox_Province.MaxLength = 32767;
            this.textbox_Province.Name = "textbox_Province";
            this.textbox_Province.PasswordChar = '\0';
            this.textbox_Province.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_Province.SelectedText = "";
            this.textbox_Province.SelectionLength = 0;
            this.textbox_Province.SelectionStart = 0;
            this.textbox_Province.ShortcutsEnabled = true;
            this.textbox_Province.Size = new System.Drawing.Size(174, 25);
            this.textbox_Province.TabIndex = 52;
            this.textbox_Province.UseSelectable = true;
            this.textbox_Province.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_Province.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_Barangay
            // 
            // 
            // 
            // 
            this.textbox_Barangay.CustomButton.Image = null;
            this.textbox_Barangay.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.textbox_Barangay.CustomButton.Name = "";
            this.textbox_Barangay.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textbox_Barangay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_Barangay.CustomButton.TabIndex = 1;
            this.textbox_Barangay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_Barangay.CustomButton.UseSelectable = true;
            this.textbox_Barangay.CustomButton.Visible = false;
            this.textbox_Barangay.Enabled = false;
            this.textbox_Barangay.Lines = new string[0];
            this.textbox_Barangay.Location = new System.Drawing.Point(158, 283);
            this.textbox_Barangay.MaxLength = 32767;
            this.textbox_Barangay.Name = "textbox_Barangay";
            this.textbox_Barangay.PasswordChar = '\0';
            this.textbox_Barangay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_Barangay.SelectedText = "";
            this.textbox_Barangay.SelectionLength = 0;
            this.textbox_Barangay.SelectionStart = 0;
            this.textbox_Barangay.ShortcutsEnabled = true;
            this.textbox_Barangay.Size = new System.Drawing.Size(174, 25);
            this.textbox_Barangay.TabIndex = 53;
            this.textbox_Barangay.UseSelectable = true;
            this.textbox_Barangay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_Barangay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(905, 47);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(196, 20);
            this.metroTextBox1.TabIndex = 54;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(832, 48);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 55;
            this.metroLabel4.Text = "Search :";
            // 
            // metroButtonrefresh
            // 
            this.metroButtonrefresh.Location = new System.Drawing.Point(373, 48);
            this.metroButtonrefresh.Name = "metroButtonrefresh";
            this.metroButtonrefresh.Size = new System.Drawing.Size(63, 19);
            this.metroButtonrefresh.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButtonrefresh.TabIndex = 56;
            this.metroButtonrefresh.Text = "Refresh";
            this.metroButtonrefresh.UseSelectable = true;
            this.metroButtonrefresh.Click += new System.EventHandler(this.metroButtonrefresh_Click);
            // 
            // Retailers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 494);
            this.Controls.Add(this.metroButtonrefresh);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.textbox_Barangay);
            this.Controls.Add(this.textbox_Province);
            this.Controls.Add(this.textbox_City);
            this.Controls.Add(this.comboBox_Barangay);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.comboBox_Province);
            this.Controls.Add(this.maskedText_Sponsor_ID);
            this.Controls.Add(this.maskedTextBox_Wallet_Id);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textbox_Balance);
            this.Controls.Add(this.textbox_Frozen);
            this.Controls.Add(this.textBox_Street);
            this.Controls.Add(this.dateTimePicker_dateReg);
            this.Controls.Add(this.textBox_Firstname);
            this.Controls.Add(this.textBox_Lastname);
            this.Controls.Add(this.dateTimePicker_BirthDate);
            this.Controls.Add(this.cmd_Add);
            this.Controls.Add(this.cmd_Edit);
            this.Controls.Add(this.cmd_Save);
            this.Controls.Add(this.cmd_Delete);
            this.Controls.Add(this.cmd_Cancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Retailer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Retailers";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Retailers";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Retailers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Retailer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Retailer;
        private MetroFramework.Controls.MetroButton cmd_Add;
        private MetroFramework.Controls.MetroButton cmd_Edit;
        private MetroFramework.Controls.MetroButton cmd_Save;
        private MetroFramework.Controls.MetroButton cmd_Delete;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroLabel label8;
        private MetroFramework.Controls.MetroLabel label9;
        private MetroFramework.Controls.MetroDateTime dateTimePicker_dateReg;
        private MetroFramework.Controls.MetroTextBox textBox_Firstname;
        private MetroFramework.Controls.MetroTextBox textBox_Lastname;
        private MetroFramework.Controls.MetroTextBox textBox_Street;
        private MetroFramework.Controls.MetroButton cmd_Cancel;
        private MetroFramework.Controls.MetroDateTime dateTimePicker_BirthDate;
        private MetroFramework.Controls.MetroTextBox textbox_Frozen;
        private MetroFramework.Controls.MetroTextBox textbox_Balance;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Wallet_Id;
        private System.Windows.Forms.MaskedTextBox maskedText_Sponsor_ID;
        private MetroFramework.Controls.MetroComboBox comboBox_Province;
        private MetroFramework.Controls.MetroComboBox comboBox_City;
        private MetroFramework.Controls.MetroComboBox comboBox_Barangay;
        private MetroFramework.Controls.MetroTextBox textbox_City;
        private MetroFramework.Controls.MetroTextBox textbox_Province;
        private MetroFramework.Controls.MetroTextBox textbox_Barangay;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private MetroFramework.Controls.MetroButton metroButtonrefresh;
    }
}

