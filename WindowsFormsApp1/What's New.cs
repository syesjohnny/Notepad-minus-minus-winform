using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadMinusMinus
{
    public partial class What_s_New : Form
    {
        public What_s_New()
        {
            InitializeComponent();
        }

        private void FullChangeLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo("https://github.com/syesjohnny/Notepad-minus-minus/blob/main/Changelog.md")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void AllReleases_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo("https://github.com/syesjohnny/Notepad-minus-minus/releases")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer("uwusecret.wav");
            simpleSound.Play();
        }
    }
}
