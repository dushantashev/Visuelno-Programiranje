using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace WindowsFormsApp44
{
    public class Scene
    {
      public Polygon CurrentPolygon { get; set; }
        public List<Polygon> Polygons { get; set; }

        public Scene() {
            CurrentPolygon = new Polygon();
            Polygons = new List<Polygon>();
                }
        public void addPoint(Point p)
        {
            CurrentPolygon.AddPoint(p);
            if (CurrentPolygon.isComplited) {
            Polygons.Add(CurrentPolygon); 
                CurrentPolygon=new Polygon();
                
            }
        }
        public void Draw(Graphics g) 
            {
                CurrentPolygon.Draw(g);
           foreach (Polygon p in Polygons)
            {
                p.Draw(g);
            }
            } 
    
    
    }
}
