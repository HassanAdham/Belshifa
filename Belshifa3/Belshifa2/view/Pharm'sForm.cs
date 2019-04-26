using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Belshifa2.dataClasses;
using Belshifa2.model;

namespace Belshifa2
{
    public partial class Form2 : Form
    {
        SystemDatabase sysdb;
        private int pharmacyid;
        private string username;
        public Form2(int pharmacyid,string username)
        {
            InitializeComponent();
            sysdb = new SystemDatabase();
            this.pharmacyid = pharmacyid;
            this.username = username;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            creatnumberoforders(6);
            createmedicines(2);
            label1.Text = pharmacyid.ToString();
        }

        private void showorder(int orid, string od, string dd, float tp, string em, int pharid)
        {
            // panel4
            // 
            FlowLayoutPanel listofOrders = new FlowLayoutPanel();
            Panel head = new Panel();
            Panel pan = new Panel();
            Panel inn = new Panel();
            Label ordid = new Label();
            Label orderdate = new Label();
            Label delivdate = new Label();
            Label totalprice = new Label();
            Label email = new Label();
            Label pharmid = new Label();
            Label medicines = new Label();
            Panel mediciness = new Panel();
            Label MName = new Label();
            Label MPrice = new Label();

            // 
            // flowLayoutPanel1
            // 
            listofOrders.AutoScroll = true;
            listofOrders.Controls.Add(head);
            listofOrders.Location = new System.Drawing.Point(12, 151);
            listofOrders.Name = "flowLayoutPanel1";
            listofOrders.Size = new System.Drawing.Size(750, 363);
            listofOrders.TabIndex = 17;
            flowLayoutPanel1.Controls.Add(head);
            // 
            // label1
            // 
            ordid.AutoSize = true;
            ordid.Location = new System.Drawing.Point(3, 0);
            ordid.Name = "label1";
            ordid.Size = new System.Drawing.Size(35, 13);
            ordid.TabIndex = 0;
            ordid.Text = "label1";
            // 
            // panel5
            // 
            pan.Controls.Add(mediciness);
          
            pan.Controls.Add(pharmid);
            pan.Controls.Add(email);
            pan.Controls.Add(delivdate);
            pan.Controls.Add(orderdate);
            pan.Location = new System.Drawing.Point(0, 16);
            pan.Name = "panel5";
            pan.Size = new System.Drawing.Size(239, 344);
            pan.TabIndex = 1;

            // label4
            // 
            orderdate.AutoSize = true;
            orderdate.Location = new System.Drawing.Point(19, 27);
            orderdate.Name = "label4";
            orderdate.Size = new System.Drawing.Size(35, 13);
            orderdate.TabIndex = 0;
            orderdate.Text = "label4";
            // 
            // label5
            // 
            delivdate.AutoSize = true;
            delivdate.Location = new System.Drawing.Point(19, 58);
            delivdate.Name = "label5";
            delivdate.Size = new System.Drawing.Size(35, 13);
            delivdate.TabIndex = 1;
            delivdate.Text = "label5";
            // 
            // label6
            // 
            email.AutoSize = true;
            email.Location = new System.Drawing.Point(19, 91);
            email.Name = "label6";
            email.Size = new System.Drawing.Size(35, 13);
            email.TabIndex = 2;
            email.Text = "label6";
            // 
            // label7
            // 
            pharmid.AutoSize = true;
            pharmid.Location = new System.Drawing.Point(19, 122);
            pharmid.Name = "label7";
            pharmid.Size = new System.Drawing.Size(35, 13);
            pharmid.TabIndex = 3;
            pharmid.Text = "label7";
            // 
            // label8
            // 
         
            // 
            // panel3
            // 
            mediciness.AutoScroll = true;
            mediciness.Controls.Add(MPrice);
            mediciness.Controls.Add(MName);
            mediciness.Location = new System.Drawing.Point(39, 195);
            mediciness.Name = "panel3";
            mediciness.Size = new System.Drawing.Size(200, 149);
            mediciness.TabIndex = 10;
            // 
            // label2
            // 
            MName.AutoSize = true;
            MName.Location = new System.Drawing.Point(18, 21);
            MName.Name = "label2";
            MName.Size = new System.Drawing.Size(35, 13);
            MName.TabIndex = 10;
            MName.Text = "label2";
            // 
            // label3
            // 
            MPrice.AutoSize = true;
            MPrice.Location = new System.Drawing.Point(132, 21);
            MPrice.Name = "label3";
            MPrice.Size = new System.Drawing.Size(35, 13);
            MPrice.TabIndex = 11;
            MPrice.Text = "label3";
            // 
            // panel4
            // 
            head.Controls.Add(pan);
            head.Controls.Add(this.checkBox1);
            head.Controls.Add(ordid);
            head.Location = new System.Drawing.Point(3, 3);
            head.Name = "panel4";
            head.Size = new System.Drawing.Size(239, 366);
            head.TabIndex = 1;

            showmedicines("panadol", 20);
;
        }
        private void showmedicines(string medname, float medprice)
        {
            Label MedicineName = new Label();
            Label MedicinePrice = new Label();
            Panel Medicines = new Panel();

            // 
            // panel5
            // 
            //pan.Controls.Add(Medicines);
            //pan.Controls.Add(this.label9);
            //pan.Controls.Add(this.label8);
            //pan.Controls.Add(pharmid);
            //pan.Controls.Add(email);
            //pan.Controls.Add(delivdate);
            //pan.Controls.Add(orderdate);
            //pan.Location = new System.Drawing.Point(0, 16);
            //pan.Name = "panel5";
            //pan.Size = new System.Drawing.Size(239, 344);
            //pan.TabIndex = 1;
            //pan.Paint += new System.Windows.Forms.PaintEventHandler(pan_Paint);
            // 
            // panel3
            // 
            Medicines.AutoScroll = true;
            Medicines.Controls.Add(MedicinePrice);
            Medicines.Controls.Add(MedicineName);
            Medicines.Location = new System.Drawing.Point(39, 195);
            Medicines.Name = "panel3";
            Medicines.Size = new System.Drawing.Size(200, 149);
            Medicines.TabIndex = 10;
            // 
            // label2
            // 
            MedicineName.AutoSize = true;
            MedicineName.Location = new System.Drawing.Point(18, 21);
            MedicineName.Name = "label2";
            MedicineName.Size = new System.Drawing.Size(35, 13);
            MedicineName.TabIndex = 10;
            MedicineName.Text = "label2";
            // 
            // label3
            // 
            MedicinePrice.AutoSize = true;
            MedicinePrice.Location = new System.Drawing.Point(132, 21);
            MedicinePrice.Name = "label3";
            MedicinePrice.Size = new System.Drawing.Size(35, 13);
            MedicinePrice.TabIndex = 11;
            MedicinePrice.Text = "label3";
        }
        //halef 3ale list bta3et elorders mn systemdatabase
        private void creatnumberoforders(int id)
        {
            List<Order> ord = sysdb.Get_Pharmacy_Orders(pharmacyid);
            foreach (Order order in ord)
            {
                showorder(order.get_orderId(), order.get_orderDate(), order.get_deliveryDate(), order.get_totalPrice(), order.get_patient_email(), order.get_pharmacy_id());
            }
        }
        private void createmedicines(int pharmid)
        {

            List<Medicine> MED = sysdb.MName(pharmacyid);
            foreach (Medicine m in MED)
            {
                showmedicines(m.get_name(), m.get_price());
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sysdb.getpharmacistusername(checkBox1.Checked);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
