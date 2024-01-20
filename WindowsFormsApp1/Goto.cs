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
			try
			{
				if (OptionLine.Checked == true)
				{
					int lineNumber;
					try
					{
						lineNumber = Convert.ToInt32(GotoInput.Text) - 1;
					}
					catch (Exception)
					{
						lineNumber = 2147483647;
					}

					int totalLines = _mainForm.EditingArea.Lines.Length;

					if (lineNumber >= 0 && lineNumber < totalLines)
					{
						int lineStartIndex = _mainForm.EditingArea.GetFirstCharIndexFromLine(lineNumber);
						_mainForm.EditingArea.SelectionStart = lineStartIndex;
						_mainForm.EditingArea.SelectionLength = 0;
						_mainForm.EditingArea.ScrollToCaret();
					}
					else if (lineNumber != 0)
					{
						int lastLineIndex = _mainForm.EditingArea.Lines.Length - 1;
						_mainForm.EditingArea.SelectionStart = _mainForm.EditingArea.GetFirstCharIndexFromLine(lastLineIndex);
						_mainForm.EditingArea.SelectionLength = 0;
						_mainForm.EditingArea.ScrollToCaret();
					}
				}
				else
				{
					int charIndex;
					try
					{
						charIndex = Convert.ToInt32(GotoInput.Text) - 1;
					}
					catch (Exception)
					{
						charIndex = 2147483647;
					}
					if (charIndex >= 0 && charIndex <= _mainForm.EditingArea.Text.Length)
					{
						_mainForm.EditingArea.SelectionStart = charIndex;
						_mainForm.EditingArea.ScrollToCaret();
					}
					else if (GotoInput.Text != "")
					{
						_mainForm.EditingArea.SelectionStart = _mainForm.EditingArea.Text.Length;
						_mainForm.EditingArea.SelectionLength = 0;
						_mainForm.EditingArea.ScrollToCaret();
					}
				}
			}
			catch (Exception)
			{ }
		}

		private void GotoInputEvent(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true; // Suppress the key press
			}
		}

		private void OptionLine_Click(object sender, EventArgs e)
		{
			if (OptionLine.Checked == false)
			{
				OptionLine.Checked = true;
				OptionPos.Checked = false;
			}
		}

		private void OptionPos_Click(object sender, EventArgs e)
		{
			if (OptionPos.Checked == false)
			{
				OptionPos.Checked = true;
				OptionLine.Checked = false;
			}
		}

	}
}
