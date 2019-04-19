using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Belshifa2.presenter;

namespace Belshifa2
{
    public partial class Form1 : Form, Contractor.ViewContractor
    {
        PatientPresenter patientPresenter;
        public Form1()
        {
            InitializeComponent();
            patientPresenter = new PatientPresenter(this);
            patientPresenter.signIn("Rodina", "Password");
        }

        public void display(List<object> returnedValues)
        {
            throw new NotImplementedException();
        }

        public void displayError(string error)
        {
            throw new NotImplementedException();
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void goToNextPage()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.BackgroundImage = global::Belshifa2.Properties.Resources.images__2_;
            newPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            newPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            newPictureBox.ImageLocation = "";
            newPictureBox.Location = new System.Drawing.Point(172, 3);
            newPictureBox.Name = "newPictureBox";
            newPictureBox.Size = new System.Drawing.Size(163, 133);
            newPictureBox.TabIndex = 15;
            newPictureBox.TabStop = false;

            flowLayoutPanel2.Controls.Add(newPictureBox);
        }

    }
}
