using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
       public Scene Scene {  get; set; }

        public Form1()
        {
            InitializeComponent();
            Scene=new Scene(Width, Height);
            timer1.Start();
            DoubleBuffered = true;
            update();
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Invalidate();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Scene.Click(e.Location, Color.Red);

                Invalidate();
            }
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Random random = new Random();
                Color red = Color.Blue;
                Color green = Color.Green;
                Color color = (random.Next(2) == 0) ? red : green;
                Scene.Click(e.Location, color);
                Scene.Hit(e.Location);
                Invalidate();
            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Invalidate();
            Scene.Move(0,0,Width,Height);
            Invalidate();
            update();
        }
        public void update()
        {
            toolStripStatusLabel1.Text = String.Format("Active: {0}", Scene.Counter);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Width = this.Width+100;
            Height = this.Height+100;
            Invalidate();
        }
    }
    }

