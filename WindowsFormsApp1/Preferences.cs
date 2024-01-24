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

namespace NotePadMinusMinus
{
    public partial class Preferences : Form
    {
        private MainForm _mainForm;
        public Preferences(MainForm form1)
        {
            InitializeComponent();
            _mainForm = form1;
        }

        private void changepanel(object sender, EventArgs e)
        {
            stylepanel.Visible = false;

            // Show the selected panel based on the ListBox item
            switch (listBox1.SelectedItem.ToString())
            {
                case "Test1":
                    stylepanel.Visible = true;
                    break;

                // Add more cases for additional items

                default:
                    break;
            }
        }

        private void themetoggle_CheckedChanged(object sender, EventArgs e)
        {
            if (themetoggle.Checked) {
                _mainForm.TopMenuStrip.BackColor = Color.FromArgb(26, 29, 57);
                _mainForm.TopMenuStrip.ForeColor = Color.White;
                _mainForm.toolStrip1.BackColor = Color.FromArgb(26, 29, 57);
                _mainForm.toolStrip1.ForeColor = Color.White;
                _mainForm.EditingArea.BackColor = Color.FromArgb(39, 39, 39);
                _mainForm.EditingArea.ForeColor = Color.White;
                _mainForm.BackColor= Color.FromArgb(26, 29, 57);
            }
            else
            {
                _mainForm.TopMenuStrip.BackColor = Color.FromArgb(248, 248, 248);
                _mainForm.TopMenuStrip.ForeColor = Color.Black;
                _mainForm.toolStrip1.BackColor = Color.FromArgb(248, 248, 248);
                _mainForm.toolStrip1.ForeColor = Color.Black;
                _mainForm.EditingArea.BackColor = Color.FromArgb(249,249,249);
                _mainForm.EditingArea.ForeColor = Color.Black;
                _mainForm.BackColor = Color.FromArgb(248, 248, 248);
            }
        }
    }
}
