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

namespace Belshifa2.view
{
    public partial class MedicineAttributes : Form
    {
        SystemDatabase dbObj;
        CurrentPatient currentPatient;
        private int m_id;
        private float price;
        private string usage;
        private int quantity;
        private string name;
        public MedicineAttributes(int m_id, string name, string precautions, string ddInteraction,
                                  string dfInteraction, string usage, string side_effects, float price)
        {
            InitializeComponent();
            dbObj = new SystemDatabase();
            currentPatient = new CurrentPatient();
            this.m_id = m_id;
            this.usage = usage;
            this.price = price;
            this.name = name;
            btnMedicinePage.Text = name;
            lblDFInteraction.Text = dfInteraction;
            lblName.Text = name;
            lblPrecautions.Text = precautions;
            lblSideEffects.Text = side_effects;
            lblPrice.Text = price.ToString();
            lblDDInteraction.Text = ddInteraction;
        }

        private void MedicineAttributes_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
            flpSimilars.Controls.Clear();
            List<Medicine> similarsList = dbObj.getSimilars(this.usage);
            foreach(Medicine medicine in similarsList)
            {
                create_medicine(medicine);
            }
        }
        private void create_medicine(Medicine medicine)
        {
            Button btnAddToCart = new Button();
            NumericUpDown numericUD = new NumericUpDown();
            Panel pnlMedicineFloor = new Panel();

            Label lblNameText = new Label();

            Label lblUsageHeader = new Label();
            Label lblPriceHeader = new Label();
            Label lblPrecautionsHeader = new Label();
            Label lblSideEffectsHeader = new Label();
            Label lblDDInteractionHeader = new Label();
            Label lblDFInteractionHeader = new Label();

            Label lblUsageText = new Label();
            Label lblPriceText = new Label();
            Label lblPrecautionsText = new Label();
            Label lblSideEffectText = new Label();
            Label lblDDInteractionText = new Label();
            Label lblDFInteractionText = new Label();

            // 
            // lblPriceHeader
            // 
            lblPriceHeader.AutoSize = true;
            lblPriceHeader.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblPriceHeader.ForeColor = Color.Brown;
            lblPriceHeader.Location = new Point(497, 102);
            lblPriceHeader.Size = new Size(42, 18);
            lblPriceHeader.TabIndex = 34;
            lblPriceHeader.Text = "Price";
            // 
            // lblDFInteractionHeader
            // 
            lblDFInteractionHeader.AutoSize = true;
            lblDFInteractionHeader.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblDFInteractionHeader.ForeColor = Color.Brown;
            lblDFInteractionHeader.Location = new Point(252, 102);
            lblDFInteractionHeader.Size = new Size(156, 18);
            lblDFInteractionHeader.TabIndex = 33;
            lblDFInteractionHeader.Text = "Drug-Food_Interaction";
            // 
            // lblDDInteractionHeader
            // 
            lblDDInteractionHeader.AutoSize = true;
            lblDDInteractionHeader.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblDDInteractionHeader.ForeColor = Color.Brown;
            lblDDInteractionHeader.Location = new Point(249, 49);
            lblDDInteractionHeader.Size = new Size(150, 18);
            lblDDInteractionHeader.TabIndex = 32;
            lblDDInteractionHeader.Text = "Drug-Drug-Interaction";
            // 
            // lblPrecautionsHeader
            // 
            lblPrecautionsHeader.AutoSize = true;
            lblPrecautionsHeader.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblPrecautionsHeader.ForeColor = Color.Brown;
            lblPrecautionsHeader.Location = new Point(497, 49);
            lblPrecautionsHeader.Size = new Size(87, 18);
            lblPrecautionsHeader.Text = "Precuations";
            // 
            // lblUsageHeader
            // 
            lblUsageHeader.AutoSize = true;
            lblUsageHeader.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblUsageHeader.ForeColor = Color.Brown;
            lblUsageHeader.Location = new Point(45, 102);
            lblUsageHeader.Size = new Size(51, 18);
            lblUsageHeader.Text = "Usage";
            // 
            // lblSideEffectsHeader
            // 
            lblSideEffectsHeader.AutoSize = true;
            lblSideEffectsHeader.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblSideEffectsHeader.ForeColor = Color.Brown;
            lblSideEffectsHeader.Location = new Point(42, 49);
            lblSideEffectsHeader.Size = new Size(87, 18);
            lblSideEffectsHeader.Text = "Side Effects";
            // 
            // lblPriceText
            // 
            lblPriceText.AutoSize = true;
            lblPriceText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblPriceText.Location = new Point(509, 127);
            lblPriceText.Size = new Size(36, 18);
            lblPriceText.Text = medicine.get_price().ToString();
            // 
            // lblDFInteractionText
            // 
            lblDFInteractionText.AutoSize = true;
            lblDFInteractionText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblDFInteractionText.Location = new Point(264, 127);
            lblDFInteractionText.Size = new Size(36, 18);
            lblDFInteractionText.Text = medicine.get_drug_food_interaction();
            // 
            // lblDDInteractionText
            // 
            lblDDInteractionText.AutoSize = true;
            lblDDInteractionText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblDDInteractionText.Location = new Point(261, 74);
            lblDDInteractionText.Size = new Size(36, 18);
            lblDDInteractionText.Text = medicine.get_drug_drug_interaction();
            // 
            // lblPrecautionsText
            // 
            lblPrecautionsText.AutoSize = true;
            lblPrecautionsText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblPrecautionsText.Location = new Point(509, 74);
            lblPrecautionsText.Size = new Size(36, 18);
            lblPrecautionsText.Text = medicine.get_precautions();
            // 
            // lblUsageText
            // 
            lblUsageText.AutoSize = true;
            lblUsageText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblUsageText.Location = new Point(57, 127);
            lblUsageText.Size = new Size(36, 18);
            lblUsageText.Text = medicine.get_usage();
            // 
            // lblSideEffectText
            // 
            lblSideEffectText.AutoSize = true;
            lblSideEffectText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblSideEffectText.Location = new Point(54, 74);
            lblSideEffectText.Size = new Size(36, 18);
            lblSideEffectText.Text = medicine.get_side_effects();
            // 
            // lblNameText
            // 
            lblNameText.AutoSize = true;
            lblNameText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblNameText.ForeColor = Color.Brown;
            lblNameText.Location = new Point(15, 10);
            lblNameText.Size = new Size(52, 18);
            lblNameText.Text = medicine.get_name();
            //
            // AddToCartButton
            //
            btnAddToCart.BackColor = Color.Snow;
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btnAddToCart.ForeColor = Color.Green;
            btnAddToCart.Location = new Point(626, 3);
            btnAddToCart.Size = new Size(42, 37);
            btnAddToCart.TabIndex = 23;
            btnAddToCart.Text = "+";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += delegate
            {
                add_To_Cart(medicine.get_id(), int.Parse(numericUD.Value.ToString()),medicine.get_price(), medicine.get_name());
            };
            // 
            // numericUpDown
            // 
            numericUD.Location = new Point(500, 12);
            numericUD.Size = new Size(120, 20);
            numericUD.Minimum = 1;
            // 
            // pnlMedicineFloor
            // 
            pnlMedicineFloor.Controls.Add(numericUD);
            pnlMedicineFloor.Controls.Add(lblPriceText);
            pnlMedicineFloor.Controls.Add(lblDFInteractionText);
            pnlMedicineFloor.Controls.Add(lblDDInteractionText);
            pnlMedicineFloor.Controls.Add(lblPrecautionsText);
            pnlMedicineFloor.Controls.Add(lblUsageText);
            pnlMedicineFloor.Controls.Add(lblSideEffectText);
            pnlMedicineFloor.Controls.Add(lblPriceHeader);
            pnlMedicineFloor.Controls.Add(lblDFInteractionHeader);
            pnlMedicineFloor.Controls.Add(lblDDInteractionHeader);
            pnlMedicineFloor.Controls.Add(lblPrecautionsHeader);
            pnlMedicineFloor.Controls.Add(lblUsageHeader);
            pnlMedicineFloor.Controls.Add(lblSideEffectsHeader);
            pnlMedicineFloor.Controls.Add(btnAddToCart);
            pnlMedicineFloor.Controls.Add(lblNameText);
            pnlMedicineFloor.Location = new Point(5, 5);
            pnlMedicineFloor.Margin = new Padding(5);
            pnlMedicineFloor.Size = new Size(671, 159);
            pnlMedicineFloor.BackColor = Color.WhiteSmoke;

            //
            // flpSimilars
            //
            flpSimilars.Controls.Add(pnlMedicineFloor);
        }

