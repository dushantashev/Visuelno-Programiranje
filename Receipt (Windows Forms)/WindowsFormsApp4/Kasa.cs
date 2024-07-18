using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Kasa
    {
        private List<Stavka> stavka=new List<Stavka>();

        public void AddItem(Product product, int quantity)
        {
            stavka.Add(new Stavka(product, quantity));
        }
        public int GetQuantityForProduct(Product produkt)
        {
            Stavka postoeckaStavka = stavka.FirstOrDefault(s => s.Product.Code == produkt.Code);
            return postoeckaStavka != null ? postoeckaStavka.Quantity : 0;
        }

    }
}
