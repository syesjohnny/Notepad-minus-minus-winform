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


namespace WindowsFormsApp1
{
    public partial class Run : Form
    {
        public Run()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe; *.com; *.cmd; *.bat)| *.exe; *.com; *.cmd; *.bat | All Files (*.*) | *.* ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    string userInput = textBox1.Text;

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
