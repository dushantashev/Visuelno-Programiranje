using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp37
{
    public partial class Form1 : Form
    {
        Scene scene;
        private string FileName;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            scene = new Scene();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            scene.AddRetangle(e.Location);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Move();
            scene.Move2();
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                scene.Hit(e.Location);
            }
            if (e.Button == MouseButtons.Right)
            {
                scene.Hit2(e.Location);
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                scene.Color = dlg.Color;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Scene file (*.rct)|*.rct";
                saveFileDialog.Title = "Rectangles scene";
                saveFileDialog.FileName = FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Scene file (*.rct)|*.rct";
            openFileDialog.Title = "Rectangles scene";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        scene = (Scene)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }
    }
}
