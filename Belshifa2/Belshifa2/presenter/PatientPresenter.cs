using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belshifa2.dataClasses;
using Belshifa2.model;
namespace Belshifa2.presenter
{
    class PatientPresenter : Contractor.PatientPresenterContractor
    {

        Contractor.ViewContractor viewInstance;
        SystemDatabase dbObj;
        Patient currentPatient;


        public PatientPresenter(Contractor.ViewContractor viewInstance)
        {
            this.viewInstance = viewInstance;
            if (dbObj == null)
                dbObj = new SystemDatabase();
        }
        public void signIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void signUp(Patient patient)
        {
            throw new NotImplementedException();
        }

        public void getProfile(int id)
        {
            throw new NotImplementedException();
        }

        public void getCart(int id)
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

        public void sendData(List<object> returnedValues)
        {
            throw new NotImplementedException();
        }

        public void sendRespone(string message)
        {
            throw new NotImplementedException();
        }
    }
}
