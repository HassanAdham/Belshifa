using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Belshifa2.dataClasses;
using Belshifa2.model;

namespace Belshifa2.view
{
    public partial class ProfileForm : Form
    {
        SystemDatabase dbObj;
        Patient patient;
        CurrentPatient currentPatient;

        public ProfileForm()
        {
            InitializeComponent();
            currentPatient = new CurrentPatient();
            dbObj = new SystemDatabase();

            dtPickerBirthdate.Format = DateTimePickerFormat.Custom;
            dtPickerBirthdate.CustomFormat = "dd-MMM-yyyy";

            //If there is a patient in the CurrentPatient class. then someone is signed in.
            patient = currentPatient.get_currentUser();
            if (patient != null)
            {
                lblEmail.Text = patient.get_email();
                txtBxAddress.Text = patient.get_address();
                txtBxFName.Text = patient.get_f_name();
                txtBxLastName.Text = patient.get_l_name();
                txtBxPassword.Text = patient.get_password();
                txtBxPhone.Text = patient.get_phone();
                cmbBxPayment.Text = patient.get_payment();
                dtPickerBirthdate.Text = patient.get_birthdate();
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            displayCart();
            displayPending();
            displayHistory();
        }

        /*Looping through lists*/
        private void displayCart()
        {
            flpCart.Controls.Clear();
            Dictionary<int,MedicineInfo> cart = currentPatient.get_cart();
            foreach(KeyValuePair<int, MedicineInfo> item in cart)
            {
                create_item_To_Cart(item);
            }
        }
        private void displayPending()
        {
            List<Order> pending = dbObj.getPatientPendingOrders(currentPatient.get_currentUser().get_email());
            flpUnapproved.Controls.Clear();
            foreach (Order order in pending)
            {
                create_item_To_Pending(order);
            }
        } //it is pending list.
        private void displayHistory()
        {
            flpHistory.Controls.Clear();
            List<Order> historyList = dbObj.getOrderHistory(currentPatient.get_currentUser().get_email());
            foreach (Order order in historyList)
            {
                create_item_to_history(order);
            }
        }

        /*Creating Controls*/
        private void create_item_To_Cart(KeyValuePair<int, MedicineInfo> itm)
        {
            Panel item = new Panel();
            PictureBox picBx = new PictureBox();
            Label lblName = new Label();
            Label lblPrice = new Label();
            Button btnRemove = new Button();
            NumericUpDown numericUpDown1 = new NumericUpDown();

            // 
            // item
            // 
            item.BackColor = Color.Gainsboro;
            item.Controls.Add(numericUpDown1);
            item.Controls.Add(btnRemove);
            item.Controls.Add(lblPrice);
            item.Controls.Add(lblName);
            item.Controls.Add(picBx);
            item.Location = new Point(5, 5);
            item.Margin = new System.Windows.Forms.Padding(5);
            item.Name = "item";
            item.Size = new Size(541, 79);
            item.TabIndex = 0;
            // 
            // picBx
            // 
            picBx.BackColor = Color.Gray;
            picBx.Location = new Point(19, 9);
            picBx.Name = "picBx";
            picBx.Size = new Size(80, 60);
            picBx.TabIndex = 0;
            picBx.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblPrice.ForeColor = Color.Brown;
            lblPrice.Location = new Point(410, 33);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(42, 18);
            lblPrice.TabIndex = 30;
            lblPrice.Text = (itm.Value.get_quantity() * itm.Value.get_price()).ToString();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblName.ForeColor = Color.Brown;
            lblName.Location = new Point(125, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 18);
            lblName.TabIndex = 29;
            lblName.Text = itm.Value.get_name();
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Brown;
            btnRemove.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btnRemove.ForeColor = Color.Snow;
            btnRemove.Location = new Point(500, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(38, 24);
            btnRemove.TabIndex = 66;
            btnRemove.Text = "-";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += delegate
            {
                remove_item(itm.Key);
                flpCart.Controls.Remove(item);
            };
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(264, 31);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Value = itm.Value.get_quantity();
            numericUpDown1.Size = new Size(63, 20);
            numericUpDown1.TabIndex = 67;
            numericUpDown1.Minimum = 1;
            numericUpDown1.ValueChanged += delegate
            {
                lblPrice.Text = ((float)numericUpDown1.Value * itm.Value.get_price()).ToString();
                itm.Value.set_quantity(int.Parse(numericUpDown1.Value.ToString()));
            };
            flpCart.Controls.Add(item);
        }
        private void create_item_To_Pending(Order order)
        {
            Panel item = new Panel();
            Label lblId = new Label();
            Label lblPrice = new Label();
            Label lblOrderDate = new Label();
            // 
            // item
            // 
            item.BackColor = Color.Gainsboro;
            item.Controls.Add(lblPrice);
            item.Controls.Add(lblId);
            item.Controls.Add(lblOrderDate);
            item.Location = new Point(5, 5);
            item.Margin = new System.Windows.Forms.Padding(5);
            item.Name = "item";
            item.Size = new Size(541, 33);
            item.TabIndex = 0;

            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblPrice.ForeColor = Color.Brown;
            lblPrice.Location = new Point(281, 9);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(42, 18);
            lblPrice.TabIndex = 30;
            lblPrice.Text = order.get_totalPrice().ToString();
            // 
            // lblName
            // 
            lblId.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblId.ForeColor = Color.Brown;
            lblId.Location = new Point(22, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(48, 18);
            lblId.TabIndex = 29;
            lblId.Text = order.get_orderId().ToString();

            // 
            // lblOrderDate
            // 
            lblOrderDate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblOrderDate.ForeColor = Color.Brown;
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(133, 9);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.TabIndex = 29;
            lblOrderDate.Text = order.get_orderDate();


            flpUnapproved.Controls.Add(item);
        }
        private void create_item_to_history(Order order)
        {
            Label lblPharmacist = new Label();
            Label lblHPrice = new Label();
            Label lblHid = new Label();
            Label lbldd = new Label();
            Label lblod = new Label();
            Label lblPharmacy = new Label();
            Panel orderPanel = new Panel();
            // 
            // lblPharmacist
            // 
            lblPharmacist.AutoSize = true;
            lblPharmacist.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblPharmacist.ForeColor = Color.Brown;
            lblPharmacist.Location = new Point(387, 9);
            lblPharmacist.Name = "lblPharmacist";
            lblPharmacist.Size = new Size(83, 18);
            lblPharmacist.TabIndex = 70;
            lblPharmacist.Text = order.get_ph_username();
            // 
            // lblHPrice
            // 
            lblHPrice.AutoSize = true;
            lblHPrice.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblHPrice.ForeColor = Color.Brown;
            lblHPrice.Location = new Point(491, 9);
            lblHPrice.Name = "lblHPrice";
            lblHPrice.Size = new Size(42, 18);
            lblHPrice.TabIndex = 71;
            lblHPrice.Text = order.get_totalPrice().ToString();

            // 
            // lblod
            // 
            lblod.AutoSize = true;
            lblod.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblod.ForeColor = Color.Brown;
            lblod.Location = new Point(53, 9);
            lblod.Name = "lblod";
            lblod.Size = new Size(77, 18);
            lblod.TabIndex = 67;
            lblod.Text = order.get_orderDate();
            // 
            // lbldd
            // 
            lbldd.AutoSize = true;
            lbldd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbldd.ForeColor = Color.Brown;
            lbldd.Location = new Point(162, 9);
            lbldd.Name = "lbldd";
            lbldd.Size = new Size(91, 18);
            lbldd.TabIndex = 30;
            lbldd.Text = order.get_deliveryDate();
            // 
            // lblHid
            // 
            lblHid.AutoSize = true;
            lblHid.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblHid.ForeColor = Color.Brown;
            lblHid.Location = new Point(13, 9);
            lblHid.Name = "lblHid";
            lblHid.Size = new Size(22, 18);
            lblHid.TabIndex = 29;
            lblHid.Text = order.get_orderId().ToString();

            // 
            // lblPharmacy
            // 
            lblPharmacy.AutoSize = true;
            lblPharmacy.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblPharmacy.ForeColor = Color.Brown;
            lblPharmacy.Location = new Point(286, 9);
            lblPharmacy.Name = "lblPharmacy";
            lblPharmacy.Size = new Size(75, 18);
            lblPharmacy.TabIndex = 68;
            lblPharmacy.Text = order.get_patient_email(); //Pharmacy name is passed here.

            // 
            // panel4
            // 
            orderPanel.BackColor = Color.Gainsboro;
            orderPanel.Controls.Add(lblHPrice);
            orderPanel.Controls.Add(lblPharmacist);
            orderPanel.Controls.Add(lblPharmacy);
            orderPanel.Controls.Add(lblod);
            orderPanel.Controls.Add(lbldd);
            orderPanel.Controls.Add(lblHid);
            orderPanel.Location = new Point(5, 5);
            orderPanel.Margin = new System.Windows.Forms.Padding(5);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(541, 33);
            orderPanel.TabIndex = 1;

            flpHistory.Controls.Add(orderPanel);
        }
        
        /*Remove from cart*/
        private void remove_item(int id)
        {
            currentPatient.removeFromCart(id);
        }

        /*Update Profile*/
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(btnEdit.Text == "Edit")
            {
                txtBxPhone.Enabled = true;
                txtBxPassword.Enabled = true;
                txtBxFName.Enabled = true;
                txtBxAddress.Enabled = true;
                txtBxLastName.Enabled = true;
                cmbBxPayment.Enabled = true;
                dtPickerBirthdate.Enabled = true;

                btnEdit.Text = "Save";
            }
            else
            {
                txtBxPhone.Enabled = false;
                txtBxPassword.Enabled = false;
                txtBxFName.Enabled = false;
                txtBxAddress.Enabled = false;
                txtBxLastName.Enabled = false;
                cmbBxPayment.Enabled = false;
                dtPickerBirthdate.Enabled = false;

                btnEdit.Text = "Edit";
                Patient editedPatient = new Patient(txtBxFName.Text, txtBxLastName.Text,
                                                    txtBxPassword.Text, txtBxAddress.Text,
                                                    txtBxPhone.Text, patient.get_email(),
                                                    cmbBxPayment.Text, dtPickerBirthdate.Text);
                lblReply.Text = dbObj.updateProfile(editedPatient);
                lblReply.Visible = true;
            }
        }
        /*Delete Account*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbObj.deleteAccount(patient.get_email());
            currentPatient.signOut();
            this.Close();
        }


        //-------------------------------------Form---------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblOrderReply.Visible = true;
            if (currentPatient.get_cart().Count > 0)
            {
                bool is_recorded = dbObj.makeOrder(currentPatient.get_currentUser().get_email(),
                                    currentPatient.get_currentUser().get_address(),
                                    currentPatient.get_cart());
                if (is_recorded == true)
                {
                    lblOrderReply.Text = "Order has been recorded!\nPlease wait for an approval!";
                    flpCart.Controls.Clear();
                    currentPatient.clearCart();
                }
                else
                    lblOrderReply.Text = "Your order is not available\nin any pharmacy!";
            }
            else
                lblOrderReply.Text = "Please add items to your cart!";
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.Snow;
            btnCart.BackColor = Color.Brown;
            btnApproved.BackColor = Color.Brown;
            btnPending.BackColor = Color.Brown;


            btnProfile.ForeColor = Color.Brown;
            btnCart.ForeColor = Color.Snow;
            btnApproved.ForeColor = Color.Snow;
            btnPending.ForeColor = Color.Snow;
            tbControl.SelectTab(0);
        }
        private void btnPending_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.Brown;
            btnCart.BackColor = Color.Brown;
            btnApproved.BackColor = Color.Brown;
            btnPending.BackColor = Color.White;


            btnProfile.ForeColor = Color.Snow;
            btnCart.ForeColor = Color.Snow;
            btnApproved.ForeColor = Color.Snow;
            btnPending.ForeColor = Color.Brown;

            tbControl.SelectTab(2);


            //string PHName = dbObj.getpharmacistunamefromOrder();
            //if(PHName != null)
            //{ 
            //   MessageBox.Show(PHName + "Has Approved Your Order Please Confirm The Approval To Continue The Process of Ordering");
            //   // 
            //   // button1
            //   // 
            //   Button Confirm = new Button();
            //   Confirm.Location = new System.Drawing.Point(281, 17);
            //   Confirm.Name = "button1";
            //   Confirm.Size = new System.Drawing.Size(75, 23);
            //   Confirm.TabIndex = 67;
            //   Confirm.Text = "Confirm";
            //   Confirm.UseVisualStyleBackColor = true;           
            //   Confirm.Click += new EventHandler(button1_Click);
            //   if (btnisclicked)
            //   {
            //       MessageBox.Show("You've Confirmed The Order, Thank You, You will Recieve Your Order in 3 Days");                  
            //   }
            //   displayHistory();
            //}

        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.Brown;
            btnCart.BackColor = Color.Snow;
            btnApproved.BackColor = Color.Brown;
            btnPending.BackColor = Color.Brown;

            btnProfile.ForeColor = Color.Snow;
            btnCart.ForeColor = Color.Brown;
            btnApproved.ForeColor = Color.Snow;
            btnPending.ForeColor = Color.Snow;

            tbControl.SelectTab(1);
        }
        private void btnApproved_Click(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.Brown;
            btnCart.BackColor = Color.Brown;
            btnApproved.BackColor = Color.White;
            btnPending.BackColor = Color.Brown;


            btnProfile.ForeColor = Color.Snow;
            btnCart.ForeColor = Color.Snow;
            btnApproved.ForeColor = Color.Brown;
            btnPending.ForeColor = Color.Snow;
            tbControl.SelectTab(3);
        }

        //---------------------------------Moving Form-------------------------------
        bool mouseDown = false;
        Point startPoint; //Where the mouse has
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }
    }
}
