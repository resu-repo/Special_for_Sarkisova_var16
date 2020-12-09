using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_2_3
{
    public partial class Lab_3 : Form
    {
        public Lab_3()
        {
            InitializeComponent();
        }
        //Вычислить ln(x) с точностью ε = 0.0001, воспользовавшись разложением в ряд:
        //Сравнить результат со значением, полученным с помощью соответствующей 
        //встроенной функции при x=1.5
        public double vvod(TextBox t) 
        { 
            return Convert.ToDouble(t.Text); 
        }
        public void vivodList(double ch,ListBox l )
        {
            l.Items.Add(ch);
        }
        public void vivodListInt(int ch, ListBox l) 
        {
            l.Items.Add(ch);
        }
        double E, x;
        public void Pos()
        {
            int n = 0;
            double a = 2* (x - 1)/(x+1);
            while (a>E)
            {
                vivodListInt(n, listBox1);
                vivodList(a, listBox2);
                a = 2* (Math.Pow((x - 1), (2 * n + 1))) / 
                    ((2 * n + 1) * (Math.Pow((x + 1), (2 * n + 1))));
                n++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            E = vvod(textBox1);
            x = vvod(textBox2);
            Pos();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Lab_3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
