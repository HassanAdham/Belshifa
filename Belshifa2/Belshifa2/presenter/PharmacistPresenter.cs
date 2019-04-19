using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belshifa2.model;
namespace Belshifa2.presenter
{
    public class PharmacistPresenter : Contractor.PharmacistPresenterContractor
    {
        Contractor.ViewContractor viewInstance;
        SystemDatabase dbObj;


        PharmacistPresenter(Contractor.ViewContractor viewInstance)
        {
            this.viewInstance = viewInstance;
            if (dbObj == null)
                dbObj = new SystemDatabase();
        }

        public void getPendingOrders()
        {
            throw new NotImplementedException();
        }

        public void save() //After editing pending orders to approved an rejected, save the changes.
        {
            throw new NotImplementedException();
        }

        public void sendData(List<object> returnedValues)
        {
            throw new NotImplementedException();
        }

        public void sendError(string error)
        {
            throw new NotImplementedException();
        }

        public void sendResponse(string response)
        {
            throw new NotImplementedException();
        }
    }
}
