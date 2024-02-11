using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace NotePadMinusMinus
{
    public partial class inserttag : Form
    {
        private MainForm _mainForm;
        public inserttag(MainForm mainForm)
        {
            InitializeComponent();
            this.AcceptButton = ok;
            this.CancelButton = cancel;
            _mainForm = mainForm;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            int insertionIndex = _mainForm.EditingArea.SelectionStart;
            int insertionLength = _mainForm.EditingArea.SelectionLength;
            _mainForm.EditingArea.Select(insertionIndex, 0);
            _mainForm.EditingArea.SelectedText = open.Text;
            _mainForm.EditingArea.Select(insertionIndex + open.Text.Length+insertionLength, 0);
            _mainForm.EditingArea.SelectedText = ClosingTag.Text;
            _mainForm.EditingArea.Select(insertionIndex + open.Text.Length,insertionLength);
            Close();
        }

        private void open_TextChanged(object sender, EventArgs e)
        {
            if (check())
            {
                ClosingTag.Text = open.Text.Substring(0, 1) + "/" + open.Text.Substring(1);
            }
            else
            {
                ClosingTag.Text = "";
            }
        }

        private bool check()
        {
            if (open.Text.Length >= 3)
            {
                if (open.Text.StartsWith("<") && open.Text.EndsWith(">"))
                {
                    string temp = open.Text.Substring(1, open.Text.Length - 2);

                    bool hasPunctuation = false;

                    foreach (char ch in temp)
                    {
                        if (Char.IsPunctuation(ch) || ch == '<' || ch == '>')
                        {
                            hasPunctuation = true;
                            break;
                        }
                    }
                    return !hasPunctuation;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}
