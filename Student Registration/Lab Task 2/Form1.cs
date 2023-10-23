using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.FullRowSelect = true;
            this.listView1.CheckBoxes = true;

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("You didn't add Name/Surname", "ERROR");
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("You didn't add number", "ERROR");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("You didn't select gender", "ERROR");
                return;
            }

            listView1.Items.Add(new ListViewItem(new string[]
            {

                (comboBox2.SelectedItem.ToString() == "Undergraduate" ? "💡 " : "     ")
                + textBox1.Text.ToString() + 
                (comboBox1.SelectedItem.ToString() == "Male" ? "  -(M)" : "  -(F)")
                ,textBox2.Text,textBox3.Text,
                checkBox1.Checked ? "Registered" : "Not Registered",
                

            }));
            if (checkBox1.Checked == true)
            {
                listView1.Items[listView1.Items.Count - 1].Checked = true;
            }
            else if (checkBox1.Checked == false)
            {
                listView1.Items[listView1.Items.Count - 1].Checked = false;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
