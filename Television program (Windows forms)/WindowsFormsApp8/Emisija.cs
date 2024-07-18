using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Emisija
    {
        public string Name { get; set; }
        public int Vremetraenje { get; set; }

        public Emisija(string name, int vremetraenje)
        {
            Name = name;
            Vremetraenje = vremetraenje;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Vremetraenje);
        }
    }
}
