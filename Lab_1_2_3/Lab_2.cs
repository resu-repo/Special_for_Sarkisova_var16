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
    public partial class Lab_2 : Form
    {
        public Lab_2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        double vvod(TextBox t) 
        { 
            return Convert.ToDouble(t.Text); 
        }
        void vivod(double z, TextBox t) 
        { 
            t.Text = z.ToString("F5"); 
        }
        void vivod_int(int z, TextBox t) 
        { 
            t.Text = z.ToString(); 
        }
        void vivod_list(double z, ListBox l) 
        { 
            l.Items.Add(z.ToString("F5")); 
        }
        double fun(double x) 
        {
            return Math.Pow(x, 5) + 5 * Math.Pow(x, 4) - 2 * Math.Pow(x, 3) 
                    - 4 * Math.Pow(x, 2) + 7 * x - 3;
        }
        //  Построить таблицу и вычислить произведение значений функции 
        //  y = f(x) при y>0 при изменении x на отрезке[a;b] с шагом h.
        //  Отрезок [a = -0.5; b = 1.5], шаг h=0.1
        double a, b, h, mult = 1;
        void RegCikl()
        {
            int n;
            double x, y;
            n = Convert.ToInt32(Math.Ceiling((b - a) / h) + 1);
            vivod_int(n, textBox6);
            x = a;
            for (int i = 0; i<n ; i++)
            {

                y = fun(x);
                vivod_list(x, listBox1);
                if (y > 0)
                {
                    vivod_list(y, listBox2);
                    mult *=  y;
                }
                x += h; //x = x + h
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            a = vvod(textBox3);
            b = vvod(textBox4);
            h = vvod(textBox5);
            vivod(mult, textBox7);
            RegCikl();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
