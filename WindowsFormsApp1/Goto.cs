using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Radios;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NotePadMinusMinus
{

    public partial class Goto : Form
    {
        private MainForm _mainForm;
        public Goto(MainForm form1)
        {
            InitializeComponent();
            _mainForm = form1;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            if (OptionLine.Checked == true)
            {
                // TryParse returns false if failed
                if (!int.TryParse(GotoInput.Text, out int lineNumber)) lineNumber = int.MaxValue;
                lineNumber--;

                int totalLines = _mainForm.EditingArea.Lines.Length - 1;
                if (lineNumber > totalLines && !IgnoreOverflowCheckBox.Checked)
                {
                    MessageBox.Show("The line you wanted to go is over the document!", "Error", MessageBoxButtons.OK);
                    return;
                }

                int lineStartIndex = _mainForm.EditingArea.GetFirstCharIndexFromLine(Utils.Range(0, lineNumber, totalLines));
                _mainForm.EditingArea.SelectionStart = lineStartIndex;
                _mainForm.EditingArea.SelectionLength = 0;
                _mainForm.EditingArea.ScrollToCaret();
            }
            else if (OptionPos.Checked == true) // add readability
            {
                if (!int.TryParse(GotoInput.Text, out int charIndex)) charIndex = int.MaxValue;
                charIndex--;

                int length = _mainForm.EditingArea.Text.Length - 1;

                _mainForm.EditingArea.SelectionStart = Utils.Range(0, charIndex, length);
                _mainForm.EditingArea.SelectionLength = 0;
                _mainForm.EditingArea.ScrollToCaret();
            }
        }

        private void GotoInputEvent(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Suppress the key press
            }
        }

 
    }
}
