using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            float toplam = (float.Parse(textBox1.Text) +
                float.Parse(textBox2.Text) +
                float.Parse(textBox3.Text))/ 3;
            
            textBox4.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int minNumber = 0;
            if (int.Parse(textBox1.Text) <= int.Parse(textBox2.Text) && int.Parse(textBox1.Text) <= int.Parse(textBox3.Text))
            {
                minNumber = int.Parse(textBox1.Text);
            }
            if (int.Parse(textBox2.Text) <= int.Parse(textBox1.Text) && int.Parse(textBox2.Text) <= int.Parse(textBox2.Text))
            {
                minNumber = int.Parse(textBox2.Text);
            }
            if (int.Parse(textBox3.Text) <= int.Parse(textBox2.Text) && int.Parse(textBox3.Text) <= int.Parse(textBox1.Text))
            {
                minNumber = int.Parse(textBox3.Text);
            }
            textBox4.Text = minNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxNumber = 0;
            if (int.Parse(textBox1.Text) >= int.Parse(textBox2.Text) && int.Parse(textBox1.Text) >= int.Parse(textBox3.Text))
            {
                maxNumber = int.Parse(textBox1.Text);
            }
            if (int.Parse(textBox2.Text) >= int.Parse(textBox1.Text) && int.Parse(textBox2.Text) >= int.Parse(textBox3.Text))
            {
                maxNumber = int.Parse(textBox2.Text);
            }
            if (int.Parse(textBox3.Text) >= int.Parse(textBox2.Text) && int.Parse(textBox3.Text) >= int.Parse(textBox1.Text))
            {
                maxNumber = int.Parse(textBox3.Text);
            }
            textBox4.Text = maxNumber.ToString();
        }
    }
}
