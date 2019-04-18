using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belshifa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
