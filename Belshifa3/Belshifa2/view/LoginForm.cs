﻿using System;
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
using Belshifa2.view;

namespace Belshifa2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {  
            SystemDatabase dbObj = new SystemDatabase();
            string message = dbObj.signIn(txtBoxUsername.Text, txtBoxPassword.Text,radioBtnPharmacist.Checked); //Sign in.
            lblMessage.Text = message;
            lblMessage.Visible = true;
            if(message == "Logging in..")
            {
                if(radioBtnUser.Checked) //Patient.
                {
                    object user = dbObj.getProfile(txtBoxUsername.Text, false); //If signed, get profile.
                    Patient patient = (Patient)user;
                    CurrentPatient currentPatient = new CurrentPatient();
                    currentPatient.set_currentUser(patient);
                    currentPatient.initialize_List();
                    this.Close();
                }
                else //Pharmacist.
                {
                    object user = dbObj.getProfile(txtBoxUsername.Text, true);
                    Pharmacist pharmacist = (Pharmacist)user;
                    this.Hide();
                    PharmForm pharmForm = new PharmForm(txtBoxUsername.Text, pharmacist.get_pharmacy_id() ,"");
                    pharmForm.ShowDialog();
                    this.Close();
                }
            }
        }

        //---------------------------------Form-----------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 signUpForm = new Form3(); //User Sign up
            signUpForm.ShowDialog();
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
