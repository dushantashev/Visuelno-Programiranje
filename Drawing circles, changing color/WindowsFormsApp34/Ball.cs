using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp34
{
    public class Ball
    {
        public Point p { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Color Color { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B{ get; set; }

        public Ball(Point p, int width, int height, Color color)
        {
            this.p = p;
            this.width = width;
            this.height = height;
            Color = color;
            Random random= new Random();
            R = random.Next(256);
            G = random.Next(256);
            B = random.Next(256);
        }
        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.FromArgb(R,G,B));
            g.FillEllipse(brush,p.X,p.Y,width,height);
            brush.Dispose();
        }
        public void ChangeColor()
        {
            R = R + 5;
            G = G + 10;
            B = B + 15;
            R = R % 256;
            G = G % 256;
            B= B % 256;
        }
    }
}
