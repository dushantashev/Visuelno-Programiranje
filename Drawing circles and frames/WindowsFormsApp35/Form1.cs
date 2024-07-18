using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp35
{
    public partial class Form1 : Form
    {
        Scene scene;

        bool regulator = true;
        
        public Form1()
        {

            InitializeComponent();
            scene = new Scene();
            
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (regulator == true)
            {
                scene.AddBall(e.Location);
                scene.Hit(e.Location);
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                scene.Color=dlg.Color;
            }
        }

        private void radiusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            radiusToolStripMenuItem.Checked= !radiusToolStripMenuItem.Checked;
            scene.Radius = 15;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Delete) {
                List<Ball>removeBall=new List<Ball>();
      for(int i=scene.balls.Count-1; i>=0; i--)
                {
                    if (scene.balls[i].Hit == 1)
                    {
                        scene.balls.RemoveAt(i);
                    }
                }
                
                Invalidate();


            }
            if (e.KeyCode == Keys.Escape)
            {
                regulator = !regulator;
            }


        }
    }
}
