using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport2
{
    public class Airport
    {
        public string Grad { get; set; }
        public string Ime { get; set; }
        public string Kratenka { get; set; }
        public List<Destinacion> Destinacions { get; set; }


        public Airport(string grad, string ime, string kratenka)
        {
            Grad = grad;
            Ime = ime;
            Kratenka = kratenka;
            
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Kratenka, Ime, Grad);
        }
    }
}
