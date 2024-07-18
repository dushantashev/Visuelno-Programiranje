using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Add(form2.student);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                Student student = listBox1.SelectedItem as Student;

                student.addUpalata(new Uplata((int)numericUpDown1.Value));
                print();
            }
        }

        public void print()

        {
            label1.Text = "";
            if (listBox1.Items.Count > 0)
            {
                Student student = listBox1.SelectedItem as Student;
                label1.Text += (student.Index + " " + student.Name + "\n").ToString();
                double suma = 0;
                foreach (Uplata uplata in student.uplatas)
                {

                    label1.Text += uplata.ToString();
                    suma += uplata.Suma;
                }
                label1.Text += "Вкупно: " + suma;

            }
            najgolemIznos();
        }

        public void najgolemIznos()
        {
            int max = 0;
            int indexMax = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int suma = 0;
                Student student = listBox1.Items[i] as Student;
                foreach (Uplata uplata in student.uplatas)
                {
                    suma += uplata.Suma;
                }
                if (suma > max)
                {
                    max = suma;
                    indexMax = i;
                }
            }

            textBox1.Text = listBox1.Items[indexMax].ToString();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            print();

        }

        private void Откажи_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Dali si siguren", "Siguren si", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Student stundet = listBox1.SelectedItem as Student;
                    stundet.uplatas.Clear();
                    print();
                    najgolemIznos();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
