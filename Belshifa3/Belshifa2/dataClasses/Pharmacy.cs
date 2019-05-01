using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa2.dataClasses
{
    class Pharmacy
    {
        int id;
        string name;
        string address;

        public Pharmacy(int id, string address, string name)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public int get_id()
        {
            return id;
        }
        public string get_name()
        {
            return name;
        }
        public string get_address()
        {
            return address;
        }
    }
}
