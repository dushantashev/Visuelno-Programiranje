using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Avtobusi
    {
        public string Registacija { get; set; }
        public string Ime { get; set; }
        public bool Lokalen { get; set; }
        public List<Linija> linija { get; set; }

        public Avtobusi(string registacija, string ime, bool lokalen)
        {
            Registacija = registacija;
            Ime = ime;
            Lokalen = lokalen;
            linija = new List<Linija>();    
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}",Ime,Registacija,lokl());
        }
        public string lokl()
        {
            if (Lokalen.ToString() == "True")
            {
                return string.Format("L");
            }
            else
                return string.Format("M");
        }

        public void AddDestination(Linija line)
        {
            linija.Add(line);
        }

    }
}
