using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class Linija
    {
        public string Destinacija { get; set; }
        public int ChasNaTrgnuvanje { get; set; }
        public int MinutaNaTrgnuvanje { get; set; }
        public int Cena { get; set; }

        public Linija(string destinacija, int chasNaTrgnuvanje, int minutaNaTrgnuvanje, int cena)
        {
            Destinacija = destinacija;
            ChasNaTrgnuvanje = chasNaTrgnuvanje;
            MinutaNaTrgnuvanje = minutaNaTrgnuvanje;
            Cena = cena; 
       }
        public override string ToString()
        {
            return string.Format("{0}:{1}-{2}-{3}Ден.", ChasNaTrgnuvanje, MinutaNaTrgnuvanje, Destinacija, Cena);
        }
    }
}
