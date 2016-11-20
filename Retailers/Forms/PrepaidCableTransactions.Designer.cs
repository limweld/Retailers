namespace Retailers.Forms
{
    partial class PrepaidCableTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView_PCTransac = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_Reload = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime_Present = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime_Past = new MetroFramework.Controls.MetroDateTime();
            this.metroTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PCTransac)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(918, 368);
            this.metroTabControl.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl.TabIndex = 3;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroDateTime_Present);
            this.metroTabPage1.Controls.Add(this.metroDateTime_Past);
            this.metroTabPage1.Controls.Add(this.dataGridView_PCTransac);
            this.metroTabPage1.Controls.Add(this.cmd_Reload);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(910, 326);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Transaction";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // dataGridView_PCTransac
            // 
            this.dataGridView_PCTransac.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Thistle;
            this.dataGridView_PCTransac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_PCTransac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PCTransac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Discount,
            this.dataGridViewTextBoxColumn11,
            this.Column1,
            this.dataGridViewTextBoxColumn12,
            this.Status});
            this.dataGridView_PCTransac.Location = new System.Drawing.Point(4, 43);
            this.dataGridView_PCTransac.Name = "dataGridView_PCTransac";
            this.dataGridView_PCTransac.ReadOnly = true;
            this.dataGridView_PCTransac.RowHeadersVisible = false;
            this.dataGridView_PCTransac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PCTransac.Size = new System.Drawing.Size(903, 287);
            this.dataGridView_PCTransac.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 43;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Wallet_Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Wallet_Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn8.HeaderText = "Code";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Box_number";
            this.dataGridViewTextBoxColumn9.HeaderText = "Box_Number";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn10.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Pin";
            this.dataGridViewTextBoxColumn11.HeaderText = "Pin";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Customer_number";
            this.Column1.HeaderText = "Customer Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn12.HeaderText = "Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
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
            this.cmd_Reload.Location = new System.Drawing.Point(812, 8);
            this.cmd_Reload.Name = "cmd_Reload";
            this.cmd_Reload.Size = new System.Drawing.Size(95, 29);
            this.cmd_Reload.TabIndex = 57;
            this.cmd_Reload.Text = "Reload";
            this.cmd_Reload.UseSelectable = true;
            this.cmd_Reload.Click += new System.EventHandler(this.cmd_Reload_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(151, 13);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(22, 19);
            this.metroLabel5.TabIndex = 92;
            this.metroLabel5.Text = "To";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 13);
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
            this.metroDateTime_Present.Location = new System.Drawing.Point(178, 8);
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
            this.metroDateTime_Past.Location = new System.Drawing.Point(50, 8);
            this.metroDateTime_Past.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime_Past.Name = "metroDateTime_Past";
            this.metroDateTime_Past.Size = new System.Drawing.Size(98, 29);
            this.metroDateTime_Past.TabIndex = 89;
            this.metroDateTime_Past.Value = new System.DateTime(2016, 5, 20, 0, 0, 0, 0);
            this.metroDateTime_Past.ValueChanged += new System.EventHandler(this.metroDateTime_Past_ValueChanged);
            // 
            // PrepaidCableTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 448);
            this.Controls.Add(this.metroTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrepaidCableTransactions";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "PrepaidCableTransactions";
            this.Load += new System.EventHandler(this.PrepaidCableTransactions_Load);
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PCTransac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dataGridView_PCTransac;
        private MetroFramework.Controls.MetroButton cmd_Reload;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Present;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Past;
    }
}