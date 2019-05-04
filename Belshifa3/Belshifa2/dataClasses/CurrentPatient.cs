using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belshifa2.dataClasses;
namespace Belshifa2
{
    //----------------------------Each item in the cart has quantity and price----------------
    class MedicineInfo
    {
        int quantity;
        float price; //price per each item.
        string name;
        string img;

        public MedicineInfo(int quantity, float price, string name, string img)
        {
            this.quantity = quantity;
            this.price = price;
            this.name = name;
            this.img = img;
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
        public string get_image()
        {
            return this.img;
        }
    }



    //----------This class holds all the information needed about a patient when he/she is signed in----------
    /*So that it is shared in all classes and forms.*/
    class CurrentPatient
    {
        static Patient patient; //Personal information.
        static List<string> notifications; //A list of messages from the database.
        static Dictionary<int, MedicineInfo> cart; //Id of medicine, (Quantity, Price) of medicine.
        public void initialize_List()
        {
            cart = new Dictionary<int, MedicineInfo>();
            notifications = new List<string>();
        }

        //----------------------------User and personal information-----------------------
        /*A new user has signed in.*/
        public void set_currentUser(Patient p)
        {
            patient = p;
        }
        /*To get any perosnal information later.*/
        public Patient get_currentUser()
        {
            return patient;
        }

        //-----------------------------------------Cart------------------------------------
        public void addToCart(int id, int quantity, float price, string name, string img)
        {
            MedicineInfo qp = new MedicineInfo(quantity, price, name, img);
            cart[id] = qp;
        }
        /*Returning cart to be displayed in the cart list.*/
        public Dictionary<int, MedicineInfo> get_cart()
        {
            return cart;
        }
        public void removeFromCart(int id)
        {
            cart.Remove(id);
        }
        public void clearCart()
        {
            cart.Clear();
        }

        //---------------------------------------Notifications-----------------------------
        public void set_notifications(List<string> notifyLit)
        {
            notifications = notifyLit;
        }
        public List<string> get_notifications()
        {
            return notifications;
        }
        public void clearNotificiationsList()
        {
            notifications.Clear();
        }

        //--------------------------------Clear Everything---------------------------------
        public void signOut()
        {
            cart.Clear();
            notifications.Clear();
            patient = null;
        }
    }
}
