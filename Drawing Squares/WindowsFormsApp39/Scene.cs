using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp39
{
    public class Scene
    {
        public List<Retangle> retangles { get; set; }
        public Scene()
        {
            retangles = new List<Retangle>();
        }
        public void AddRetangle(int height, int width, Point point, Color color)
        {


            retangles.Add(new Retangle(height, width, point, color));
        }

        public void Draw(Graphics g)
        {
            foreach(Retangle retangle in retangles)
            {
                retangle.Draw(g);
            }
        }
    }
}
