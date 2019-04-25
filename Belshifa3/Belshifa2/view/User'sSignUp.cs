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
    public partial class Form3 : Form
    {
        SystemDatabase dbObj;
        public Form3()
        {
            InitializeComponent();
            dbObj = new SystemDatabase();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dtPickerBirthdate.Format = DateTimePickerFormat.Custom;
            dtPickerBirthdate.CustomFormat = "dd-MM-YYYY";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(txtBxFName.Text, txtBxLastName.Text, txtBxPassword.Text,
                                txtBxAddress.Text, txtBxPhone.Text, txtBxEmail.Text, cmbBxPayment.Text, dtPickerBirthdate.Text);
            dbObj.signUp(patient, false);
        }

        private void lblGoToSignUpPharmacist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 signUpPharmacist = new Form4();
            signUpPharmacist.ShowDialog();
            this.Close();
        }
        //---------------------------------Moving Form-------------------------------
        bool mouseDown = false;
        Point startPoint;
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
    }
}
