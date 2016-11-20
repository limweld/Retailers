namespace Retailers.Forms
{
    partial class PrepaidCableCards
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton_refresh = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.link_Transaction = new MetroFramework.Controls.MetroLink();
            this.link_CodeSetting = new MetroFramework.Controls.MetroLink();
            this.cmd_Cancel = new MetroFramework.Controls.MetroButton();
            this.cmd_Add = new MetroFramework.Controls.MetroButton();
            this.cmd_Edit = new MetroFramework.Controls.MetroButton();
            this.cmd_Save = new MetroFramework.Controls.MetroButton();
            this.cmd_Delete = new MetroFramework.Controls.MetroButton();
            this.textbox_Pin = new MetroFramework.Controls.MetroTextBox();
            this.comboBox_CableType = new MetroFramework.Controls.MetroComboBox();
            this.dateTimePicker_Expire = new MetroFramework.Controls.MetroDateTime();
            this.dateTimePicker_dateReg = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView_PrepaidCards = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton_Reload = new MetroFramework.Controls.MetroButton();
            this.dataGridView_PrepaidCardsLogs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroComboBox_TextAmount = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrepaidCards)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrepaidCardsLogs)).BeginInit();
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
            this.metroTabControl.Size = new System.Drawing.Size(690, 413);
            this.metroTabControl.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl.TabIndex = 1;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroComboBox_TextAmount);
            this.metroTabPage1.Controls.Add(this.metroButton_refresh);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.link_Transaction);
            this.metroTabPage1.Controls.Add(this.link_CodeSetting);
            this.metroTabPage1.Controls.Add(this.cmd_Cancel);
            this.metroTabPage1.Controls.Add(this.cmd_Add);
            this.metroTabPage1.Controls.Add(this.cmd_Edit);
            this.metroTabPage1.Controls.Add(this.cmd_Save);
            this.metroTabPage1.Controls.Add(this.cmd_Delete);
            this.metroTabPage1.Controls.Add(this.textbox_Pin);
            this.metroTabPage1.Controls.Add(this.comboBox_CableType);
            this.metroTabPage1.Controls.Add(this.dateTimePicker_Expire);
            this.metroTabPage1.Controls.Add(this.dateTimePicker_dateReg);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.dataGridView_PrepaidCards);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(682, 371);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Cards";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroButton_refresh
            // 
            this.metroButton_refresh.Location = new System.Drawing.Point(628, 8);
            this.metroButton_refresh.Name = "metroButton_refresh";
            this.metroButton_refresh.Size = new System.Drawing.Size(47, 21);
            this.metroButton_refresh.TabIndex = 61;
            this.metroButton_refresh.Text = "Reload";
            this.metroButton_refresh.UseSelectable = true;
            this.metroButton_refresh.Click += new System.EventHandler(this.metroButton_refresh_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(47, 8);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(15, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "||";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel10.UseStyleColors = true;
            // 
            // link_Transaction
            // 
            this.link_Transaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_Transaction.Location = new System.Drawing.Point(66, 8);
            this.link_Transaction.Name = "link_Transaction";
            this.link_Transaction.Size = new System.Drawing.Size(95, 23);
            this.link_Transaction.Style = MetroFramework.MetroColorStyle.Purple;
            this.link_Transaction.TabIndex = 60;
            this.link_Transaction.Text = "Transaction";
            this.link_Transaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_Transaction.UseSelectable = true;
            this.link_Transaction.UseStyleColors = true;
            this.link_Transaction.Click += new System.EventHandler(this.link_Transaction_Click);
            // 
            // link_CodeSetting
            // 
            this.link_CodeSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_CodeSetting.Location = new System.Drawing.Point(3, 8);
            this.link_CodeSetting.Name = "link_CodeSetting";
            this.link_CodeSetting.Size = new System.Drawing.Size(95, 23);
            this.link_CodeSetting.Style = MetroFramework.MetroColorStyle.Purple;
            this.link_CodeSetting.TabIndex = 59;
            this.link_CodeSetting.Text = "Prefix";
            this.link_CodeSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_CodeSetting.UseSelectable = true;
            this.link_CodeSetting.UseStyleColors = true;
            this.link_CodeSetting.Click += new System.EventHandler(this.link_CodeSetting_Click);
            // 
            // cmd_Cancel
            // 
            this.cmd_Cancel.Location = new System.Drawing.Point(580, 329);
            this.cmd_Cancel.Name = "cmd_Cancel";
            this.cmd_Cancel.Size = new System.Drawing.Size(95, 27);
            this.cmd_Cancel.TabIndex = 57;
            this.cmd_Cancel.Text = "CLEAR";
            this.cmd_Cancel.UseSelectable = true;
            this.cmd_Cancel.Click += new System.EventHandler(this.cmd_Cancel_Click);
            // 
            // cmd_Add
            // 
            this.cmd_Add.Location = new System.Drawing.Point(13, 329);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(95, 27);
            this.cmd_Add.TabIndex = 52;
            this.cmd_Add.Text = "ADD";
            this.cmd_Add.UseSelectable = true;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // cmd_Edit
            // 
            this.cmd_Edit.Location = new System.Drawing.Point(479, 329);
            this.cmd_Edit.Name = "cmd_Edit";
            this.cmd_Edit.Size = new System.Drawing.Size(95, 27);
            this.cmd_Edit.TabIndex = 56;
            this.cmd_Edit.Text = "EDIT";
            this.cmd_Edit.UseSelectable = true;
            this.cmd_Edit.Click += new System.EventHandler(this.cmd_Edit_Click);
            // 
            // cmd_Save
            // 
            this.cmd_Save.Location = new System.Drawing.Point(229, 329);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(95, 27);
            this.cmd_Save.TabIndex = 53;
            this.cmd_Save.Text = "SAVE";
            this.cmd_Save.UseSelectable = true;
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // cmd_Delete
            // 
            this.cmd_Delete.Location = new System.Drawing.Point(128, 329);
            this.cmd_Delete.Name = "cmd_Delete";
            this.cmd_Delete.Size = new System.Drawing.Size(95, 27);
            this.cmd_Delete.TabIndex = 54;
            this.cmd_Delete.Text = "DELETE";
            this.cmd_Delete.UseSelectable = true;
            this.cmd_Delete.Click += new System.EventHandler(this.cmd_Delete_Click);
            // 
            // textbox_Pin
            // 
            // 
            // 
            // 
            this.textbox_Pin.CustomButton.Image = null;
            this.textbox_Pin.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.textbox_Pin.CustomButton.Name = "";
            this.textbox_Pin.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textbox_Pin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_Pin.CustomButton.TabIndex = 1;
            this.textbox_Pin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_Pin.CustomButton.UseSelectable = true;
            this.textbox_Pin.CustomButton.Visible = false;
            this.textbox_Pin.Lines = new string[0];
            this.textbox_Pin.Location = new System.Drawing.Point(479, 258);
            this.textbox_Pin.MaxLength = 32767;
            this.textbox_Pin.Name = "textbox_Pin";
            this.textbox_Pin.PasswordChar = '\0';
            this.textbox_Pin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_Pin.SelectedText = "";
            this.textbox_Pin.SelectionLength = 0;
            this.textbox_Pin.SelectionStart = 0;
            this.textbox_Pin.ShortcutsEnabled = true;
            this.textbox_Pin.Size = new System.Drawing.Size(196, 20);
            this.textbox_Pin.TabIndex = 51;
            this.textbox_Pin.UseSelectable = true;
            this.textbox_Pin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_Pin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBox_CableType
            // 
            this.comboBox_CableType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBox_CableType.FormattingEnabled = true;
            this.comboBox_CableType.ItemHeight = 19;
            this.comboBox_CableType.Location = new System.Drawing.Point(128, 284);
            this.comboBox_CableType.Name = "comboBox_CableType";
            this.comboBox_CableType.Size = new System.Drawing.Size(196, 25);
            this.comboBox_CableType.TabIndex = 49;
            this.comboBox_CableType.UseSelectable = true;
            this.comboBox_CableType.SelectedIndexChanged += new System.EventHandler(this.comboBox_CableType_SelectedIndexChanged);
            // 
            // dateTimePicker_Expire
            // 
            this.dateTimePicker_Expire.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dateTimePicker_Expire.Location = new System.Drawing.Point(128, 253);
            this.dateTimePicker_Expire.MinimumSize = new System.Drawing.Size(0, 25);
            this.dateTimePicker_Expire.Name = "dateTimePicker_Expire";
            this.dateTimePicker_Expire.Size = new System.Drawing.Size(196, 25);
            this.dateTimePicker_Expire.Style = MetroFramework.MetroColorStyle.Silver;
            this.dateTimePicker_Expire.TabIndex = 47;
            // 
            // dateTimePicker_dateReg
            // 
            this.dateTimePicker_dateReg.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dateTimePicker_dateReg.Location = new System.Drawing.Point(128, 222);
            this.dateTimePicker_dateReg.MinimumSize = new System.Drawing.Size(0, 25);
            this.dateTimePicker_dateReg.Name = "dateTimePicker_dateReg";
            this.dateTimePicker_dateReg.Size = new System.Drawing.Size(196, 25);
            this.dateTimePicker_dateReg.Style = MetroFramework.MetroColorStyle.Silver;
            this.dateTimePicker_dateReg.TabIndex = 46;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(410, 259);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(34, 19);
            this.metroLabel5.TabIndex = 45;
            this.metroLabel5.Text = "Pin :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 290);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Cable Type :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 258);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Date Expired :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 227);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 19);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Date Registered :";
            // 
            // dataGridView_PrepaidCards
            // 
            this.dataGridView_PrepaidCards.AllowUserToAddRows = false;
            this.dataGridView_PrepaidCards.AllowUserToDeleteRows = false;
            this.dataGridView_PrepaidCards.AllowUserToResizeColumns = false;
            this.dataGridView_PrepaidCards.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Thistle;
            this.dataGridView_PrepaidCards.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_PrepaidCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PrepaidCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column9});
            this.dataGridView_PrepaidCards.Location = new System.Drawing.Point(3, 33);
            this.dataGridView_PrepaidCards.Name = "dataGridView_PrepaidCards";
            this.dataGridView_PrepaidCards.ReadOnly = true;
            this.dataGridView_PrepaidCards.RowHeadersVisible = false;
            this.dataGridView_PrepaidCards.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_PrepaidCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PrepaidCards.Size = new System.Drawing.Size(672, 178);
            this.dataGridView_PrepaidCards.TabIndex = 40;
            this.dataGridView_PrepaidCards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PrepaidCards_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 22;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CableType";
            this.Column4.HeaderText = "Cable Type";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Amount";
            this.Column5.HeaderText = "Amout";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Pin";
            this.Column6.HeaderText = "Pin";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Status";
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Date_Registered";
            this.Column10.HeaderText = "Date Registered";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Date_Expired";
            this.Column9.HeaderText = "Date Expired";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton_Reload);
            this.metroTabPage2.Controls.Add(this.dataGridView_PrepaidCardsLogs);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(682, 371);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Used";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.UseCustomBackColor = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Visible = false;
            // 
            // metroButton_Reload
            // 
            this.metroButton_Reload.Location = new System.Drawing.Point(584, 330);
            this.metroButton_Reload.Name = "metroButton_Reload";
            this.metroButton_Reload.Size = new System.Drawing.Size(95, 27);
            this.metroButton_Reload.TabIndex = 58;
            this.metroButton_Reload.Text = "Reload";
            this.metroButton_Reload.UseSelectable = true;
            this.metroButton_Reload.Click += new System.EventHandler(this.metroButton_Reload_Click);
            // 
            // dataGridView_PrepaidCardsLogs
            // 
            this.dataGridView_PrepaidCardsLogs.AllowUserToAddRows = false;
            this.dataGridView_PrepaidCardsLogs.AllowUserToDeleteRows = false;
            this.dataGridView_PrepaidCardsLogs.AllowUserToResizeColumns = false;
            this.dataGridView_PrepaidCardsLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Thistle;
            this.dataGridView_PrepaidCardsLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_PrepaidCardsLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PrepaidCardsLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column11});
            this.dataGridView_PrepaidCardsLogs.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_PrepaidCardsLogs.Name = "dataGridView_PrepaidCardsLogs";
            this.dataGridView_PrepaidCardsLogs.ReadOnly = true;
            this.dataGridView_PrepaidCardsLogs.RowHeadersVisible = false;
            this.dataGridView_PrepaidCardsLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PrepaidCardsLogs.Size = new System.Drawing.Size(676, 311);
            this.dataGridView_PrepaidCardsLogs.TabIndex = 56;
            this.dataGridView_PrepaidCardsLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PrepaidCardsLogs_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CableType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cable Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Amout";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pin";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Date_Used";
            this.Column11.HeaderText = "Date Used";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // metroComboBox_TextAmount
            // 
            this.metroComboBox_TextAmount.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox_TextAmount.FormattingEnabled = true;
            this.metroComboBox_TextAmount.ItemHeight = 19;
            this.metroComboBox_TextAmount.Location = new System.Drawing.Point(479, 222);
            this.metroComboBox_TextAmount.Name = "metroComboBox_TextAmount";
            this.metroComboBox_TextAmount.Size = new System.Drawing.Size(196, 25);
            this.metroComboBox_TextAmount.TabIndex = 62;
            this.metroComboBox_TextAmount.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(410, 226);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 63;
            this.metroLabel6.Text = "Amount :";
            // 
            // PrepaidCableCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 493);
            this.Controls.Add(this.metroTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrepaidCableCards";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "PrepaidCable Cards";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrepaidCableCards_FormClosed);
            this.Load += new System.EventHandler(this.PrepaidCableCards_Load);
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrepaidCards)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrepaidCardsLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView dataGridView_PrepaidCards;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime dateTimePicker_Expire;
        private MetroFramework.Controls.MetroDateTime dateTimePicker_dateReg;
        private MetroFramework.Controls.MetroComboBox comboBox_CableType;
        private MetroFramework.Controls.MetroTextBox textbox_Pin;
        private MetroFramework.Controls.MetroButton cmd_Add;
        private MetroFramework.Controls.MetroButton cmd_Edit;
        private MetroFramework.Controls.MetroButton cmd_Save;
        private MetroFramework.Controls.MetroButton cmd_Delete;
        private MetroFramework.Controls.MetroButton cmd_Cancel;
        private System.Windows.Forms.DataGridView dataGridView_PrepaidCardsLogs;
        private MetroFramework.Controls.MetroButton metroButton_Reload;
        private MetroFramework.Controls.MetroLink link_CodeSetting;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLink link_Transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private MetroFramework.Controls.MetroButton metroButton_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox metroComboBox_TextAmount;
    }
}