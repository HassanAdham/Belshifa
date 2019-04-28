namespace Belshifa2.view
{
    partial class PharmForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOrderBrown = new System.Windows.Forms.Panel();
            this.chckBx = new System.Windows.Forms.CheckBox();
            this.pnlOrderWhite = new System.Windows.Forms.Panel();
            this.pnlMedicines = new System.Windows.Forms.Panel();
            this.lblMedicines = new System.Windows.Forms.Label();
            this.flpMedicines = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPharmacyName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flpOrders.SuspendLayout();
            this.pnlOrderBrown.SuspendLayout();
            this.pnlOrderWhite.SuspendLayout();
            this.pnlMedicines.SuspendLayout();
            this.flpMedicines.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(744, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 2);
            this.panel2.TabIndex = 29;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Brown;
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(774, 32);
            this.pnlTop.TabIndex = 28;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flpOrders);
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 446);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flpOrders
            // 
            this.flpOrders.AutoSize = true;
            this.flpOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.flpOrders.Controls.Add(this.pnlOrderBrown);
            this.flpOrders.Location = new System.Drawing.Point(17, 31);
            this.flpOrders.MaximumSize = new System.Drawing.Size(734, 0);
            this.flpOrders.MinimumSize = new System.Drawing.Size(720, 380);
            this.flpOrders.Name = "flpOrders";
            this.flpOrders.Size = new System.Drawing.Size(720, 380);
            this.flpOrders.TabIndex = 19;
            // 
            // pnlOrderBrown
            // 
            this.pnlOrderBrown.BackColor = System.Drawing.Color.Brown;
            this.pnlOrderBrown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderBrown.Controls.Add(this.chckBx);
            this.pnlOrderBrown.Controls.Add(this.pnlOrderWhite);
            this.pnlOrderBrown.Controls.Add(this.lblOrderID);
            this.pnlOrderBrown.Location = new System.Drawing.Point(8, 8);
            this.pnlOrderBrown.Margin = new System.Windows.Forms.Padding(8);
            this.pnlOrderBrown.Name = "pnlOrderBrown";
            this.pnlOrderBrown.Size = new System.Drawing.Size(222, 363);
            this.pnlOrderBrown.TabIndex = 1;
            // 
            // chckBx
            // 
            this.chckBx.AutoSize = true;
            this.chckBx.BackColor = System.Drawing.Color.Brown;
            this.chckBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chckBx.ForeColor = System.Drawing.Color.Snow;
            this.chckBx.Location = new System.Drawing.Point(130, 5);
            this.chckBx.Name = "chckBx";
            this.chckBx.Size = new System.Drawing.Size(86, 20);
            this.chckBx.TabIndex = 2;
            this.chckBx.Text = "Approve";
            this.chckBx.UseVisualStyleBackColor = false;
           
            // 
            // pnlOrderWhite
            // 
            this.pnlOrderWhite.BackColor = System.Drawing.Color.White;
            this.pnlOrderWhite.Controls.Add(this.pnlMedicines);
            this.pnlOrderWhite.Controls.Add(this.lblEmail);
            this.pnlOrderWhite.Controls.Add(this.lblTotalPrice);
            this.pnlOrderWhite.Controls.Add(this.lblOrderDate);
            this.pnlOrderWhite.Location = new System.Drawing.Point(-1, 29);
            this.pnlOrderWhite.Name = "pnlOrderWhite";
            this.pnlOrderWhite.Size = new System.Drawing.Size(223, 331);
            this.pnlOrderWhite.TabIndex = 1;
            // 
            // pnlMedicines
            // 
            this.pnlMedicines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMedicines.AutoScroll = true;
            this.pnlMedicines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMedicines.Controls.Add(this.lblMedicines);
            this.pnlMedicines.Controls.Add(this.flpMedicines);
            this.pnlMedicines.Location = new System.Drawing.Point(0, 113);
            this.pnlMedicines.Name = "pnlMedicines";
            this.pnlMedicines.Size = new System.Drawing.Size(223, 224);
            this.pnlMedicines.TabIndex = 10;
            // 
            // lblMedicines
            // 
            this.lblMedicines.AutoSize = true;
            this.lblMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicines.Location = new System.Drawing.Point(67, 5);
            this.lblMedicines.Name = "lblMedicines";
            this.lblMedicines.Size = new System.Drawing.Size(73, 15);
            this.lblMedicines.TabIndex = 12;
            this.lblMedicines.Text = "Medicines";
            // 
            // flpMedicines
            // 
            this.flpMedicines.AutoSize = true;
            this.flpMedicines.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMedicines.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpMedicines.Controls.Add(this.lblMedicine);
            this.flpMedicines.Location = new System.Drawing.Point(13, 28);
            this.flpMedicines.MaximumSize = new System.Drawing.Size(185, 0);
            this.flpMedicines.MinimumSize = new System.Drawing.Size(185, 142);
            this.flpMedicines.Name = "flpMedicines";
            this.flpMedicines.Size = new System.Drawing.Size(185, 142);
            this.flpMedicines.TabIndex = 0;
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicine.Location = new System.Drawing.Point(5, 5);
            this.lblMedicine.Margin = new System.Windows.Forms.Padding(5);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(47, 15);
            this.lblMedicine.TabIndex = 13;
            this.lblMedicine.Text = "label9";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(5, 74);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(5, 41);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(76, 15);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(5, 10);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(77, 15);
            this.lblOrderDate.TabIndex = 0;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.White;
            this.lblOrderID.Location = new System.Drawing.Point(3, 7);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(66, 16);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Brown;
            this.panel12.Controls.Add(this.btnSignOut);
            this.panel12.Controls.Add(this.lblUsername);
            this.panel12.Controls.Add(this.lblPharmacyName);
            this.panel12.Controls.Add(this.pictureBox2);
            this.panel12.Controls.Add(this.pictureBox1);
            this.panel12.Location = new System.Drawing.Point(0, 34);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(774, 39);
            this.panel12.TabIndex = 31;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Brown;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(575, 0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(99, 39);
            this.btnSignOut.TabIndex = 13;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(13, 7);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 24);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Username";
            // 
            // lblPharmacyName
            // 
            this.lblPharmacyName.AutoSize = true;
            this.lblPharmacyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacyName.ForeColor = System.Drawing.Color.White;
            this.lblPharmacyName.Location = new System.Drawing.Point(296, 7);
            this.lblPharmacyName.Name = "lblPharmacyName";
            this.lblPharmacyName.Size = new System.Drawing.Size(150, 24);
            this.lblPharmacyName.TabIndex = 15;
            this.lblPharmacyName.Text = "Pharmacy Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Belshifa2.Properties.Resources.images1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(728, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 40);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Belshifa2.Properties.Resources.images__11_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(680, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // PharmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(774, 512);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(774, 512);
            this.Name = "PharmForm";
            this.Text = "PharmForm";
            this.Load += new System.EventHandler(this.PharmForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpOrders.ResumeLayout(false);
            this.pnlOrderBrown.ResumeLayout(false);
            this.pnlOrderBrown.PerformLayout();
            this.pnlOrderWhite.ResumeLayout(false);
            this.pnlOrderWhite.PerformLayout();
            this.pnlMedicines.ResumeLayout(false);
            this.pnlMedicines.PerformLayout();
            this.flpMedicines.ResumeLayout(false);
            this.flpMedicines.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpOrders;
        private System.Windows.Forms.Panel pnlOrderBrown;
        private System.Windows.Forms.Panel pnlOrderWhite;
        private System.Windows.Forms.Panel pnlMedicines;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPharmacyName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chckBx;
        private System.Windows.Forms.Label lblMedicines;
        private System.Windows.Forms.FlowLayoutPanel flpMedicines;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblOrderDate;
    }
}