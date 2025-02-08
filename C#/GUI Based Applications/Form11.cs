using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
