using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public Team()
        {

        }

        public Team(string name, string country)
        {
            Name = name;  
            Country = country;

        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", Name, Country);
        }
        
    }
   
}
