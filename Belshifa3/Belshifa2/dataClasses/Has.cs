using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa2.dataClasses
{
    class Has
    {
        private int oid;
        public List<int> OMID;
        int quantity;
        public Has()
        {
            oid = 0;
            OMID = new List<int>();
            quantity = 0;
        }
        public void Set_OID (int oid)
        {
            this.oid = oid;
        }
        public void Set_MIDS(List<int>MIDS)
        {
            this.OMID = MIDS;
        }
        public void Set_Quantity(int Quant)
        {
            this.quantity = Quant;
        }
    }
}
