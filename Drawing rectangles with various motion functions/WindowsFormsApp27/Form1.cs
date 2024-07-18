using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        public Scene Scene;
        int width;
        int height;
        int flag = 2;
       
        public Form1()
        {
           
            InitializeComponent();
            Scene = new Scene();
            timer1.Start();
            width = this.Width;
           
            height = this.Height;
            update();
           
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.isHit(e.Location);
            if (e.Button == MouseButtons.Left)
            {
                flag = 1;
                foreach (var item in Scene.Retangles)
                {
                    if (item.isHit == true)
                    {
                        item.Color = Color.Red;
                        item.Width = 30;
                        item.Height = 60;
                    }
                }
            }
            else
            {
                flag = 0;
            }


        }
        public void Draw(Graphics g)
        {
            foreach (var item in Scene.Retangles)
            {

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            Point point = e.Location;
            Retagle retangle = new Retagle(30, 60, point, Color.BlueViolet);
            Scene.Retangles.Add(retangle);
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(flag==1)
            Scene.moveRatated(width, height);
            else
                Scene.move(width, height);
            Scene.remove();


            update();

            Invalidate();

        }
        public void update()
        {
            toolStripStatusLabel1.Text = "Active: "+Scene.Retangles.Count();
           
        }
    }
}
