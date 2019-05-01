using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa2.dataClasses
{
    class Section
    {
        int id; //Primary key.
        string name;

        public Section(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int get_id()
        {
            return this.id;
        }
        public string get_name()
        {
            return this.name;
        }
    }
}
