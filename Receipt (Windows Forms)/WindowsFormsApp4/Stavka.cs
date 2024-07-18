using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Stavka
    {
        public Product Product { get; set; }    
        public int Quantity {  get; set; }

        public Stavka() { }
     

        public Stavka(Product product, int quantity) {
            Product = product;
            quantity = Quantity;
        }

    }
}
