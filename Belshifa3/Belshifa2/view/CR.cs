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
    public partial class CrystalReports : Form
    {
        CrystalReport1 cr;
        public CrystalReports()
        {
            InitializeComponent();
        }

        private void CrystalReports_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(2, textBox1.Text);
            cr.SetParameterValue(1, textBox2.Text);
            cr.SetParameterValue(0, textBox3.Text);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
