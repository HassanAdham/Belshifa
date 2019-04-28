using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Belshifa2.model;
using Belshifa2.dataClasses;

namespace Belshifa2.view
{
    public partial class PharmForm : Form
    {
        private string username;
        private int pharmacy_id;
        private string pharmacy_name;
        private SystemDatabase sysdb;
        public PharmForm(string username, int pharmacy_id, string pharmacy_name)
        {
            InitializeComponent();
            this.username = username;
            this.pharmacy_id = pharmacy_id;
            this.pharmacy_name = pharmacy_name;
            sysdb = new SystemDatabase();

        }

        private void PharmForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = username;
            lblPharmacyName.Text = pharmacy_name;

            creatnumberoforders(pharmacy_id);

        }

        private void showorder(int orid, string od, float tp, string em, int pharid)
        {
            Label lblEmail = new Label();
            Label lblTotalPrice = new Label();
            Label lblOrderDate = new Label();
            Label lblOrderID = new Label();
            CheckBox chckBx = new CheckBox();
            Panel pnlOrderWhite = new Panel();
            Panel pnlOrderBrown = new Panel();
            Panel pnlMedicines = new Panel();
            Label lblMedicines = new Label();
            FlowLayoutPanel flpMedicines = new FlowLayoutPanel();
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEmail.Location = new System.Drawing.Point(5, 74);
            lblEmail.Size = new System.Drawing.Size(44, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = em;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.None;
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalPrice.Location = new System.Drawing.Point(5, 41);
            lblTotalPrice.Size = new System.Drawing.Size(76, 15);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = tp.ToString();
            // 
            // lblOrderDate
            // 
            lblOrderDate.Anchor = AnchorStyles.None;
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblOrderDate.Location = new System.Drawing.Point(5, 10);
            lblOrderDate.Size = new System.Drawing.Size(77, 15);
            lblOrderDate.TabIndex = 0;
            lblOrderDate.Text = od.Substring(0,9);
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblOrderID.ForeColor = System.Drawing.Color.White;
            lblOrderID.Location = new System.Drawing.Point(3, 7);
            lblOrderID.Size = new System.Drawing.Size(66, 16);
            lblOrderID.TabIndex = 0;
            lblOrderID.Text = orid.ToString();

            // 
            // chckBx
            // 
            chckBx.AutoSize = true;
            chckBx.BackColor = System.Drawing.Color.Brown;
            chckBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            chckBx.ForeColor = System.Drawing.Color.Snow;
            chckBx.Location = new System.Drawing.Point(130, 5);
            chckBx.Size = new System.Drawing.Size(86, 20);
            chckBx.TabIndex = 2;
            chckBx.Text = "Approve";
            chckBx.UseVisualStyleBackColor = false;
            // 
            // pnlOrderWhite
            // 
            pnlOrderWhite.BackColor = System.Drawing.Color.White;
            pnlOrderWhite.Location = new System.Drawing.Point(-1, 29);
            pnlOrderWhite.Size = new System.Drawing.Size(223, 331);
            pnlOrderWhite.Controls.Add(pnlMedicines);
            pnlOrderWhite.Controls.Add(lblEmail);
            pnlOrderWhite.Controls.Add(lblTotalPrice);
            pnlOrderWhite.Controls.Add(lblOrderDate);
            pnlOrderWhite.TabIndex = 1;
            // 
            // pnlMedicines
            // 
            pnlMedicines.Anchor = AnchorStyles.None;
            pnlMedicines.AutoScroll = true;
            pnlMedicines.BorderStyle = BorderStyle.FixedSingle;
            pnlMedicines.Controls.Add(lblMedicines);
            pnlMedicines.Controls.Add(flpMedicines);
            pnlMedicines.Location = new System.Drawing.Point(0, 113);
            pnlMedicines.Size = new System.Drawing.Size(223, 224);
            pnlMedicines.TabIndex = 10;

            // 
            // pnlOrderBrown
            // 
            pnlOrderBrown.BackColor = System.Drawing.Color.Brown;
            pnlOrderBrown.BorderStyle = BorderStyle.FixedSingle;
            pnlOrderBrown.Controls.Add(chckBx);
            pnlOrderBrown.Controls.Add(pnlOrderWhite);
            pnlOrderBrown.Controls.Add(lblOrderID);
            pnlOrderBrown.Location = new System.Drawing.Point(8, 8);
            pnlOrderBrown.Margin = new Padding(8);
            pnlOrderBrown.Size = new System.Drawing.Size(222, 363);
            pnlOrderBrown.TabIndex = 1;
            // 
            // lblMedicines
            // 
            lblMedicines.AutoSize = true;
            lblMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMedicines.Location = new System.Drawing.Point(67, 5);
            lblMedicines.Size = new System.Drawing.Size(73, 15);
            lblMedicines.TabIndex = 12;
            lblMedicines.Text = "Medicines";

            // 
            // flpMedicines
            // 
            flpMedicines.AutoSize = true;
            flpMedicines.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpMedicines.BackColor = System.Drawing.Color.WhiteSmoke;
            //flpMedicines.Controls.Add(lblMedicine);
            flpMedicines.Location = new System.Drawing.Point(13, 28);
            flpMedicines.MaximumSize = new System.Drawing.Size(185, 0);
            flpMedicines.MinimumSize = new System.Drawing.Size(185, 142);
            flpMedicines.Size = new System.Drawing.Size(185, 142);
            flpMedicines.TabIndex = 0;
            createmedicines(pharmacy_id,orid,flpMedicines);
            //------------------------------------------------------------
            // showmedicines("panadol", 20);
            flpOrders.Controls.Add(pnlOrderBrown);
        }

        private void showmedicines(string medname, FlowLayoutPanel flpmeed)
        {
            Label lblMedicine = new Label();

            // 
            // lblMedicine
            // 
            lblMedicine.AutoSize = true;
            lblMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMedicine.Location = new System.Drawing.Point(5, 5);
            lblMedicine.Margin = new System.Windows.Forms.Padding(5);
            lblMedicine.Size = new System.Drawing.Size(47, 15);
            lblMedicine.Text = medname;

            flpmeed.Controls.Add(lblMedicine);
        }


        //halef 3ale list bta3et elorders mn systemdatabase
        private void creatnumberoforders(int id)
        {
            List<Order> ord = sysdb.Get_Pharmacy_Orders(pharmacy_id);
            foreach (Order order in ord)
            {
                showorder(order.get_orderId(), order.get_orderDate(), order.get_totalPrice(),
                            order.get_patient_email(), order.get_pharmacy_id());
            }
        }

        private void createmedicines(int pharmidr , int oid , FlowLayoutPanel flpmed)
        {
            List<Medicine> MED = sysdb.MName(oid);
            foreach (Medicine m in MED)
            {
                showmedicines(m.get_name(),flpmed);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // sysdb.getpharmacistusername(checkBox1.Checked);
        }

        //----------------------------------------Form------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
