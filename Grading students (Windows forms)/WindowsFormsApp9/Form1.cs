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

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Add(form2.ispit);
                print();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                Ispit ispit = listBox1.SelectedItem as Ispit;
                ispit.AddZadacha1(new Zadachi(textBox1.Text, (int)numericUpDown1.Value));
                print();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                Ispit ispit = listBox1.SelectedItem as Ispit;
                ispit.AddZadacha2(new Zadachi(textBox2.Text, (int)numericUpDown2.Value));
                print();
            }
        }

        public void print()
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 0;
            if(listBox1.SelectedItems.Count>0)
            {
                int suma = 0;
                Ispit ispit = listBox1.SelectedItem as Ispit;
                foreach(Zadachi zadaci in ispit.zadacha1)
                {
                    listBox2.Items.Add(zadaci.zad1Details());
                    suma += zadaci.zad2Details();
                   
                }
                numericUpDown1.Value= suma;


                int suma1 = 0;
             
                foreach (Zadachi zadaci in ispit.zadacha2)
                {
                    listBox3.Items.Add(zadaci.zad1Details());
                    suma1 += zadaci.zad2Details();

                }
                numericUpDown2.Value = suma1;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            print();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if(listBox1.SelectedItems.Count>0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
