using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belshifa2.dataClasses;

namespace Belshifa2.presenter
{
    class Contractor
    {
        public interface ViewContractor
        {
            void display(List<Object> returnedValues); //obect is for generic data.
            void goToNextPage();
            void displayError(string error);
            void displayMessage(string message);
        }

        public interface PresenterContractor
        {
            void signIn(string username, string password);
            void signUp(Object person);

            bool doesItExist(string email);

            void getProfile(); //email or username.
            void getOrderHistory(int id);
            void getPendingOrders(int id);

            void set_key(string key);
            string get_key();
            void clear_key();
            void sendData(List<Object> returnedValues);
            void modelResponse(string message);
            void modelErrorMessage(string message);
        }
    }
}
