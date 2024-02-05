using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadMinusMinus
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void NotepadMinusMinusGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo("https://github.com/syesjohnny/Notepad-minus-minus/")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void APPLICENSES_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo("https://creativecommons.org/publicdomain/zero/1.0/")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
