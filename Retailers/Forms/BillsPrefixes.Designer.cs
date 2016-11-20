namespace Retailers.Forms
{
    partial class BillsPrefixes
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
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.cmd_AddPrefix = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxBillerTag = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView_BillsPrefix = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_Reload = new MetroFramework.Controls.MetroButton();
            this.metroTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillsPrefix)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(1093, 490);
            this.metroTabControl.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl.TabIndex = 5;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cmd_AddPrefix);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroTextBoxBillerTag);
            this.metroTabPage1.Controls.Add(this.dataGridView_BillsPrefix);
            this.metroTabPage1.Controls.Add(this.cmd_Reload);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1085, 448);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Data";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // cmd_AddPrefix
            // 
            this.cmd_AddPrefix.Location = new System.Drawing.Point(961, 8);
            this.cmd_AddPrefix.Name = "cmd_AddPrefix";
            this.cmd_AddPrefix.Size = new System.Drawing.Size(59, 29);
            this.cmd_AddPrefix.TabIndex = 93;
            this.cmd_AddPrefix.Text = "Add";
            this.cmd_AddPrefix.UseSelectable = true;
            this.cmd_AddPrefix.Click += new System.EventHandler(this.cmd_AddPrefix_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 17);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 92;
            this.metroLabel4.Text = "BillerTag :";
            // 
            // metroTextBoxBillerTag
            // 
            // 
            // 
            // 
            this.metroTextBoxBillerTag.CustomButton.Image = null;
            this.metroTextBoxBillerTag.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.metroTextBoxBillerTag.CustomButton.Name = "";
            this.metroTextBoxBillerTag.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBoxBillerTag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxBillerTag.CustomButton.TabIndex = 1;
            this.metroTextBoxBillerTag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxBillerTag.CustomButton.UseSelectable = true;
            this.metroTextBoxBillerTag.CustomButton.Visible = false;
            this.metroTextBoxBillerTag.Lines = new string[0];
            this.metroTextBoxBillerTag.Location = new System.Drawing.Point(82, 17);
            this.metroTextBoxBillerTag.MaxLength = 32767;
            this.metroTextBoxBillerTag.Name = "metroTextBoxBillerTag";
            this.metroTextBoxBillerTag.PasswordChar = '\0';
            this.metroTextBoxBillerTag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBillerTag.SelectedText = "";
            this.metroTextBoxBillerTag.SelectionLength = 0;
            this.metroTextBoxBillerTag.SelectionStart = 0;
            this.metroTextBoxBillerTag.ShortcutsEnabled = true;
            this.metroTextBoxBillerTag.Size = new System.Drawing.Size(196, 20);
            this.metroTextBoxBillerTag.TabIndex = 59;
            this.metroTextBoxBillerTag.UseSelectable = true;
            this.metroTextBoxBillerTag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxBillerTag.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxBillerTag.TextChanged += new System.EventHandler(this.metroTextBoxBillerTag_TextChanged);
            this.metroTextBoxBillerTag.Click += new System.EventHandler(this.metroTextBoxBillerTag_Click);
            // 
            // dataGridView_BillsPrefix
            // 
            this.dataGridView_BillsPrefix.AllowUserToAddRows = false;
            this.dataGridView_BillsPrefix.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_BillsPrefix.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_BillsPrefix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BillsPrefix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Status,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView_BillsPrefix.Location = new System.Drawing.Point(4, 43);
            this.dataGridView_BillsPrefix.Name = "dataGridView_BillsPrefix";
            this.dataGridView_BillsPrefix.ReadOnly = true;
            this.dataGridView_BillsPrefix.RowHeadersVisible = false;
            this.dataGridView_BillsPrefix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BillsPrefix.Size = new System.Drawing.Size(1082, 402);
            this.dataGridView_BillsPrefix.TabIndex = 58;
            this.dataGridView_BillsPrefix.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_BillsPrefix_CellContentDoubleClick);
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Categorycode";
            this.dataGridViewTextBoxColumn9.HeaderText = "Category Code";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 94;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BillerTag";
            this.dataGridViewTextBoxColumn7.HeaderText = "Biller Tag";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 85;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Status.DataPropertyName = "ServiceCharge";
            this.Status.HeaderText = "Service Charge";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 96;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "FirstField";
            this.Column1.HeaderText = "FirstField";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 73;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "FirstFieldFormat";
            this.Column2.HeaderText = "FirstField Format";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 99;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "FirstFieldWidth";
            this.Column3.HeaderText = "FirstField Width";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 96;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.DataPropertyName = "SecondField";
            this.Column4.HeaderText = "SecondField";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 91;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.DataPropertyName = "SecondFieldFormat";
            this.Column5.HeaderText = "SecondField Format";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 115;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.DataPropertyName = "SecondFieldWidth";
            this.Column6.HeaderText = "SecondField Width";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 112;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Lastupdated";
            this.dataGridViewTextBoxColumn12.HeaderText = "Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 55;
            // 
            // cmd_Reload
            // 
            this.cmd_Reload.Location = new System.Drawing.Point(1026, 8);
            this.cmd_Reload.Name = "cmd_Reload";
            this.cmd_Reload.Size = new System.Drawing.Size(59, 29);
            this.cmd_Reload.TabIndex = 57;
            this.cmd_Reload.Text = "Reload";
            this.cmd_Reload.UseSelectable = true;
            this.cmd_Reload.Click += new System.EventHandler(this.cmd_Reload_Click);
            // 
            // BillsPrefixes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 570);
            this.Controls.Add(this.metroTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillsPrefixes";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Bills Prefixes";
            this.Load += new System.EventHandler(this.BillsPrefix_Load);
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillsPrefix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        public System.Windows.Forms.DataGridView dataGridView_BillsPrefix;
        private MetroFramework.Controls.MetroButton cmd_Reload;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBillerTag;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private MetroFramework.Controls.MetroButton cmd_AddPrefix;
    }
}