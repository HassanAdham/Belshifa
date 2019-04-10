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
    public partial class Form2 : Form
    {
        string ordb = "Data Source = oracle ; User ID = scott ; Password = tiger";
        OracleConnection conn;

        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
            conn  = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Patient values (:Username,:Address,:Email,:P_LName,:Gender,:P_FName,:Passwordd,:Age,:Phone,)";
            cmd.Parameters.Add("Username", Username.Text);
            cmd.Parameters.Add("Address", Address.Text);
            cmd.Parameters.Add("Email", Email.Text);
            cmd.Parameters.Add("P_LName", LName.Text);
            if(Female.Checked == true)
            {
                cmd.Parameters.Add("Gender", 'F');
            }
            else if (Male.Checked== true)
            {
                cmd.Parameters.Add("Gender", 'M');
            }

            cmd.Parameters.Add("P_FName", FName.Text);
            cmd.Parameters.Add("Passwordd", Password.Text);
            cmd.Parameters.Add("Age", Age.Text);
            cmd.Parameters.Add("Phone", Phone.Text);
            int r = cmd.ExecuteNonQuery();
            if (r !=1 )
            {
                MessageBox.Show("Please fill the data");

            }
            else
            {
                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }
            conn.Close();
          
           

        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Patient values (:FName)";
            cmd.Parameters.Add("P_FName" , FName.Text);

        }

        private void bunifuTextBox8_TextChange(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Patient values (:LName)";
            cmd.Parameters.Add("P_LName", LName.Text);


        }

        private void Username_TextChange(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Patient values (:Username)";
            cmd.Parameters.Add("Username", Username.Text);

        }

        private void Password_TextChange(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Patient values (:Passwordd)";
            cmd.Parameters.Add("Passwordd", Password.Text);
            

        }

        private void Female_Click(object sender, EventArgs e)
        {
            if (Female.Checked == true)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Patient values (:Gender)";
                cmd.Parameters.Add("Gender", 'F');
            }
        }

        private void Male_Click(object sender, EventArgs e)
        {
            if (Male.Checked == true)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Patient values (:Gender)";
                cmd.Parameters.Add("Gender", 'M');
            }

        }

        private void Age_TextChange(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Patient values (:Age)";
            cmd.Parameters.Add("Age", Age.Text);

        }

        private void Phone_TextChange(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Patient values (:Phone)";
            cmd.Parameters.Add("Phone", Phone.Text);
        }

        private void Email_TextChange(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Patient values (:Email)";
            cmd.Parameters.Add("Email", Email.Text);
        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }
    }
}
