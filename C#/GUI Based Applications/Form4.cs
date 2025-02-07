using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                c = a / b;
                textBox3.Text = Convert.ToString(c);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            label1.Text = "A";
            label2.Text= "B";
            label3.Text= "C";
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "*";
            button4.Text = "/";
            button5.Text = "%";
            button6.Text = "<-";
            button7.Text = "X";
        }
        int a,b,c;

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a * b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                c = a % b;
                textBox3.Text = Convert.ToString(c);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a - b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a=Convert.ToInt32(textBox1.Text);
            b=Convert.ToInt32(textBox2.Text);
            c = a + b;
            textBox3.Text=Convert.ToString(c);
        }
    }
}
