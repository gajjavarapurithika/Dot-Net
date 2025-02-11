using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "RichTextFiles|*.rtf|TextFiles|*.txt|AllFiles|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(openFileDialog.FileName).ToLower() == ".rtf")
                    {
                        richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "RichTextFiles|*.rtf|TextFiles|*.txt|AllFiles|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(saveFileDialog.FileName).ToLower() == ".rtf")
                    {
                        richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                    }
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void olorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colordialog = new ColorDialog())
            {
                if (colordialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = colordialog.Color;
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FontDialog fontDialog = new FontDialog())
            {
                if(fontDialog.ShowDialog() == DialogResult.OK)
                {
                   richTextBox1.SelectionFont = fontDialog.Font;
                }
            }
        }
    }
}
