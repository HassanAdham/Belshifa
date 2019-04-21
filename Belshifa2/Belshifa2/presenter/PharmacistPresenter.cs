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
        int id;
        Contractor.ViewContractor viewInstance;
        SystemDatabase dbObj;

        public PharmacistPresenter(Contractor.ViewContractor viewInstance)
        {
            id = 0;
            this.viewInstance = viewInstance;
            dbObj = new SystemDatabase(this);
        }

        public void signIn(string username, string password)
        {
            dbObj.signIn(username, password, true);
        }

        public void signUp(object person)
        {
            throw new NotImplementedException();
        }

        public bool doesItExist(string email)
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

        public void modelErrorMessage(string message)
        {
            viewInstance.displayError(message);
        }

        public void modelResponse(string message)
        {
            viewInstance.displayMessage(message);
        }

        public void sendData(List<object> returnedValues)
        {
            throw new NotImplementedException();
        }

        public void save(int id)
        {
            throw new NotImplementedException();
        }

    }
}
