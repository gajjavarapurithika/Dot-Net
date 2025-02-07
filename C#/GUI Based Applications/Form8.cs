using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pen");
            listBox1.Items.Add("Pencil");
            listBox1.Items.Add("Eraser");
            listBox1.Items.Add("Sharpner");
            listBox1.Items.Add("Scale");
            label1.Text = " ";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SelectedItems= listBox1.SelectedItems.Cast<string>().ToList();
            label1.Text=string.Join(", ", SelectedItems);
        }
    }
}
