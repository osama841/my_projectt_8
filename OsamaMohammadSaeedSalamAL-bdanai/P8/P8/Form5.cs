using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string mylist;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text).ToString();
            mylist = textBox1.Text;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.Remove(listBox1.SelectedItem);
            else
                MessageBox.Show("select word first");
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.Remove(listBox1.SelectedItem);
            else
                MessageBox.Show("select char first");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
         
        }
        int sum = 0;
        int con = 0;
        private void button4_Click(object sender, EventArgs e)
        {
       
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                con += 1; 
               int x = int.Parse(listBox1.Items[i].ToString());
              sum+=x;
            
              textBox2.Text = sum.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        { 
           
              int p = sum % con;
              textBox3.Text = p.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
       
        }
    }
}
