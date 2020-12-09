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
    public partial class Lab_1 : Form
    {
        public Lab_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text),
                   y = Convert.ToDouble(textBox4.Text),
                   a = Convert.ToDouble(textBox3.Text);
            double t1, t2, t;
            if (x * y < 0)
            {
                if (x > y) t = (1 - Math.Sqrt(x * x +a)) * x ;
                else t = (1 - Math.Sqrt(x * x + a)) * y ;
            }
            else
            {
                if (x * y > 2)
                {
                    t1 = x * x;
                    t2 = Math.Sin(y);
                    t =  Math.Cos(a * y);
                    if (t1 < t) t = t1;
                    if (t2 < t) t = t2;
                }
                else t = a * a + x / y;
            }
            textBox1.Text = Convert.ToString(t);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
