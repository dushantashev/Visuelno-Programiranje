using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp43
{
    public class Ball
    {
        public Point Center { get; set; }
        public int  Height { get; set; }
        public int Width { get; set; }
        public Color Color { get; set; }

        public Ball(Point center, int height, int width, Color color)
        {
            Center = center;
            this.Height = height;
            this.Width = width;
            Color = color;
        }
        public void Draw(Graphics e)
        {
            Brush brush = new SolidBrush(Color);
            e.FillEllipse(brush,Center.X,Center.Y,Width,Height);
            brush.Dispose();
        }
        public void Action()
        {
            Random rnd = new Random();
           int c = rnd.Next(2);
            switch(c)
            {
                case 0:
                    Color= Color.Yellow;
                    break;
                    case 1:
                    Color = Color.YellowGreen;
                    break;
            }
        }
    }
}
