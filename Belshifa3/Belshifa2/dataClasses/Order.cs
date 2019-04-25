using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa2.dataClasses
{
    class Order
    {
        int orderId; //Primary key.
        string orderDate;
        string deliveryDate;
        float totalPrice;
        string patient_email; //FK
        string ph_username; //FK
        int pharmacy_id; //FK

        public Order(int orderId, string orderDate, string deliveryDate,
            float totalPrice, string patient_email, string ph_username, int pharmacy_id)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.deliveryDate = deliveryDate;
            this.totalPrice = totalPrice;
            this.patient_email = patient_email;
            this.ph_username = ph_username;
            this.pharmacy_id = pharmacy_id;
        }

        public int get_orderId()
        {
            return this.orderId;
        }

        public string get_deliveryDate()
        {
            return this.deliveryDate;
        }

        public string get_orderDate()
        {
            return this.orderDate;
        }

        public float get_totalPrice()
        {
            return this.totalPrice;
        }

        public string get_patient_email()
        {
            return this.patient_email;
        }

        public string get_ph_username()
        {
            return this.ph_username;
        }

        public int get_pharmacy_id()
        {
            return this.pharmacy_id;
        }
    }
}
