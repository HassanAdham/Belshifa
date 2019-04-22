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
        List<Medecine> cart;
        string email;

        public PatientPresenter()
        {
            email = "";
            cart = new List<Medecine>();
        }
        public PatientPresenter(Contractor.ViewContractor viewInstance)
        {
            email = "";
            cart = new List<Medecine>();
            this.viewInstance = viewInstance;
            dbObj = new SystemDatabase(this);
        }

        public void signIn(string email, string password)
        {
            dbObj.signIn(email, password, false); //Patient
        }

        public void modelResponse(string message)
        {
            viewInstance.displayMessage(message);
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

        public void getCart(int id)
        {
            throw new NotImplementedException();
        }

        public void getProfile()
        {
            if (this.email != "")
                dbObj.getProfile(this.email, false);
        }

        public void getOrderHistory(int id)
        {
            throw new NotImplementedException();
        }

        public void getPendingOrders(int id)
        {
            throw new NotImplementedException();
        }

        public void order(int id)
        {
            throw new NotImplementedException();
        }

        public void sendData(List<object> returnedValues)
        {
            throw new NotImplementedException();
        }

        public void modelErrorMessage(string message)
        {
            viewInstance.displayError(message);
        }

        public void set_key(string email) //When signing in.
        {
            this.email = email;
        }
        public string get_key()
        {
            return this.email;
        }
        public void clear_key() //When signing out.
        {
            this.email = "";
        }

    }
}
