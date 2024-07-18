using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    public class Student
    {
        public string Name { get; set; }
        public string  Index { get; set; }

        public List<Uplata> uplatas;

        public Student(string name, string index)
        {
            Name = name;
            Index = index;
            uplatas = new List<Uplata>();
        }
        public override string ToString()
        {
            return string.Format("{0} {1}",Index,Name);
        }

        public void addUpalata(Uplata up)
        {
            uplatas.Add(up);
        }
        

    }

}
