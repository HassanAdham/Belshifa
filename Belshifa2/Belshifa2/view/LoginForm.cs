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
namespace Belshifa2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SystemDatabase dbObj = new SystemDatabase();
            string message = dbObj.signIn(txtBoxUsername.Text, txtBoxPassword.Text, radioBtnPharmacist.Checked);
            lblMessage.Text = message;
            lblMessage.Visible = true;
            if(message == "Logging in..")
            {
                object user = dbObj.getProfile(txtBoxUsername.Text, radioBtnPharmacist.Checked);

                if(radioBtnUser.Checked)
                {
                    Patient patient = (Patient)user;
                    CurrentPatient currentPatient = new CurrentPatient();
                    currentPatient.set_currentUser(patient);
                    currentPatient.initialize_List();
                    this.Close();
                }
                else
                {
                    //Pharmacist code!!
                }
            }
        }

        //---------------------------------Form Handling-----------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
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


    }
}