        private void add_To_Cart(int id, int quantity, float price, string name)
        {
            if(currentPatient.get_currentUser() != null)
            {
                currentPatient.addToCart(id, quantity, price, name);
            }
            else
            {
                lblPleaseSignInFirst.Visible = true;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            quantity = int.Parse(numericUpDown1.Text);
            CurrentPatient currentPatinet = new CurrentPatient();
            if(currentPatinet.get_currentUser() == null)
            {
                lblSignInFirst.Visible = true;
            }
            else
            {
                currentPatinet.addToCart(this.m_id, this.quantity, this.price, this.name);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedicinePage_Click(object sender, EventArgs e)
        {
            btnMedicinePage.BackColor = Color.Snow;
            btnMedicinePage.ForeColor = Color.Brown;
            btnSimilarsPage.BackColor = Color.Brown;
            btnSimilarsPage.ForeColor = Color.Snow;
            tbControl.SelectTab(0);
        }

        private void btnSimilarsPage_Click(object sender, EventArgs e)
        {
            btnMedicinePage.BackColor = Color.Brown;
            btnMedicinePage.ForeColor = Color.Snow;
            btnSimilarsPage.BackColor = Color.Snow;
            btnSimilarsPage.ForeColor = Color.Brown;
            tbControl.SelectTab(1);
        }
    }
}
