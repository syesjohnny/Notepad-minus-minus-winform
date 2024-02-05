using Dark.Net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI;
using WindowsFormsApp1;
using static System.Windows.Forms.DataFormats;
using System.IO;
using Newtonsoft.Json.Linq;

namespace NotePadMinusMinus
{
    public partial class Preferences : Form
    {
        private MainForm _mainForm;
        private Panel? CurrentSettingsPanel { get; set; } = null;
        public IReadOnlyDictionary<string, Panel> AllSettingsPanels { get; }
        public Preferences(MainForm form1)
        {
            InitializeComponent();
            Hint.Visible = false;
            _mainForm = form1;
            AllSettingsPanels = new Dictionary<string, Panel>()
            {
                { "Settings", SettingTabPanel }
            };
            foreach (var pair in AllSettingsPanels)
            {
                pair.Value.Visible = false;
            }
        }

        private void OnOptionListBoxChange(object? _, EventArgs? _2)
        {
            if (OptionListBox.SelectedItem == null)
            {
                goto NotSelected;
            }

            if (!AllSettingsPanels.TryGetValue(OptionListBox.SelectedItem.ToString()!, out Panel? p))
            {
                goto NotSelected;
            }
            Panel panel = p!;

            panel.Visible = true;
            if (CurrentSettingsPanel != null) CurrentSettingsPanel.Visible = false;
            CurrentSettingsPanel = panel;
            return;
        NotSelected:
            if (CurrentSettingsPanel != null) CurrentSettingsPanel.Visible = false;
            CurrentSettingsPanel = null;
            return;
        }

        private void loadsetting_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "JavaScript Object Notation Files (.json)|*.json|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ConfigManager.Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(openFileDialog.FileName));
                ConfigManager.WriteConfig();
                Hint.Visible = true;
                Hint.Text = "Restart Notepad-- to apply changes";
                MessageBox.Show("Restart Notepad-- to apply changes");
            }

        }

        private void savesetting_Click(object sender, EventArgs e)
        {
            Hint.Visible = true;
            Hint.Text = "Unable to get config file";
            if (!ConfigManager.GetConfig())
            {
                MessageBox.Show("Unable to get config file");
            }
        }
    }
}
