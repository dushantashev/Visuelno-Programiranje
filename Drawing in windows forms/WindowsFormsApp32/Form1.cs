using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp32
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered=true;
            scene = new Scene(this.Width,this.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddPoint(e.Location);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg= new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                scene.Color=dlg.Color;
            }
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smallToolStripMenuItem.Checked = true;
            largeToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            scene.Thickness = 1;
            Invalidate();
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            largeToolStripMenuItem.Checked = true;
            smallToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            scene.Thickness = 3;
            Invalidate();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediumToolStripMenuItem.Checked = true;
            largeToolStripMenuItem.Checked = false;
            smallToolStripMenuItem.Checked = false;
            scene.Thickness = 2;
            Invalidate();
        }

        private void poinsonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Positioner=!scene.Positioner;
            poinsonerToolStripMenuItem.Checked = !poinsonerToolStripMenuItem.Checked;
        }

        private void poinsonerToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scene.Cursor = e.Location;
            Invalidate();
        }
    }
}
