using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public Product() { }

        public int ProductId { get; set; }    
        public string ProdName { get; set; }             

        /// <summary>
        /// creates a copy of the product object
        /// </summary>
        /// <returns>a product object</returns>
        public Product CopyProduct()
        {
            Product copy = new Product();
            copy.ProductId = ProductId; ; 
            copy.ProdName = ProdName;
            return copy;
        }
    }
}
