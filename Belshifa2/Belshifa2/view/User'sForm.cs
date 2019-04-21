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
        PharmacistPresenter pharmacistPresenter;
        public Form1()
        {
            InitializeComponent();
            patientPresenter = new PatientPresenter(this);
            patientPresenter.signIn("roo@gmail.com", "roo");

            pharmacistPresenter = new PharmacistPresenter(this);
            pharmacistPresenter.signIn("ali_hussien", "ezabyworker");

            patientPresenter = new PatientPresenter(this);
            patientPresenter.signIn("dinaroo", "roos");

        }

        public void display(List<object> returnedValues)
        {
            throw new NotImplementedException();
        }

        public void displayError(string error)
        {
            MessageBox.Show(error);
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loginregister_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void Medicines_Click(object sender, EventArgs e)
        {

        }

        private void Cosemetics_Click(object sender, EventArgs e)
        {

        }

        private void healthbodycare_Click(object sender, EventArgs e)
        {

        }

        private void babycare_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
