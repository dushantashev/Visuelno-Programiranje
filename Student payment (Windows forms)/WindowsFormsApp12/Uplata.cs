using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    public class Uplata
    {
        public int Suma { get; set; }

        public Uplata(int suma)
        {
            Suma = suma;
        }

        public override string ToString()
        {
           
            double provizija = (Suma / 100) * 1.14;
            return string.Format("Уплата:{0} Провизија:{1} Вкупно:{2}\n",Suma,provizija,(Suma+provizija));        
        }
    }
}
