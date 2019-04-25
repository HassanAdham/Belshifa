namespace Belshifa2.view
{
    partial class ProfileForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tbPgHistory = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblReply = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtPickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cmbBxPayment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPgCart = new System.Windows.Forms.TabPage();
            this.btnOrder = new System.Windows.Forms.Button();
            this.flpCart = new System.Windows.Forms.FlowLayoutPanel();
            this.item = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picBx = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPgUnApproved = new System.Windows.Forms.TabPage();
            this.flpUnapproved = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.flpHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.tbPgHistory.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbPgCart.SuspendLayout();
            this.flpCart.SuspendLayout();
            this.item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).BeginInit();
            this.tbPgUnApproved.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Snow;
            this.btnClose.Location = new System.Drawing.Point(695, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Brown;
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Location = new System.Drawing.Point(0, -1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(729, 32);
            this.pnlTop.TabIndex = 25;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // tbPgHistory
            // 
            this.tbPgHistory.Controls.Add(this.tabPage1);
            this.tbPgHistory.Controls.Add(this.tbPgCart);
            this.tbPgHistory.Controls.Add(this.tbPgUnApproved);
            this.tbPgHistory.Controls.Add(this.tabPage4);
            this.tbPgHistory.Location = new System.Drawing.Point(0, 37);
            this.tbPgHistory.Name = "tbPgHistory";
            this.tbPgHistory.SelectedIndex = 0;
            this.tbPgHistory.Size = new System.Drawing.Size(726, 437);
            this.tbPgHistory.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblReply);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.dtPickerBirthdate);
            this.tabPage1.Controls.Add(this.cmbBxPayment);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtBxAddress);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtBxPhone);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtBxPassword);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.txtBxLastName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBxFName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblReply
            // 
            this.lblReply.AutoSize = true;
            this.lblReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReply.ForeColor = System.Drawing.Color.Brown;
            this.lblReply.Location = new System.Drawing.Point(75, 51);
            this.lblReply.Name = "lblReply";
            this.lblReply.Size = new System.Drawing.Size(48, 18);
            this.lblReply.TabIndex = 66;
            this.lblReply.Text = "Reply!";
            this.lblReply.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.Location = new System.Drawing.Point(668, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 35);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "D";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Brown;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Snow;
            this.btnEdit.Location = new System.Drawing.Point(398, 335);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 52);
            this.btnEdit.TabIndex = 64;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtPickerBirthdate
            // 
            this.dtPickerBirthdate.Enabled = false;
            this.dtPickerBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtPickerBirthdate.Location = new System.Drawing.Point(102, 358);
            this.dtPickerBirthdate.MaxDate = new System.DateTime(2019, 4, 24, 0, 0, 0, 0);
            this.dtPickerBirthdate.Name = "dtPickerBirthdate";
            this.dtPickerBirthdate.Size = new System.Drawing.Size(197, 29);
            this.dtPickerBirthdate.TabIndex = 63;
            this.dtPickerBirthdate.Value = new System.DateTime(2007, 4, 24, 0, 0, 0, 0);
            // 
            // cmbBxPayment
            // 
            this.cmbBxPayment.Enabled = false;
            this.cmbBxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmbBxPayment.FormattingEnabled = true;
            this.cmbBxPayment.Items.AddRange(new object[] {
            "Cash",
            "Visa"});
            this.cmbBxPayment.Location = new System.Drawing.Point(102, 270);
            this.cmbBxPayment.Name = "cmbBxPayment";
            this.cmbBxPayment.Size = new System.Drawing.Size(197, 32);
            this.cmbBxPayment.TabIndex = 62;
            this.cmbBxPayment.Text = "Cash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(99, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Birthdate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(99, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Payment";
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Enabled = false;
            this.txtBxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBxAddress.Location = new System.Drawing.Point(102, 198);
            this.txtBxAddress.Multiline = true;
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(197, 30);
            this.txtBxAddress.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(99, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Address";
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Enabled = false;
            this.txtBxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBxPhone.Location = new System.Drawing.Point(386, 270);
            this.txtBxPhone.Multiline = true;
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(197, 30);
            this.txtBxPhone.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(383, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Phone";
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Enabled = false;
            this.txtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBxPassword.Location = new System.Drawing.Point(386, 207);
            this.txtBxPassword.Multiline = true;
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(197, 30);
            this.txtBxPassword.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(383, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Brown;
            this.lblEmail.Location = new System.Drawing.Point(61, 23);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 53;
            this.lblEmail.Text = "Email";
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Enabled = false;
            this.txtBxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBxLastName.Location = new System.Drawing.Point(386, 130);
            this.txtBxLastName.Multiline = true;
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(197, 30);
            this.txtBxLastName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(383, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Last Name";
            // 
            // txtBxFName
            // 
            this.txtBxFName.Enabled = false;
            this.txtBxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBxFName.Location = new System.Drawing.Point(102, 121);
            this.txtBxFName.Multiline = true;
            this.txtBxFName.Name = "txtBxFName";
            this.txtBxFName.Size = new System.Drawing.Size(197, 30);
            this.txtBxFName.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(99, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "First Name";
            // 
            // tbPgCart
            // 
            this.tbPgCart.Controls.Add(this.btnOrder);
            this.tbPgCart.Controls.Add(this.flpCart);
            this.tbPgCart.Controls.Add(this.label3);
            this.tbPgCart.Location = new System.Drawing.Point(4, 22);
            this.tbPgCart.Name = "tbPgCart";
            this.tbPgCart.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgCart.Size = new System.Drawing.Size(718, 411);
            this.tbPgCart.TabIndex = 1;
            this.tbPgCart.Text = "tabPage2";
            this.tbPgCart.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Brown;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Snow;
            this.btnOrder.Location = new System.Drawing.Point(419, 335);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(180, 52);
            this.btnOrder.TabIndex = 65;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // flpCart
            // 
            this.flpCart.AutoScroll = true;
            this.flpCart.Controls.Add(this.item);
            this.flpCart.Location = new System.Drawing.Point(92, 77);
            this.flpCart.MaximumSize = new System.Drawing.Size(551, 0);
            this.flpCart.MinimumSize = new System.Drawing.Size(0, 252);
            this.flpCart.Name = "flpCart";
            this.flpCart.Size = new System.Drawing.Size(551, 252);
            this.flpCart.TabIndex = 55;
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.Gainsboro;
            this.item.Controls.Add(this.numericUpDown1);
            this.item.Controls.Add(this.btnRemove);
            this.item.Controls.Add(this.lblPrice);
            this.item.Controls.Add(this.lblName);
            this.item.Controls.Add(this.picBx);
            this.item.Location = new System.Drawing.Point(5, 5);
            this.item.Margin = new System.Windows.Forms.Padding(5);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(541, 79);
            this.item.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(264, 31);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown1.TabIndex = 67;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Brown;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Snow;
            this.btnRemove.Location = new System.Drawing.Point(500, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(38, 24);
            this.btnRemove.TabIndex = 66;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Brown;
            this.lblPrice.Location = new System.Drawing.Point(410, 33);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 18);
            this.lblPrice.TabIndex = 30;
            this.lblPrice.Text = "Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Brown;
            this.lblName.Location = new System.Drawing.Point(125, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name";
            // 
            // picBx
            // 
            this.picBx.BackColor = System.Drawing.Color.Gray;
            this.picBx.Location = new System.Drawing.Point(19, 9);
            this.picBx.Name = "picBx";
            this.picBx.Size = new System.Drawing.Size(80, 60);
            this.picBx.TabIndex = 0;
            this.picBx.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(61, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Cart";
            // 
            // tbPgUnApproved
            // 
            this.tbPgUnApproved.Controls.Add(this.flpUnapproved);
            this.tbPgUnApproved.Controls.Add(this.label8);
            this.tbPgUnApproved.Location = new System.Drawing.Point(4, 22);
            this.tbPgUnApproved.Name = "tbPgUnApproved";
            this.tbPgUnApproved.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgUnApproved.Size = new System.Drawing.Size(718, 411);
            this.tbPgUnApproved.TabIndex = 2;
            this.tbPgUnApproved.Text = "tabPage3";
            this.tbPgUnApproved.UseVisualStyleBackColor = true;
            // 
            // flpUnapproved
            // 
            this.flpUnapproved.Location = new System.Drawing.Point(92, 77);
            this.flpUnapproved.Name = "flpUnapproved";
            this.flpUnapproved.Size = new System.Drawing.Size(544, 242);
            this.flpUnapproved.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(61, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "Un Approved Orders";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.flpHistory);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(718, 411);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // flpHistory
            // 
            this.flpHistory.Location = new System.Drawing.Point(92, 77);
            this.flpHistory.Name = "flpHistory";
            this.flpHistory.Size = new System.Drawing.Size(544, 242);
            this.flpHistory.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(61, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 58;
            this.label9.Text = "History";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 473);
            this.Controls.Add(this.tbPgHistory);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.tbPgHistory.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbPgCart.ResumeLayout(false);
            this.tbPgCart.PerformLayout();
            this.flpCart.ResumeLayout(false);
            this.item.ResumeLayout(false);
            this.item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).EndInit();
            this.tbPgUnApproved.ResumeLayout(false);
            this.tbPgUnApproved.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TabControl tbPgHistory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dtPickerBirthdate;
        private System.Windows.Forms.ComboBox cmbBxPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbPgCart;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.FlowLayoutPanel flpCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbPgUnApproved;
        private System.Windows.Forms.FlowLayoutPanel flpUnapproved;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FlowLayoutPanel flpHistory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReply;
        private System.Windows.Forms.Panel item;
        private System.Windows.Forms.PictureBox picBx;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
    }
}