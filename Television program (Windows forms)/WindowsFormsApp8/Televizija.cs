using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Televizija
    {
        public string Name { get; set; }
        public int Number { get; set; }

       public List<Emisija> Emisija;

        public Televizija(string name,int number)
        {
            this.Name = name;
            this.Number = number;
            Emisija = new List<Emisija>();
        }

        public void addEmisija(Emisija emisija)
        {
            Emisija.Add(emisija);
        }
        
        public override string ToString()
        {
            return string.Format("{0}. {1}", Number, Name);
        }

    }
}
