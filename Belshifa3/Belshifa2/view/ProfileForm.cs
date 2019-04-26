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
        CurrentPatient currentPatient = new CurrentPatient();
        SystemDatabase dbObj = new SystemDatabase();
        Patient patient;
        public ProfileForm()
        {
            InitializeComponent();
            dtPickerBirthdate.Format = DateTimePickerFormat.Custom;
            dtPickerBirthdate.CustomFormat = "dd-MM-YYYY";
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
            displayUnapproved();
            displayHistory();
        }
        private void displayCart()
        {
            flpCart.Controls.Clear();
            Dictionary<int,QuantPrice> cart = currentPatient.get_cart();
            foreach(KeyValuePair<int, QuantPrice> item in cart)
            {
                create_item_To_Cart(item);
            }

            List<Order> pending = dbObj.getPatientPendingOrders(currentPatient.get_currentUser().get_email());
            flpUnapproved.Controls.Clear();
            foreach(Order order in pending)
            {
                create_item_To_Pending(order);
            }
        }
        private void displayUnapproved()
        {

        }
        private void displayHistory()
        {

        }

        private void create_item_To_Cart(KeyValuePair<int, QuantPrice> itm)
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
            lblPrice.Text = (itm.Value.get_quantity()*itm.Value.get_price()).ToString();
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
            lblId.Location = new Point(22,9);
            lblId.Name = "lblId";
            lblId.Size = new Size(48, 18);
            lblId.TabIndex = 29;
            lblId.Text = order.get_orderId().ToString();

            // 
            // lblOrderDate
            // 
            lblOrderDate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblOrderDate.ForeColor = Color.Brown;
            lblOrderDate.Location = new Point(133, 9);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(48, 18);
            lblOrderDate.TabIndex = 29;
            lblOrderDate.Text = order.get_orderDate();


            flpUnapproved.Controls.Add(item);
        }
        private void remove_item(int id)
        {
            currentPatient.removeFromCart(id);
        }
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
                lblReply.Text = dbObj.updateProfile(patient);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbObj.deleteAccount(patient.get_email());
            currentPatient.signOut();
            this.Close();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flpCart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
