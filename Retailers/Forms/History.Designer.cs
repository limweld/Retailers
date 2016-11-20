namespace Retailers.Forms
{
    partial class History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTextRefresh = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonDelete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonResent = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.dataGridViewUnsent = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTextButtonRefresh = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime_Present = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime_Past = new MetroFramework.Controls.MetroDateTime();
            this.dataGridView_PrepaidHistory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTextButton1Fresh = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimePresentBill = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTimePastBill = new MetroFramework.Controls.MetroDateTime();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.maskedTextBox_Wallet_Id = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnsent)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrepaidHistory)).BeginInit();
            this.metroTabControl.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTextRefresh);
            this.metroTabPage1.Controls.Add(this.metroTextButtonDelete);
            this.metroTabPage1.Controls.Add(this.metroTextButtonResent);
            this.metroTabPage1.Controls.Add(this.dataGridViewUnsent);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(440, 261);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "Unsent";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTextRefresh
            // 
            this.metroTextRefresh.BackColor = System.Drawing.Color.Red;
            this.metroTextRefresh.Image = null;
            this.metroTextRefresh.Location = new System.Drawing.Point(-1, 229);
            this.metroTextRefresh.Name = "metroTextRefresh";
            this.metroTextRefresh.Size = new System.Drawing.Size(63, 29);
            this.metroTextRefresh.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextRefresh.TabIndex = 89;
            this.metroTextRefresh.Text = "Refresh";
            this.metroTextRefresh.UseSelectable = true;
            this.metroTextRefresh.UseVisualStyleBackColor = false;
            // 
            // metroTextButtonDelete
            // 
            this.metroTextButtonDelete.BackColor = System.Drawing.Color.Red;
            this.metroTextButtonDelete.Image = null;
            this.metroTextButtonDelete.Location = new System.Drawing.Point(264, 229);
            this.metroTextButtonDelete.Name = "metroTextButtonDelete";
            this.metroTextButtonDelete.Size = new System.Drawing.Size(85, 29);
            this.metroTextButtonDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButtonDelete.TabIndex = 88;
            this.metroTextButtonDelete.Text = "Delete";
            this.metroTextButtonDelete.UseSelectable = true;
            this.metroTextButtonDelete.UseVisualStyleBackColor = false;
            // 
            // metroTextButtonResent
            // 
            this.metroTextButtonResent.BackColor = System.Drawing.Color.Red;
            this.metroTextButtonResent.Image = null;
            this.metroTextButtonResent.Location = new System.Drawing.Point(355, 229);
            this.metroTextButtonResent.Name = "metroTextButtonResent";
            this.metroTextButtonResent.Size = new System.Drawing.Size(85, 29);
            this.metroTextButtonResent.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButtonResent.TabIndex = 87;
            this.metroTextButtonResent.Text = "Resent";
            this.metroTextButtonResent.UseSelectable = true;
            this.metroTextButtonResent.UseVisualStyleBackColor = false;
            // 
            // dataGridViewUnsent
            // 
            this.dataGridViewUnsent.AllowUserToAddRows = false;
            this.dataGridViewUnsent.AllowUserToDeleteRows = false;
            this.dataGridViewUnsent.AllowUserToResizeColumns = false;
            this.dataGridViewUnsent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Aquamarine;
            this.dataGridViewUnsent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUnsent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnsent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.Column6});
            this.dataGridViewUnsent.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewUnsent.Name = "dataGridViewUnsent";
            this.dataGridViewUnsent.ReadOnly = true;
            this.dataGridViewUnsent.RowHeadersVisible = false;
            this.dataGridViewUnsent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUnsent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnsent.Size = new System.Drawing.Size(441, 220);
            this.dataGridViewUnsent.TabIndex = 86;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID";
            this.Column8.HeaderText = "ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumn1.HeaderText = "Message";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.DataPropertyName = "Sent";
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 62;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroTextButtonRefresh);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroDateTime_Present);
            this.metroTabPage2.Controls.Add(this.metroDateTime_Past);
            this.metroTabPage2.Controls.Add(this.dataGridView_PrepaidHistory);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(440, 261);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Prepaic Cable";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // metroTextButtonRefresh
            // 
            this.metroTextButtonRefresh.BackColor = System.Drawing.Color.Red;
            this.metroTextButtonRefresh.Image = null;
            this.metroTextButtonRefresh.Location = new System.Drawing.Point(376, 3);
            this.metroTextButtonRefresh.Name = "metroTextButtonRefresh";
            this.metroTextButtonRefresh.Size = new System.Drawing.Size(63, 28);
            this.metroTextButtonRefresh.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButtonRefresh.TabIndex = 88;
            this.metroTextButtonRefresh.Text = "Refresh";
            this.metroTextButtonRefresh.UseSelectable = true;
            this.metroTextButtonRefresh.UseVisualStyleBackColor = false;
            this.metroTextButtonRefresh.Click += new System.EventHandler(this.metroTextButtonRefresh_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(148, 8);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(22, 19);
            this.metroLabel5.TabIndex = 87;
            this.metroLabel5.Text = "To";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(1, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 86;
            this.metroLabel4.Text = "Date :";
            // 
            // metroDateTime_Present
            // 
            this.metroDateTime_Present.AllowDrop = true;
            this.metroDateTime_Present.CustomFormat = "";
            this.metroDateTime_Present.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_Present.Location = new System.Drawing.Point(175, 3);
            this.metroDateTime_Present.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime_Present.Name = "metroDateTime_Present";
            this.metroDateTime_Present.Size = new System.Drawing.Size(98, 29);
            this.metroDateTime_Present.TabIndex = 85;
            this.metroDateTime_Present.Value = new System.DateTime(2016, 5, 20, 0, 0, 0, 0);
            this.metroDateTime_Present.ValueChanged += new System.EventHandler(this.metroDateTime_Present_ValueChanged);
            // 
            // metroDateTime_Past
            // 
            this.metroDateTime_Past.AllowDrop = true;
            this.metroDateTime_Past.CustomFormat = "";
            this.metroDateTime_Past.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_Past.Location = new System.Drawing.Point(47, 3);
            this.metroDateTime_Past.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime_Past.Name = "metroDateTime_Past";
            this.metroDateTime_Past.Size = new System.Drawing.Size(98, 29);
            this.metroDateTime_Past.TabIndex = 84;
            this.metroDateTime_Past.Value = new System.DateTime(2016, 5, 20, 0, 0, 0, 0);
            this.metroDateTime_Past.ValueChanged += new System.EventHandler(this.metroDateTime_Past_ValueChanged);
            // 
            // dataGridView_PrepaidHistory
            // 
            this.dataGridView_PrepaidHistory.AllowUserToAddRows = false;
            this.dataGridView_PrepaidHistory.AllowUserToDeleteRows = false;
            this.dataGridView_PrepaidHistory.AllowUserToResizeColumns = false;
            this.dataGridView_PrepaidHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Aquamarine;
            this.dataGridView_PrepaidHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_PrepaidHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PrepaidHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView_PrepaidHistory.Location = new System.Drawing.Point(3, 41);
            this.dataGridView_PrepaidHistory.Name = "dataGridView_PrepaidHistory";
            this.dataGridView_PrepaidHistory.ReadOnly = true;
            this.dataGridView_PrepaidHistory.RowHeadersVisible = false;
            this.dataGridView_PrepaidHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_PrepaidHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PrepaidHistory.Size = new System.Drawing.Size(441, 217);
            this.dataGridView_PrepaidHistory.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "Code";
            this.Column1.HeaderText = "Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 56;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "Amount";
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 68;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "Discount";
            this.Column3.HeaderText = "Discount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 74;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Customer_Number";
            this.Column5.HeaderText = "Customer";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.DataPropertyName = "Date";
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 55;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPage2);
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Controls.Add(this.metroTabPage3);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 2;
            this.metroTabControl.Size = new System.Drawing.Size(448, 303);
            this.metroTabControl.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl.TabIndex = 4;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroTextButton1Fresh);
            this.metroTabPage3.Controls.Add(this.metroLabel1);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.Controls.Add(this.metroDateTimePresentBill);
            this.metroTabPage3.Controls.Add(this.metroDateTimePastBill);
            this.metroTabPage3.Controls.Add(this.dataGridViewBill);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(440, 261);
            this.metroTabPage3.TabIndex = 4;
            this.metroTabPage3.Text = "Bills Payment";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTextButton1Fresh
            // 
            this.metroTextButton1Fresh.BackColor = System.Drawing.Color.Red;
            this.metroTextButton1Fresh.Image = null;
            this.metroTextButton1Fresh.Location = new System.Drawing.Point(378, 3);
            this.metroTextButton1Fresh.Name = "metroTextButton1Fresh";
            this.metroTextButton1Fresh.Size = new System.Drawing.Size(63, 28);
            this.metroTextButton1Fresh.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButton1Fresh.TabIndex = 94;
            this.metroTextButton1Fresh.Text = "Refresh";
            this.metroTextButton1Fresh.UseSelectable = true;
            this.metroTextButton1Fresh.UseVisualStyleBackColor = false;
            this.metroTextButton1Fresh.Click += new System.EventHandler(this.metroTextButton1Fresh_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(150, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(22, 19);
            this.metroLabel1.TabIndex = 93;
            this.metroLabel1.Text = "To";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 8);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 92;
            this.metroLabel2.Text = "Date :";
            // 
            // metroDateTimePresentBill
            // 
            this.metroDateTimePresentBill.AllowDrop = true;
            this.metroDateTimePresentBill.CustomFormat = "";
            this.metroDateTimePresentBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimePresentBill.Location = new System.Drawing.Point(177, 3);
            this.metroDateTimePresentBill.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimePresentBill.Name = "metroDateTimePresentBill";
            this.metroDateTimePresentBill.Size = new System.Drawing.Size(98, 29);
            this.metroDateTimePresentBill.TabIndex = 91;
            this.metroDateTimePresentBill.Value = new System.DateTime(2016, 5, 20, 0, 0, 0, 0);
            // 
            // metroDateTimePastBill
            // 
            this.metroDateTimePastBill.AllowDrop = true;
            this.metroDateTimePastBill.CustomFormat = "";
            this.metroDateTimePastBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTimePastBill.Location = new System.Drawing.Point(49, 3);
            this.metroDateTimePastBill.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimePastBill.Name = "metroDateTimePastBill";
            this.metroDateTimePastBill.Size = new System.Drawing.Size(98, 29);
            this.metroDateTimePastBill.TabIndex = 90;
            this.metroDateTimePastBill.Value = new System.DateTime(2016, 5, 20, 0, 0, 0, 0);
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AllowUserToAddRows = false;
            this.dataGridViewBill.AllowUserToDeleteRows = false;
            this.dataGridViewBill.AllowUserToResizeColumns = false;
            this.dataGridViewBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Aquamarine;
            this.dataGridViewBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Status});
            this.dataGridViewBill.Location = new System.Drawing.Point(1, 37);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.ReadOnly = true;
            this.dataGridViewBill.RowHeadersVisible = false;
            this.dataGridViewBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBill.Size = new System.Drawing.Size(441, 221);
            this.dataGridViewBill.TabIndex = 89;
            // 
            // maskedTextBox_Wallet_Id
            // 
            this.maskedTextBox_Wallet_Id.Enabled = false;
            this.maskedTextBox_Wallet_Id.Location = new System.Drawing.Point(370, 34);
            this.maskedTextBox_Wallet_Id.Mask = "0000-0000-000";
            this.maskedTextBox_Wallet_Id.Name = "maskedTextBox_Wallet_Id";
            this.maskedTextBox_Wallet_Id.PromptChar = ' ';
            this.maskedTextBox_Wallet_Id.Size = new System.Drawing.Size(93, 20);
            this.maskedTextBox_Wallet_Id.TabIndex = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BillsCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 56;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 68;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Convenience_fee";
            this.dataGridViewTextBoxColumn4.HeaderText = "Conv fee";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Customer_Fullname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 55;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 62;
            // 
            // History
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 383);
            this.Controls.Add(this.maskedTextBox_Wallet_Id);
            this.Controls.Add(this.metroTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "History";
            this.Resizable = false;
            this.Text = "History";
            this.Load += new System.EventHandler(this.LoadFund_Load);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnsent)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrepaidHistory)).EndInit();
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextRefresh;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonDelete;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonResent;
        public System.Windows.Forms.DataGridView dataGridViewUnsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonRefresh;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Present;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Past;
        private System.Windows.Forms.DataGridView dataGridView_PrepaidHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1Fresh;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTimePresentBill;
        private MetroFramework.Controls.MetroDateTime metroDateTimePastBill;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Wallet_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;


    }
}