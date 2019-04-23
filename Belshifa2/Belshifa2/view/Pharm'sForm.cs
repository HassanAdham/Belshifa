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
namespace Belshifa2
{
    public partial class Form2 : Form
    {
        SystemDatabase sysdb;
        public Form2()
        {
            InitializeComponent();
            sysdb = new SystemDatabase();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            creatnumberoforders(1);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showorder(int orid ,string od, string dd, float tp, string em , int pharid )
        {
            // panel4
            // 
            Panel pan = new Panel();
            Panel head = new Panel();
            Label ordid = new Label();
            Label orderdate = new Label();
            Label delivdate = new Label();
            Label totalprice = new Label();
            Label email = new Label();
            Label pharmid = new Label();
            Label medicines = new Label();
            FlowLayoutPanel listofmedicines = new FlowLayoutPanel();
            // pan 
            pan.Controls.Add(head);
            pan.Controls.Add(ordid);
            pan.Location = new System.Drawing.Point(3, 3);
            pan.Name = "panel4";
            pan.Size = new System.Drawing.Size(239, 366);
            pan.TabIndex = 1;



            // 
            // panel5
            // 
            head.Controls.Add(pharmid);
            head.Controls.Add(email);
            head.Controls.Add(totalprice);
            head.Controls.Add(delivdate);
            head.Controls.Add(orderdate);
            head.Location = new System.Drawing.Point(0, 16);
            head.Name = "panel5";
            head.Size = new System.Drawing.Size(239, 350);
            head.TabIndex = 1;

            // flowLayoutPanel2
            // 
            listofmedicines.AutoScroll = true;
            listofmedicines.Location = new System.Drawing.Point(22, 195);
            listofmedicines.Name = "flowLayoutPanel2";
            listofmedicines.Size = new System.Drawing.Size(217, 155);
            listofmedicines.TabIndex = 10;


            // label9
            // 
            medicines.AutoSize = true;
            medicines.Location = new System.Drawing.Point(19, 179);
            medicines.Name = "label9";
            medicines.Size = new System.Drawing.Size(35, 13);
            medicines.TabIndex = 9;
            medicines.Text = "label9";
         
            // 
            // label8
            // 
            pharmid.AutoSize = true;
            pharmid.Location = new System.Drawing.Point(19, 150);
            pharmid.Name = "label8";
            pharmid.Size = new System.Drawing.Size(35, 13);
            pharmid.TabIndex = 4;
            pharmid.Text = pharid.ToString();
            // 
            // label7
            // 
            email.AutoSize = true;
            email.Location = new System.Drawing.Point(19, 122);
            email.Name = "label7";
            email.Size = new System.Drawing.Size(35, 13);
            email.TabIndex = 3;
            email.Text = em.ToString();
            // 
            // label6
            // 
            totalprice.AutoSize = true;
            totalprice.Location = new System.Drawing.Point(19, 91);
            totalprice.Name = "label6";
            totalprice.Size = new System.Drawing.Size(35, 13);
            totalprice.TabIndex = 2;
            totalprice.Text = tp.ToString();
            // 
            // label5
            // 
            delivdate.AutoSize = true;
            delivdate.Location = new System.Drawing.Point(19, 58);
            delivdate.Name = "label5";
            delivdate.Size = new System.Drawing.Size(35, 13);
            delivdate.TabIndex = 1;
            delivdate.Text = dd.ToString();
            // 
            // label4
            // 
            orderdate.AutoSize = true;
            orderdate.Location = new System.Drawing.Point(19, 27);
            orderdate.Name = "label4";
            orderdate.Size = new System.Drawing.Size(35, 13);
            orderdate.TabIndex = 0;
            orderdate.Text = od.ToString();
            // 
            // label1
            // 
            ordid.AutoSize = true;
            ordid.Location = new System.Drawing.Point(3, 0);
            ordid.Name = "label1";
            ordid.Size = new System.Drawing.Size(35, 13);
            ordid.TabIndex = 0;
            ordid.Text = orid.ToString();
            flowLayoutPanel1.Controls.Add(pan);
        }

        //halef 3ale list bta3et elorders mn systemdatabase
        private void creatnumberoforders(int id)
        {
            List<Order> ord = sysdb.Get_Pharmacy_Orders(1);
            foreach(Order order in ord)
            {
                showorder(order.get_orderId(),order.get_orderDate(), order.get_deliveryDate(), order.get_totalPrice(),order.get_patient_email(),order.get_pharmacy_id());
            }
        }
    }
}
