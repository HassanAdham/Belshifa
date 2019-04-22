using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belshifa2.presenter;
using Belshifa2.dataClasses;
using Belshifa2.model;
namespace Belshifa2.presenter
{
    class PharmacistPresenter : Contractor.PresenterContractor
    {
        string username;
        Pharmacist currentPharmacist;
        Contractor.ViewContractor viewInstance;
        SystemDatabase dbObj;


        public PharmacistPresenter()
        {
            username = "";
        }
        public PharmacistPresenter(Contractor.ViewContractor viewInstance)
        {
            username = "";
            this.viewInstance = viewInstance;
            dbObj = new SystemDatabase(this);
        }

        public void signIn(string username, string password)
        {
            dbObj.signIn(username, password, true);
        }

        public void signUp(object person)
        {
            dbObj.signUp(person, true);
        }

        public bool doesItExist(string email)
        {
            throw new NotImplementedException();
        }

        public void getProfile()
        {
            if (this.username != "")
                dbObj.getProfile(username, true);
        }

        public void getOrderHistory(int id)
        {
            throw new NotImplementedException();
        }

        public void getPendingOrders(int id)
        {
            throw new NotImplementedException();
        }

        public void modelErrorMessage(string message)
        {
            viewInstance.displayError(message);
        }

        public void modelResponse(string message)
        {
            viewInstance.displayMessage(message);
        }

        public void sendData(List<object> returnedValues, string type)
        {
            throw new NotImplementedException();
        }

        public void save(int id)
        {
            throw new NotImplementedException();
        }

        public void set_profile(string username)
        {
            this.username = username;
            this.currentPharmacist = (Pharmacist)dbObj.getProfile(username, true);
        }

        public object get_profile()
        {
            return this.currentPharmacist;
        }

        public string get_key()
        {
            return this.username;
        }
        public void clear_person()
        {
            this.username = "";
            this.currentPharmacist = new Pharmacist();

        }

    }
}
