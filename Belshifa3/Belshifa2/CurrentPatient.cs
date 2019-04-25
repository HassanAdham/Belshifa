using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belshifa2.dataClasses;
namespace Belshifa2
{
    class CurrentPatient
    {
        static Patient patient;
        static List<int> cart;

        public void initialize_List()
        {
            cart = new List<int>();
        }
        public void set_currentUser(Patient p)
        {
            patient = p;
        }

        public Patient get_currentUser()
        {
            return patient;
        }

        public List<int> get_cart()
        {
            return cart;
        }
        public void addToCart(int id)
        {
            cart.Add(id);
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
