namespace Retailers.Forms
{
    partial class SenderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenderForm));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.chkReceived = new System.Windows.Forms.CheckBox();
            this.lblReceived = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 278);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Sent: ";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.BackColor = System.Drawing.Color.Red;
            this.metroTextButton2.Enabled = false;
            this.metroTextButton2.Image = null;
            this.metroTextButton2.Location = new System.Drawing.Point(89, 117);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(60, 23);
            this.metroTextButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButton2.TabIndex = 10;
            this.metroTextButton2.Text = "Close";
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseVisualStyleBackColor = false;
            this.metroTextButton2.Click += new System.EventHandler(this.metroTextButton2_Click);
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(23, 117);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(60, 23);
            this.metroTextButton1.TabIndex = 9;
            this.metroTextButton1.Text = "Open";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(23, 82);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(122, 29);
            this.metroComboBox1.TabIndex = 8;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Ports";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(151, 82);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(126, 29);
            this.metroComboBox2.TabIndex = 14;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(151, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Network";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.richTextBox1.Location = new System.Drawing.Point(23, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(254, 114);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(61, 278);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.UseStyleColors = true;
            // 
            // chkReceived
            // 
            this.chkReceived.AutoSize = true;
            this.chkReceived.Checked = true;
            this.chkReceived.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReceived.Location = new System.Drawing.Point(25, 143);
            this.chkReceived.Name = "chkReceived";
            this.chkReceived.Size = new System.Drawing.Size(108, 17);
            this.chkReceived.TabIndex = 17;
            this.chkReceived.Text = "Enable Received";
            this.chkReceived.UseVisualStyleBackColor = true;
            this.chkReceived.CheckedChanged += new System.EventHandler(this.chkReceived_CheckedChanged);
            // 
            // lblReceived
            // 
            this.lblReceived.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblReceived.Location = new System.Drawing.Point(224, 278);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(53, 19);
            this.lblReceived.Style = MetroFramework.MetroColorStyle.Brown;
            this.lblReceived.TabIndex = 19;
            this.lblReceived.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(156, 279);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(74, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Received:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(157, 140);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(117, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Text Limit Count";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txtLimit
            // 
            this.txtLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimit.Location = new System.Drawing.Point(173, 116);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(85, 26);
            this.txtLimit.TabIndex = 21;
            this.txtLimit.Text = "2000";
            this.txtLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 312);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblReceived);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.chkReceived);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextButton2);
            this.Controls.Add(this.metroTextButton1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SenderForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Sender";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SenderForm_FormClosed);
            this.Load += new System.EventHandler(this.SenderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.CheckBox chkReceived;
        private MetroFramework.Controls.MetroLabel lblReceived;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txtLimit;
    }
}