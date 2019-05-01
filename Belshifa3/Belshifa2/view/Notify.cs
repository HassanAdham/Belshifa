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

namespace Belshifa2.view
{
    public partial class Notify : Form
    {
        SystemDatabase dbObj;
        CurrentPatient currentPatient;
        public Notify()
        {
            InitializeComponent();
            dbObj = new SystemDatabase();
            currentPatient = new CurrentPatient();
        }

        private void Notify_Load(object sender, EventArgs e)
        {
            foreach (string s in currentPatient.get_notifications())
            {
                rchTxtBx.Text += "-" + s + "\n\n";
            }
        }
        private void btnOkay_Click(object sender, EventArgs e)
        {

            string reply = dbObj.seenNofitifications(currentPatient.get_currentUser().get_email());
            if (reply == "Seen")
            {
                this.Close();
                currentPatient.clearNotificiationsList();
            }
            else
            {
                lblReply.Text = "Failed, please check your connection!";
                lblReply.Visible = true;
            }
        }

        //-----------------==--------------Form-------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---------------------------------Moving Form-------------------------------
        bool mouseDown = false;
        Point startPoint; //Where the mouse has
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
