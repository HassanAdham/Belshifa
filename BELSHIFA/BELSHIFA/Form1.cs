using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace BELSHIFA
{
    public partial class Form1 : Form
    {
        string ordb = "Data Source = oracle ; User ID = scott ; Password = tiger";
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 signup = new Form2();
            signup.Show();
         

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from patient where Username =" + Username.Text + "and Passwordd = " + Password.Text + "";
          
            
          

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
           

        }
    }
}
