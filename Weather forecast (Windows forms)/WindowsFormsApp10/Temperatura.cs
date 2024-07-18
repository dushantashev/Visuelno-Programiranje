using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    public class Temperatura
    {
        public int maksimalnaTemperatura { get; set; }
        public int minimalnaTemperatura { get; set; }

        public Temperatura(int maksimalnaTemperatura, int minimalnaTemperatura)
        {
            this.maksimalnaTemperatura = maksimalnaTemperatura;
            this.minimalnaTemperatura = minimalnaTemperatura;
        }

        public int maxTemp()
        {
            return maksimalnaTemperatura;
        }
        public int minTemp()
        {
            return minimalnaTemperatura;
        }
    }
}
