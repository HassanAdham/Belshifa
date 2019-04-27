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
using Belshifa2.view;

namespace Belshifa2
{
    public partial class Form1 : Form
    {
        SystemDatabase dbObj;
        CurrentPatient currentPatient;
        public Form1()
        {
            InitializeComponent();
            dbObj = new SystemDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayAllSections();
            displayAllMedicines();
        }
        private void displayAllSections()
        {
            List<Section> list = dbObj.getSections();
            foreach(Section s in list)
            {
                create_Section(s);
            }
        }
        private void create_Section(Section section)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(3, 0);
            label.Name = section.get_name();
            label.Padding = new Padding(4);
            label.Size = new Size(59, 28);
            label.TabIndex = section.get_id();
            label.Text = section.get_name();
            label.Click += delegate
            {
                foreach (Label l in flpSections.Controls)
                {
                    l.ForeColor = Color.Black;
                }
                label.ForeColor = Color.Brown;
                get_medicines_of_section(section.get_id());
            };

            flpSections.Controls.Add(label);
        }

        private void lblAllSections_Click(object sender, EventArgs e)
        {
            foreach (Label l in flpSections.Controls)
            {
                l.ForeColor = Color.Black;
            }
            lblAllSections.ForeColor = Color.Brown;
            displayAllMedicines();
        }
        private void displayAllMedicines()
        {
            flpMedicine.Controls.Clear();
            List<Medicine> list = dbObj.getAllMedicines();
            foreach(Medicine m in list)
            {
                create_medicine(m);
            }
        }
        private void get_medicines_of_section(int id)
        {
            flpMedicine.Controls.Clear();
            List<Medicine> list = dbObj.getMedicines(id);
            foreach(Medicine m in list)
            {
                create_medicine(m);
            }
        }
        private void create_medicine(Medicine medicine)
        {
            Panel panel = new Panel();
            PictureBox pictureBox = new PictureBox();
            Label label = new Label();

            pictureBox.BackColor = Color.Gainsboro;
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.ImageLocation = "";
            pictureBox.Location = new Point(18, 3);
            pictureBox.Name = medicine.get_id().ToString();
            pictureBox.Size = new Size(163, 133);
            pictureBox.TabStop = false;
            pictureBox.Click += delegate
            {
                getAllAttributesOfMedicine(medicine);
            };
            /////////////////////////////////////////////////
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(18, 143);
            label.Name = medicine.get_id().ToString();
            label.Size = new Size(46, 18);
            label.Text = medicine.get_name();
            label.Click += delegate
            {
                getAllAttributesOfMedicine(medicine);
            };
            /////////////////////////////////////////////// 
            panel.Location = new Point(3, 3);
            panel.Margin = new Padding(10, 10, 10, 10);
            panel.Name = medicine.get_id().ToString();
            panel.Size = new Size(200, 175);
            panel.Controls.Add(label);
            panel.Controls.Add(pictureBox);
            panel.Click += delegate
            {
                getAllAttributesOfMedicine(medicine);
            };
            //////////////////////////////////////////////
            flpMedicine.Controls.Add(panel);
        }

        private void getAllAttributesOfMedicine(Medicine medicine)
        {
            MedicineAttributes medicineAttributesForm = new MedicineAttributes(medicine.get_id(),
                medicine.get_name(), medicine.get_precautions(), medicine.get_drug_drug_interaction(),
                medicine.get_drug_food_interaction(), medicine.get_usage(), medicine.get_side_effects(),
                medicine.get_price());

            medicineAttributesForm.ShowDialog();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Medicine m = dbObj.SearchForMedicine(txtBxSearch.Text);
            foreach (Label l in flpSections.Controls)
            {
                l.ForeColor = Color.Black;
            }
            flpMedicine.Controls.Clear();
            if (m != null)
            {
                create_medicine(m);
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(btnSignUp.Text == "Sign Up")
            {
                Form3 signUpPatient = new Form3();
                signUpPatient.ShowDialog();
            }
            else //Sign out!
            {
                currentPatient.signOut();
                Loginregister.Text = "Sign In";
                btnSignUp.Text = "Sign Up";
            }

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
        //-----------------------------------Form ------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            dbObj.disconnect();
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //--------------------------------Commercials-------------------------------
        int i = 3;
        private void timerCommercial_Tick(object sender, EventArgs e)
        {
            if(i%3 == 0)
            {
                picBxCommercial1.BackgroundImage = Belshifa2.Properties.Resources.download__2_;
                picBoxCommercial2.BackgroundImage = Belshifa2.Properties.Resources.images__2_;
                picBoxCommercial3.BackgroundImage = Belshifa2.Properties.Resources.images__1_;
                i++;
            }
            else if (i%4 == 0)
            {
                picBxCommercial1.BackgroundImage = Belshifa2.Properties.Resources.images__1_;
                picBoxCommercial2.BackgroundImage = Belshifa2.Properties.Resources.images__6_;
                picBoxCommercial3.BackgroundImage = Belshifa2.Properties.Resources.images__5_;

                i++;
            }
            else if (i % 5 == 0)
            {
                picBxCommercial1.BackgroundImage = Belshifa2.Properties.Resources.images__5_;
                picBoxCommercial2.BackgroundImage = Belshifa2.Properties.Resources.download__2_;
                picBoxCommercial3.BackgroundImage = Belshifa2.Properties.Resources.images__2_;

                i = 3;
            }
        }

        private void Loginregister_Click(object sender, EventArgs e)
        {
            if(Loginregister.Text == "Sign In")
            {
                LoginForm lf = new LoginForm();
                lf.ShowDialog();
                currentPatient = new CurrentPatient();
                if (currentPatient.get_currentUser() != null)
                {
                    Loginregister.Text = currentPatient.get_currentUser().get_f_name();
                    btnSignUp.Text = "Sign Out";
                }
            }
            else
            {
                ProfileForm pf = new ProfileForm();
                pf.ShowDialog();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
