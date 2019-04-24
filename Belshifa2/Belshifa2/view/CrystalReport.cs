using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Belshifa2
{
    public partial class CrystalReport : Form
    {
        CrystalReport1 cr;
        public CrystalReport()
        {
            InitializeComponent();
        }

        private void CrystalReport_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, textBox1.Text);
            cr.SetParameterValue(1, textBox2.Text);
            cr.SetParameterValue(2, textBox3.Text);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}




