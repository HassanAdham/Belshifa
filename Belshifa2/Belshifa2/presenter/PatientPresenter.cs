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
        int id;

        public PatientPresenter(Contractor.ViewContractor viewInstance)
        {
            id = 0;
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

        public void signUp(Object Person)
        {

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

        public void getProfile(int id)
        {
            throw new NotImplementedException();
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

    }
}
