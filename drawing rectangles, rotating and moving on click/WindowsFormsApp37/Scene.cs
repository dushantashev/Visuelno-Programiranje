using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp37
{
    public class Scene
    {
        List<Retangle> retangles {  get; set; }
        public Color Color { get; set; } = Color.GreenYellow;
        public Scene()
        {
            retangles = new List<Retangle>();
        }
        public void Draw(Graphics g)
        {
            foreach (Retangle retangle in retangles)
            {
                retangle.Draw(g);
                
            }

        }

        public void AddRetangle(Point location)
        {
            retangles.Add(new Retangle(20, 80, location, Color));

        }
       
        public void Hit(Point location)
        {
            foreach(Retangle retangle in retangles)
            {
                if (retangle.Hit(location) == true)
                {
                    retangle.flag = 1;
                    
                }
            }
        }
        public void Hit2(Point location)
        {
            foreach (Retangle retangle in retangles)
            {
                if (retangle.Hit(location) == true)
                {
                    retangle.flag = 2;
                    int temp = retangle.WidthRet;
                    retangle.WidthRet = retangle.HeightRet;
                    retangle.HeightRet = temp;
                }
            }
        }

        public void Move()
        {
            for(int i=retangles.Count-1; i>=0; i--)
            {
                if (retangles[i].flag == 1)
                {
                    retangles[i].Move(0, 20);
                }
            }
        }
        public void Move2()
        {
            for (int i = retangles.Count - 1; i >= 0; i--)
            {
                if (retangles[i].flag == 2)
                {
                    retangles[i].Move(20, 0);
                    retangles[i].color= Color.Red;

                    
                }
            }
        }


    }
}
