using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "CASH";
            radioButton2.Text = "CHEQUE";
            radioButton3.Text = "DEBIT CARD";
            button1.Text = "Payment";
            label1.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Cash selected";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Cheque Selected";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Debit Card Selected";
            }
        }
    }
}
