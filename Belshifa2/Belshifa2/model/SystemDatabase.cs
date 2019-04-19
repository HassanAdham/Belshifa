using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa2.model
{
    class SystemDatabase
    {
        public SystemDatabase()
        {
            //Connection w kda.
        }

        public void signIn(string username, string password, bool type)// 0 for patient 1 for pharm
        {
            throw new NotImplementedException();
        }

        public void signUp(Object person, bool type) // 0 for patient 1 for pharm.
        {
            throw new NotImplementedException();
        }

        public void getProfile(int id, bool type) // 0 for patient 1 for pharm.
        {
            throw new NotImplementedException();
        }


        public void getOrderHistory(int id) // for patient.
        {
            throw new NotImplementedException();
        }

        public void getPatientPendingOrders(int id)
        {
            throw new NotImplementedException();
        }

        public void getPharmacistPendingOrders(int id)
        {
            throw new NotImplementedException();
        }

        public void getMedicines(int sec_id)
        {

        }

        public void getSections()
        {

        }
    }
}
