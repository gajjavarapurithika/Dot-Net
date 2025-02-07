using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pen");
            comboBox1.Items.Add("Book");
            comboBox1.Items.Add("Eraser");
            comboBox1.Items.Add("Scale");
            comboBox1.Text = "Select Item";
            label1.Text = " ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text=comboBox1.SelectedItem.ToString();
        }
    }
}
