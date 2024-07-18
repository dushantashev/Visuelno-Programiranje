using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    public class Zadachi
    {
        public string Opsis { get; set; }
        public int Poeni { get; set; }
       

        public Zadachi(string opsis, int poeni)
        {
            Opsis = opsis;
            Poeni = poeni;
        }
       
        public string zad1Details()
        {
            return string.Format("{0}", Opsis);
        }
        public int zad2Details()
        {
            return Poeni;
        }
    }
}
