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
    public partial class Form4 : Form
    {
        SystemDatabase dbObj;
        public Form4()
        {
            InitializeComponent();
            dbObj = new SystemDatabase();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Pharmacy> pharmacies = dbObj.get_Pharmacies();
            foreach (Pharmacy pharmacy in pharmacies)
            {
                cmBxPharmacies.Items.Add(pharmacy.get_id() + " " + pharmacy.get_name());
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(cmBxPharmacies.Text != "")
            {
                string[] arr = cmBxPharmacies.SelectedItem.ToString().Split(' ');
                int pharm_id = int.Parse(arr[0]);
                Pharmacist pharmacist = new Pharmacist(txtBxUsername.Text, txtbxPassword.Text, pharm_id);
                lblMessage.Text = dbObj.signUp(pharmacist, true);
                lblMessage.Visible = true;
            }
            else
            {
                lblMessage.Text = "Please, don't leave empty fields!";
                lblMessage.Visible = true;
            }
        }

        //----------------------------Form--------------------------------
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

        private void lblGoToSignUpPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 signUpPatient = new Form3();
            signUpPatient.ShowDialog();
            this.Close();
        }
    }
}
