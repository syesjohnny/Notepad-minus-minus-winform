using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{

    public partial class Goto : Form
    {
        private Form1 richform;
        public Goto(Form1 form1)
        {
            InitializeComponent();
            richform = form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttongo_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    int lineNumber;
                    try
                    {
                        lineNumber = Convert.ToInt32(textBox1.Text) - 1;
                    }
                    catch (Exception)
                    {
                        lineNumber = 2147483647;
                    }

                    int totalLines = richform.richTextBox1.Lines.Length;

                    if (lineNumber >= 0 && lineNumber < totalLines)
                    {
                        int lineStartIndex = richform.richTextBox1.GetFirstCharIndexFromLine(lineNumber);
                        richform.richTextBox1.SelectionStart = lineStartIndex;
                        richform.richTextBox1.SelectionLength = 0;
                        richform.richTextBox1.ScrollToCaret();
                    }
                    else if (lineNumber!=0)
                    {
                        int lastLineIndex = richform.richTextBox1.Lines.Length - 1;
                        richform.richTextBox1.SelectionStart = richform.richTextBox1.GetFirstCharIndexFromLine(lastLineIndex);
                        richform.richTextBox1.SelectionLength = 0;
                        richform.richTextBox1.ScrollToCaret();
                    }
                }
                else
                {
                    int charIndex;
                    try
                    {
                        charIndex = Convert.ToInt32(textBox1.Text) - 1;
                    }
                    catch (Exception)
                    {
                        charIndex = 2147483647;
                    }
                    if (charIndex >= 0 && charIndex <= richform.richTextBox1.Text.Length)
                    {
                        richform.richTextBox1.SelectionStart = charIndex;
                        richform.richTextBox1.ScrollToCaret();
                    }
                    else if (textBox1.Text!="")
                    {
                        richform.richTextBox1.SelectionStart = richform.richTextBox1.Text.Length;
                        richform.richTextBox1.SelectionLength = 0;
                        richform.richTextBox1.ScrollToCaret();
                    }
                }
            }
            catch (Exception)
            { }
        }

        private void intonlyinput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false)
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
        }

    }
}
