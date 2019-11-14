using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Supplier
    {
        public Supplier() { }

        public int SupplierId { get; set; }  
        public string SupName { get; set; }  

        /// <summary>
        /// creates a copy of the supplier object
        /// </summary>
        /// <returns>a suppier object</returns>
        public Supplier CopySupplier()
        {
            Supplier copy = new Supplier();
            copy.SupplierId = SupplierId; ;
            copy.SupName = SupName;
            return copy;
        }
    }
}
