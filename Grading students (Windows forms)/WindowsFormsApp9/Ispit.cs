using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    public class Ispit
    {

        public string Month { get; set; }
        public int Year { get; set; }
        public List<Zadachi> zadacha1;
        public List<Zadachi> zadacha2;

        public Ispit(string month, int year)
        {
            Month = month;
            Year = year;
            zadacha1 = new List<Zadachi>();
            zadacha2= new List<Zadachi>();
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}",Year,Month);
        }

        public void AddZadacha1(Zadachi zadachi)
        {
            zadacha1.Add(zadachi);
        }

        public void AddZadacha2(Zadachi zadachi)
        {
            zadacha2.Add(zadachi);
        }
    }
}
