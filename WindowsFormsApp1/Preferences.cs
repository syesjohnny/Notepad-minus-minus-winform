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
		private Panel? CurrentSettingsPanel { get; set; } = null;
		public IReadOnlyDictionary<string, Panel> AllSettingsPanels { get; }
		public Preferences(MainForm form1)
		{
			InitializeComponent();
			_mainForm = form1;
			AllSettingsPanels = new Dictionary<string, Panel>()
			{
				{ "Style", StylePanel },
				{ "Test Tab", TestTabPanel }
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

		private void ToggleDarkTheme(object sender, EventArgs e)
		{
			if (DarkThemeToggle.Checked)
			{
				ThemeHelper.ChangeControlTheme(_mainForm, ThemeHelper.DarkDefault, new ToolStripProfessionalRenderer(new DarkToolStripItemColors()));
				MainForm.ToolStripRender = new ToolStripProfessionalRenderer(new DarkToolStripItemColors());
				ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new DarkToolStripItemColors());
			}
			else
			{
				ThemeHelper.ChangeControlTheme(_mainForm, ThemeHelper.WhiteDefault, null);
				MainForm.ToolStripRender = null;
				ToolStripManager.Renderer = null;
			}
		}
	}
}
