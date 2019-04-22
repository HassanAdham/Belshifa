using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belshifa2.dataClasses;
using Belshifa2.model;
namespace Belshifa2.presenter
{
    class PatientPresenter : Contractor.PresenterContractor
    {

        Contractor.ViewContractor viewInstance;
        SystemDatabase dbObj;
        Patient currentPatient;
        List<int> cart;
        string email;

        public PatientPresenter()
        {
            email = "";
            cart = new List<int>();
        }
        public PatientPresenter(Contractor.ViewContractor viewInstance)
        {
            email = "";
            currentPatient = new Patient();
            cart = new List<int>();
            this.viewInstance = viewInstance;
            dbObj = new SystemDatabase(this);
        }

        public void signIn(string email, string password)
        {
            dbObj.signIn(email, password, false); //Patient
        }
        public void signUp(object person)
        {
            dbObj.signUp(person, false);
        }

        public bool doesItExist(string email)
        {
            //Call database.
            return false;
        }

        public List<int> get_Cart()
        {
            if (email != "")
                return this.cart;
            else
                return null;
        }

        public void getOrderHistory(int id)
        {
            throw new NotImplementedException();
        }

        public void getPendingOrders(int id)
        {
            throw new NotImplementedException();
        }

        public void order()
        {
            if(email!="")
                dbObj.makeOrder(this.email, cart);
        }

        public void modelResponse(string message)
        {
            viewInstance.displayMessage(message);
        }
        public void sendData(List<object> returnedValues, string type)
        {
            viewInstance.display(returnedValues, type);
        }
        public void modelErrorMessage(string message)
        {
            viewInstance.displayError(message);
        }

        public void set_profile(string email) //When signing in.
        {
            this.email = email;
            this.currentPatient = (Patient)dbObj.getProfile(email, false);
        }
        public object get_profile()
        {
            return this.currentPatient;
        }
        public string get_key()
        {
            return this.email;
        }
        public void clear_person() //When signing out.
        {
            this.email = "";
            this.currentPatient = new Patient();
            cart.Clear();
        }

        public void get_sections()
        {
            dbObj.getSections();
        }
        public void get_medicines(int sec_id)
        {
            dbObj.getMedicines(sec_id);
        }

        public void add_To_Cart(int medicine_id)
        {
            if (email != "")
                cart.Add(medicine_id);
            else
                viewInstance.displayMessage("Please sign in first!");
        }

    }
}
