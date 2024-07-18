using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
    
        public Product() { }
        public Product(int code, string name, decimal price)
        {
            Code = code;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1} {2}.00",Code, Name,Price);
        }

    }



}
