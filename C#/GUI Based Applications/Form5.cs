using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Text = "DCA";
            checkBox2.Text = "Java";
            checkBox3.Text = "DOTNET";
            button1.Text = "Course";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                label1.Text = "DCA,Java,DOTNET Selected";
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                label1.Text = "DCA,Java Selected";
            }
            else if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                label1.Text = "DCA,DOTNET Selected";
            }
            else if (checkBox2.Checked == true && checkBox3.Checked == true)
            {
                label1.Text = "Java,DOTNET Selected";
            }
            else if (checkBox1.Checked == true)
            {
                label1.Text = "DCA Selected";
            }
            else if(checkBox3.Checked == true)
            {
                label1.Text = "DOTNET Selected";
            }
            else if(checkBox2.Checked == true) 
            {
                label1.Text = "Java Selected";
            }
        }
    }
}
