using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Add(form2.Avtobusi);
             
                
            }
            
        }
        public void printLocation()
            
        {
            listBox2.Items.Clear();

           if(listBox1.Items.Count > 0)
            {
                Avtobusi avtobus=listBox1.SelectedItem as Avtobusi;
                foreach(Linija line in avtobus.linija)
                {
                    listBox2.Items.Add(line.ToString());
                    
                }
                
            }
        }
        public void NajskapaLinija()
        {
            int max = 0;
            int index = 0;
            Linija Max = listBox1.Items[0] as Linija;
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                Avtobusi avtobuss= listBox1.Items[i] as Avtobusi;
                foreach(Linija line in avtobuss.linija)
                {
                    if (line.Cena > max)
                    {
                        Max = line;
                        max = line.Cena;
                        index = i;
                    }

                }

            }
            Avtobusi avtobus = listBox1.Items[index] as Avtobusi;

           textBox1.Text= Max.ToString();

        }
        public void SrednaCena()
        {
       
            int suma = 0;
            int brNaLinii = 0;
            if (listBox1.SelectedItems.Count > 0)
            {
                
               
                Avtobusi avtobus = listBox1.SelectedItem as Avtobusi;
                
                foreach(Linija line in avtobus.linija)
                {
                    suma += line.Cena;
                    brNaLinii++;
                }
                
            }
            textBox2.Text = (suma/brNaLinii).ToString();
           
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                if (listBox1.Items.Count > 0)
                {
                    Avtobusi avtobus = listBox1.SelectedItem as Avtobusi;
                    avtobus.AddDestination(form3.Linija);
                    printLocation();
                    SrednaCena();
                    NajskapaLinija();
                }
            }

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            printLocation();
            SrednaCena();
            NajskapaLinija();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dali si siguren?", "Siguren li si?", MessageBoxButtons.YesNo);
            if (listBox1.SelectedItems.Count > 0)
            {
                Avtobusi avtobus = listBox1.SelectedItem as Avtobusi;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.SelectedItems.Clear();
                textBox2.Text = "";
                NajskapaLinija();
            }
        }
    }
}
