using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa2.dataClasses
{
    class Pharmacist
    {
        private string username { set; get; }
        private string password { set; get; }
        private int pharmacy_id { set; get; }

        public Pharmacist(string username, string password, int pharmacy_id)
        {
            this.username = username;
            this.password = password;
            this.pharmacy_id = pharmacy_id;
        }
    }
}
