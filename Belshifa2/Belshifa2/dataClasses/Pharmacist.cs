using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa2.dataClasses
{
    class Pharmacist
    {
        private string username;
        private string password;
        private int pharmacy_id;

        public Pharmacist(string username, string password, int pharmacy_id)
        {
            this.username = username;
            this.password = password;
            this.pharmacy_id = pharmacy_id;
        }

        public void set_username(string username)
        {
            this.username = username;
        }
        public void set_password(string password)
        {
            this.password = password;
        }
        public void set_pharmacy_id(int id)
        {
            this.pharmacy_id = id;
        }

        public string get_username()
        {
            return this.username;
        }
        public string get_password()
        {
            return this.password;
        }
        public int get_pharmacy_id()
        {
            return this.pharmacy_id;
        }
    }
}
