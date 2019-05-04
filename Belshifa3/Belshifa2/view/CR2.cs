using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belshifa2.view
{
    public partial class CR2 : Form
    {
        public CR2()
        {
            InitializeComponent();
        }
        CrystalReport2 cr;
        private void CR2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "")
            {
                cr.SetParameterValue(0, textBox3.Text);
                crystalReportViewer1.ReportSource = cr;
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "")
            {
                cr.SetParameterValue(1, textBox2.Text);
                crystalReportViewer1.ReportSource = cr;
            }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
            {
                cr.SetParameterValue(2, textBox1.Text);
                crystalReportViewer1.ReportSource = cr;
            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                cr.SetParameterValue(0, textBox3.Text);
                cr.SetParameterValue(1, textBox2.Text);
                cr.SetParameterValue(2, textBox1.Text);
                crystalReportViewer1.ReportSource = cr;
            }
        }
    }
}
