using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belshifa2.dataClasses;
namespace Belshifa2
{
    class QuantPrice
    {
        int quantity;
        float price; //price per each item.
        string name;

        public QuantPrice(int quantity, float price, string name)
        {
            this.quantity = quantity;
            this.price = price;
            this.name = name;
        }
        public void set_quantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int  get_quantity()
        {
            return this.quantity;
        }
        public float get_price()
        {
            return this.price;
        }
        public string get_name()
        {
            return this.name;
        }
    }
    class CurrentPatient
    {
        static Patient patient;
        static Dictionary<int,QuantPrice> cart;
        public void initialize_List()
        {
            cart = new Dictionary<int,QuantPrice>();
        }

        public void set_currentUser(Patient p)
        {
            patient = p;
        }

        public Patient get_currentUser()
        {
            return patient;
        }

        public Dictionary<int,QuantPrice> get_cart()
        {
            return cart;
        }

        public void addToCart(int id, int quantity, float price, string name)
        {
            QuantPrice qp = new QuantPrice(quantity, price, name);
            cart[id] = qp;
        }
        public void removeFromCart(int id)
        {
            cart.Remove(id);
        }
        public void clearCart()
        {
            cart.Clear();
        }
        public void signOut()
        {
            cart.Clear();
            patient = null;
        }
    }
}
