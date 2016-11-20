namespace Retailers
{
    partial class Main
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
            this.metroTile_Sender = new MetroFramework.Controls.MetroTile();
            this.metroTile_Reciever = new MetroFramework.Controls.MetroTile();
            this.metroTile_PrepaidCable = new MetroFramework.Controls.MetroTile();
            this.metroTile_Retailers = new MetroFramework.Controls.MetroTile();
            this.metroTileBillsPayment = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile_Sender
            // 
            this.metroTile_Sender.ActiveControl = null;
            this.metroTile_Sender.Location = new System.Drawing.Point(23, 76);
            this.metroTile_Sender.Name = "metroTile_Sender";
            this.metroTile_Sender.Size = new System.Drawing.Size(121, 89);
            this.metroTile_Sender.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile_Sender.TabIndex = 3;
            this.metroTile_Sender.Text = "Sender";
            this.metroTile_Sender.UseSelectable = true;
            this.metroTile_Sender.Click += new System.EventHandler(this.metroTile_Sender_Click);
            // 
            // metroTile_Reciever
            // 
            this.metroTile_Reciever.ActiveControl = null;
            this.metroTile_Reciever.Location = new System.Drawing.Point(23, 171);
            this.metroTile_Reciever.Name = "metroTile_Reciever";
            this.metroTile_Reciever.Size = new System.Drawing.Size(121, 89);
            this.metroTile_Reciever.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_Reciever.TabIndex = 4;
            this.metroTile_Reciever.Text = "Reciever";
            this.metroTile_Reciever.UseSelectable = true;
            this.metroTile_Reciever.Click += new System.EventHandler(this.metroTile_Reciever_Click);
            // 
            // metroTile_PrepaidCable
            // 
            this.metroTile_PrepaidCable.ActiveControl = null;
            this.metroTile_PrepaidCable.Location = new System.Drawing.Point(150, 76);
            this.metroTile_PrepaidCable.Name = "metroTile_PrepaidCable";
            this.metroTile_PrepaidCable.Size = new System.Drawing.Size(121, 89);
            this.metroTile_PrepaidCable.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile_PrepaidCable.TabIndex = 5;
            this.metroTile_PrepaidCable.Text = "Prepaid Cable";
            this.metroTile_PrepaidCable.UseSelectable = true;
            this.metroTile_PrepaidCable.Click += new System.EventHandler(this.metroTile_PrepaidCable_Click);
            // 
            // metroTile_Retailers
            // 
            this.metroTile_Retailers.ActiveControl = null;
            this.metroTile_Retailers.Location = new System.Drawing.Point(23, 266);
            this.metroTile_Retailers.Name = "metroTile_Retailers";
            this.metroTile_Retailers.Size = new System.Drawing.Size(248, 89);
            this.metroTile_Retailers.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile_Retailers.TabIndex = 8;
            this.metroTile_Retailers.Text = "Retailer";
            this.metroTile_Retailers.UseSelectable = true;
            this.metroTile_Retailers.Click += new System.EventHandler(this.metroTile_Retailers_Click);
            // 
            // metroTileBillsPayment
            // 
            this.metroTileBillsPayment.ActiveControl = null;
            this.metroTileBillsPayment.Location = new System.Drawing.Point(150, 171);
            this.metroTileBillsPayment.Name = "metroTileBillsPayment";
            this.metroTileBillsPayment.Size = new System.Drawing.Size(121, 89);
            this.metroTileBillsPayment.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTileBillsPayment.TabIndex = 9;
            this.metroTileBillsPayment.Text = "Bills Payment";
            this.metroTileBillsPayment.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTileBillsPayment.UseSelectable = true;
            this.metroTileBillsPayment.UseTileImage = true;
            this.metroTileBillsPayment.Click += new System.EventHandler(this.metroTileBillsPayment_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(296, 381);
            this.Controls.Add(this.metroTileBillsPayment);
            this.Controls.Add(this.metroTile_Retailers);
            this.Controls.Add(this.metroTile_PrepaidCable);
            this.Controls.Add(this.metroTile_Reciever);
            this.Controls.Add(this.metroTile_Sender);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Main";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile_Sender;
        private MetroFramework.Controls.MetroTile metroTile_Reciever;
        private MetroFramework.Controls.MetroTile metroTile_PrepaidCable;
        private MetroFramework.Controls.MetroTile metroTile_Retailers;
        private MetroFramework.Controls.MetroTile metroTileBillsPayment;
    }
}