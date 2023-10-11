using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            float pay1 = float.Parse(textBox5.Text);
            float payda1 = float.Parse(textBox1.Text);
            float pay2 = float.Parse(textBox6.Text);
            float payda2 = float.Parse(textBox2.Text);
            float formul1 = pay1 * payda2;
            float formul2 = pay2 * payda1;
            float formul3 = payda1 * payda2;
            float toplamsayi = formul1 + formul2;

            textBox3.Text =  toplamsayi.ToString() + "/" + formul3.ToString();

            float normalNumber = pay1 / payda1 + pay2 / payda2;
            textBox4.Text = normalNumber.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
