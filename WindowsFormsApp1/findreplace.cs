using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadMinusMinus
{
	public partial class FindReplace : Form
	{
		private MainForm _mainForm;
		public FindReplace(MainForm form)
		{
			InitializeComponent();
			_mainForm = form;
		}

		private void ReplaceCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ReplaceInput.Enabled = ReplaceCheckBox.Checked;
			ReplaceButton.Enabled = ReplaceCheckBox.Checked;
			ReplaceAllButton.Enabled = ReplaceCheckBox.Checked;
			FindLabel.Text = ReplaceCheckBox.Checked ? "Replace:" : "Find:";
		}

		private void ReplaceAllButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(FindInput.Text)) return;
			_mainForm.EditingArea.Text = _mainForm.EditingArea.Text.Replace(FindInput.Text, ReplaceInput.Text);
		}

		private void FindNextButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(FindInput.Text) || !_mainForm.EditingArea.Text.Contains(FindInput.Text))
			{
				goto Failed;
			}
			int selectionStart = _mainForm.EditingArea.SelectionStart;
			int selectionLen = _mainForm.EditingArea.SelectionLength;
			int searchStringIndexStart = -1;
			if (!BackwardCheckBox.Checked)
			{
				searchStringIndexStart = _mainForm.EditingArea.Text.IndexOf(FindInput.Text, selectionStart + selectionLen);
			}
			else
			{
				searchStringIndexStart = _mainForm.EditingArea.Text.Substring(0, selectionStart).LastIndexOf(FindInput.Text);
			}
			if (searchStringIndexStart < 0) goto Failed;
			_mainForm.EditingArea.SelectionStart = searchStringIndexStart;
			_mainForm.EditingArea.SelectionLength = FindInput.Text.Length;

			_mainForm.Focus(); // bring to front
			_mainForm.BringToFront();
			_mainForm.EditingArea.Focus(); 
			return;

		Failed:
			MessageBox.Show("Failed to find text.", "Error", MessageBoxButtons.OK);
			return;
		}

		private void ReplaceButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(FindInput.Text)) return;
			_mainForm.EditingArea.SelectedText = _mainForm.EditingArea.SelectedText.Replace(FindInput.Text, ReplaceInput.Text);
			FindNextButton_Click(null, null);
		}
	}
}
