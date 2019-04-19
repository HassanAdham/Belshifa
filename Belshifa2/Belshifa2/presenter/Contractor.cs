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

        public interface PatientPresenterContractor
        {
            void signIn(string username, string password);
            void signUp(Patient patient);
            void sendRespone(string message); //Used when signed in or signed up is valid.

            void getCart(int id);
            void getProfile(int id);
            void getOrderHistory(int id);
            void getPendingOrders(int id);

            void sendData(List<Object> returnedValues);
        }


        public interface PharmacistPresenterContractor
        {
            void getPendingOrders();
            void sendData(List<Object> returnedValues);

            void save();
            void sendResponse(string response);
            void sendError(string error);
        }
    }
}
