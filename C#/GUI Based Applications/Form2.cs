using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "My app";
            this.CenterToScreen();
            this.BackColor = Color.Pink;
            this.Size = new Size(600, 500);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            label1.Text = "Welcome to GUI";
            label1.Font = new Font("Arial", 20, FontStyle.Bold);
            label1.BackColor = Color.Yellow;
            label1.ForeColor = Color.Blue;
        }
    }
}
