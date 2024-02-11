using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NotePadMinusMinus
{
	public partial class Run : Form
	{
		public Run()
		{
			InitializeComponent();
			this.AcceptButton = RunButton;
		}

		private void FileSelectorButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new()
			{
				Filter = "Executable Files (*.exe; *.com; *.cmd; *.bat)| *.exe; *.com; *.cmd; *.bat | All Files (*.*) | *.* "
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileSelectorInput.Text = openFileDialog.FileName;
			}
		}

		private void RunButton_Click(object sender, EventArgs e)
		{
			if (FileSelectorInput.Text != "")
			{
				try
				{
					string userInput = FileSelectorInput.Text;

					// Check if "$(full_current_path)" is present in the text
					if (userInput.Contains("$(full_current_path)"))
					{
						// Replace "$(full_current_path)" with the current path
						string currentPath = Environment.CurrentDirectory;
						userInput = userInput.Replace("$(full_current_path)", currentPath);
					}
					Process.Start(userInput);
				}
				catch (Win32Exception)
				{
					MessageBox.Show("Can't find application");
				}

			}
		}

	}
}
