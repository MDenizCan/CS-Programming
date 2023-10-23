using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders2proje2
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
            float CtoFdegree = (float.Parse(textBox1.Text) * 9f / 5f) + 32;
            textBox2.Text = CtoFdegree.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float FtoCdegree = (float.Parse(textBox1.Text) - 32) * 5f / 9f;
            textBox2.Text = FtoCdegree.ToString();
        }
    }
}
