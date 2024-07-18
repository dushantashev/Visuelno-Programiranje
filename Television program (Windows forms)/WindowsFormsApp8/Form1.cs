using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                comboBox1.Items.Add(form2.televizija);
            }
        }

    public void print()
        {
            
            listBox1.Items.Clear();
            
            
                Televizija televizija=comboBox1.SelectedItem as Televizija;
            int suma = 0;
            int index = 0;
                foreach(Emisija emisija in televizija.Emisija)
                {
                    listBox1.Items.Add(emisija);
                suma += emisija.Vremetraenje;
                index++;
                }


            
            if (suma != 0 && index != 0)
            {
                textBox2.Text = (suma / index).ToString();
            }
            label1.Text = televizija.Name;
            buttonEnable();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                Televizija televizija=comboBox1.SelectedItem as Televizija;
                televizija.addEmisija(new Emisija(textBox1.Text, (int)numericUpDown1.Value));
                print();
            buttonEnable();
            

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            print();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void buttonEnable()
        {
            if(comboBox1.Items.Count == 0 && textBox1.Text.Length==0) {
            button1.Enabled= false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure", "Are You Sure?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Televizija televizija = comboBox1.SelectedItem as Televizija;

                televizija.Emisija.RemoveAt(listBox1.SelectedIndex);
                print();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonEnable();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEnable();
            print();
        }
    }
}
