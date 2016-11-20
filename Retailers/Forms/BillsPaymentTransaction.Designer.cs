namespace Retailers.Forms
{
    partial class BillsPaymentTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.link_CodeSetting = new MetroFramework.Controls.MetroLink();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime_Present = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime_Past = new MetroFramework.Controls.MetroDateTime();
            this.dataGridView_BillsPaymentTransac = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_Reload = new MetroFramework.Controls.MetroButton();
            this.metroTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillsPaymentTransac)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(976, 351);
            this.metroTabControl.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl.TabIndex = 4;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.link_CodeSetting);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroDateTime_Present);
            this.metroTabPage1.Controls.Add(this.metroDateTime_Past);
            this.metroTabPage1.Controls.Add(this.dataGridView_BillsPaymentTransac);
            this.metroTabPage1.Controls.Add(this.cmd_Reload);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(968, 309);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Transaction";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // link_CodeSetting
            // 
            this.link_CodeSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_CodeSetting.Location = new System.Drawing.Point(4, 9);
            this.link_CodeSetting.Name = "link_CodeSetting";
            this.link_CodeSetting.Size = new System.Drawing.Size(62, 23);
            this.link_CodeSetting.Style = MetroFramework.MetroColorStyle.Silver;
            this.link_CodeSetting.TabIndex = 61;
            this.link_CodeSetting.Text = "Prefix";
            this.link_CodeSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_CodeSetting.UseSelectable = true;
            this.link_CodeSetting.UseStyleColors = true;
            this.link_CodeSetting.Click += new System.EventHandler(this.link_CodeSetting_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(219, 13);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(22, 19);
            this.metroLabel5.TabIndex = 92;
            this.metroLabel5.Text = "To";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(72, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 91;
            this.metroLabel4.Text = "Date :";
            // 
            // metroDateTime_Present
            // 
            this.metroDateTime_Present.AllowDrop = true;
            this.metroDateTime_Present.CustomFormat = "";
            this.metroDateTime_Present.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_Present.Location = new System.Drawing.Point(246, 8);
            this.metroDateTime_Present.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime_Present.Name = "metroDateTime_Present";
            this.metroDateTime_Present.Size = new System.Drawing.Size(98, 29);
            this.metroDateTime_Present.TabIndex = 90;
            this.metroDateTime_Present.Value = new System.DateTime(2016, 5, 20, 0, 0, 0, 0);
            this.metroDateTime_Present.ValueChanged += new System.EventHandler(this.metroDateTime_Present_ValueChanged);
            // 
            // metroDateTime_Past
            // 
            this.metroDateTime_Past.AllowDrop = true;
            this.metroDateTime_Past.CustomFormat = "";
            this.metroDateTime_Past.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_Past.Location = new System.Drawing.Point(118, 8);
            this.metroDateTime_Past.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime_Past.Name = "metroDateTime_Past";
            this.metroDateTime_Past.Size = new System.Drawing.Size(98, 29);
            this.metroDateTime_Past.TabIndex = 89;
            this.metroDateTime_Past.Value = new System.DateTime(2016, 5, 20, 0, 0, 0, 0);
            this.metroDateTime_Past.ValueChanged += new System.EventHandler(this.metroDateTime_Past_ValueChanged);
            // 
            // dataGridView_BillsPaymentTransac
            // 
            this.dataGridView_BillsPaymentTransac.AllowUserToAddRows = false;
            this.dataGridView_BillsPaymentTransac.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_BillsPaymentTransac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_BillsPaymentTransac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BillsPaymentTransac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column2,
            this.dataGridViewTextBoxColumn10,
            this.Discount,
            this.dataGridViewTextBoxColumn11,
            this.Column1,
            this.dataGridViewTextBoxColumn12,
            this.Column3,
            this.Status});
            this.dataGridView_BillsPaymentTransac.Location = new System.Drawing.Point(4, 43);
            this.dataGridView_BillsPaymentTransac.Name = "dataGridView_BillsPaymentTransac";
            this.dataGridView_BillsPaymentTransac.ReadOnly = true;
            this.dataGridView_BillsPaymentTransac.RowHeadersVisible = false;
            this.dataGridView_BillsPaymentTransac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BillsPaymentTransac.Size = new System.Drawing.Size(961, 266);
            this.dataGridView_BillsPaymentTransac.TabIndex = 58;
            this.dataGridView_BillsPaymentTransac.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_BillsPaymentTransac_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 43;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Wallet_Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Wallet_Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 77;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BillsCode";
            this.dataGridViewTextBoxColumn8.HeaderText = "Code";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 57;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Parameter1";
            this.dataGridViewTextBoxColumn9.HeaderText = "Parameter1";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 86;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "Parameter2";
            this.Column2.HeaderText = "Parameter2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 86;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn10.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 68;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Discount.DataPropertyName = "Convenience_fee";
            this.Discount.HeaderText = "Conv fee";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 69;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Ecpaytrackingno";
            this.dataGridViewTextBoxColumn11.HeaderText = "ECPAY Tracking No";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "Customer_Fullname";
            this.Column1.HeaderText = "Customer";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 76;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn12.HeaderText = "Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 55;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "Customer_Number";
            this.Column3.HeaderText = "Customer #";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 79;
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
            // cmd_Reload
            // 
            this.cmd_Reload.Location = new System.Drawing.Point(870, 8);
            this.cmd_Reload.Name = "cmd_Reload";
            this.cmd_Reload.Size = new System.Drawing.Size(95, 29);
            this.cmd_Reload.TabIndex = 57;
            this.cmd_Reload.Text = "Reload Current";
            this.cmd_Reload.UseSelectable = true;
            this.cmd_Reload.Click += new System.EventHandler(this.cmd_Reload_Click);
            // 
            // BillsPaymentTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 431);
            this.Controls.Add(this.metroTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillsPaymentTransaction";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Bills Payment Transaction";
            this.Load += new System.EventHandler(this.BillsPaymentTransaction_Load);
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillsPaymentTransac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Present;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Past;
        public System.Windows.Forms.DataGridView dataGridView_BillsPaymentTransac;
        private MetroFramework.Controls.MetroButton cmd_Reload;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private MetroFramework.Controls.MetroLink link_CodeSetting;

    }
}