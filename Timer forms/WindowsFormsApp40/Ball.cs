using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp40
{
    public class Ball
    {
        public Color Color { get; set; }
        public Point Center { get; set; }
        public int Radius { get; set; }
        public int State { get; set; }

        public Ball(Color color, Point center, int radius)
        {
            Color = color;
            Center = center;
            Radius = radius;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            if (State == 0)
            {
                
                g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                brush.Dispose();
            }
            else if(State == 1)
            {
                g.FillPie(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius, 0, 270);
               
                brush.Dispose();
            }
            else if( State == 2)
            {
                g.FillPie(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius, 0, 180);
                brush.Dispose();
            }
            else if (State == 3){
                g.FillPie(brush, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius, 0, 90);
                brush.Dispose() ;
            }

        }
      


    }
}
