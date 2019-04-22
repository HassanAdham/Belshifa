using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa2.dataClasses
{
    class Medecine
    {
        private int id; //Primary key.
        private string name;
        private int quantity;
        private float price;
        private string side_effects;
        private string usage;
        private string precautions;
        private string drug_drug_interaction;
        private string drug_food_interaction;
        private int sec_id;
        private string image_src;

        public Medecine(int id, string name, int quantity, float price,
                        string side_effects, string usage, string precautions,
                        string drug_drug_interaction, string drug_food_interaction,
                        int sec_id, string image_src)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.side_effects = side_effects;
            this.usage = usage;
            this.precautions = precautions;
            this.drug_drug_interaction = drug_drug_interaction;
            this.drug_food_interaction = drug_food_interaction;
            this.sec_id = sec_id;
            this.image_src = image_src;
        }

        public int get_id()
        {
            return this.id;
        }

        public string get_name()
        {
            return this.name;
        }

        public int get_quantity()
        {
            return this.quantity;
        }

        public float get_price()
        {
            return this.price;
        }

        public string get_side_effects()
        {
            return this.side_effects;
        }

        public string get_usage()
        {
            return this.usage;
        }

        public string get_precautions()
        {
            return this.precautions;
        }

        public string get_drug_drug_interaction()
        {
            return this.drug_drug_interaction;
        }

        public string get_drug_food_interaction()
        {
            return this.drug_food_interaction;
        }

        public int get_sec_id()
        {
            return this.sec_id;
        }

        public string get_image_src()
        {
            return this.image_src;
        }
    }

}
