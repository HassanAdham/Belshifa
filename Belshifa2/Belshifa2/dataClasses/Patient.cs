using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa2.dataClasses
{
    public class Patient
    {
        private string f_name { set; get; }
        private string l_name { set; get; }
        private string password { set; get; }
        private string address { set; get; }
        private string phone { set; get; }
        private string email { set; get; }
        private string payment { set; get; }
        private string birthdate { set; get; }

        public Patient(string f_name, string l_name, string password,
            string address, string phone, string email, string payment, string birthdate)
        {
            this.f_name = f_name;
            this.l_name = l_name;
            this.password = password;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.birthdate = birthdate;
        }
    }
}
