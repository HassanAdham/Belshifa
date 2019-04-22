using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa2.dataClasses
{
    public class Patient
    {
        private string f_name;
        private string l_name;
        private string password;
        private string address;
        private string phone;
        private string email;   //Primary key.
        private string payment;
        private string birthdate;

        public Patient()
        {
            f_name = "";
            l_name = "";
            password = "";
            phone = "";
            address = "";
            email = "";
            payment = "";
            birthdate = "";
        }
        public Patient(string f_name, string l_name, string password,
            string address, string phone, string email, string payment, string birthdate)
        {
            this.phone = phone;
            this.email = email;
            this.f_name = f_name;
            this.l_name = l_name;
            this.address = address;
            this.payment = payment;
            this.password = password;
            this.birthdate = birthdate;
        }

        public void set_phone(string phone)
        {
            this.phone = phone;
        }
        public void set_email(string email)
        {
            this.email = email;
        }
        public void set_password(string password)
        {
            this.password = password;
        }
        public void set_f_name(string f_name)
        {
            this.f_name = f_name;
        }
        public void set_l_name(string l_name)
        {
            this.l_name = l_name;
        }
        public void set_address(string address)
        {
            this.address = address;
        }
        public void set_birthdate(string birthdate)
        {
            this.birthdate = birthdate;
        }
        public void set_payment(string payment)
        {
            this.payment = payment;
        }

        public string get_phone()
        {
            return this.phone;
        }
        public string get_email()
        {
            return this.email;
        }
        public string get_password()
        {
            return this.password;
        }
        public string get_f_name()
        {
            return this.f_name;
        }
        public string get_l_name()
        {
            return this.l_name;
        }
        public string get_address()
        {
            return this.address;
        }
        public string get_birthdate()
        {
            return this.birthdate;
        }
        public string get_payment()
        {
            return this.payment;
        }

    }
}
