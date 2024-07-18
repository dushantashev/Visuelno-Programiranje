using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    public class Datum
    {
        public string Data { get; set; }
        public List<Temperatura> Temperatura;

        public Datum(string data)
        {
            Data = data;
            Temperatura = new List<Temperatura>();
        }
        public override string ToString() {
            return string.Format("{0}", Data);
        }
        public void addTemp(Temperatura temperatura)
        {
            Temperatura.Add(temperatura);
        }

    }
}
