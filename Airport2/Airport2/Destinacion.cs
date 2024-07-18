using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport2
{
    public class Destinacion
    {
        public string ImeNaDestinacija { get; set; }
        public int Odalechenost { get; set; }
        public int cena { get; set; }

      
        public Destinacion(string imeNaDestinacija, int odalechenost, int cena)
        {
            ImeNaDestinacija = imeNaDestinacija;
            Odalechenost = odalechenost;
            this.cena = cena;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}km - {2}EUR", ImeNaDestinacija, Odalechenost, cena);

        }
    }
}
