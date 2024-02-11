using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotePadMinusMinus;

public class ThemeColors
{
	public required Color RichTextBoxForeground { get; set; }
	public required Color RichTextBoxBackground { get; set; }
	public required Color MenuStripForeground { get; set; }
	public required Color MenuStripBackground { get; set; }
	public required Color ToolItemStripForeground { get; set; }
	public required Color ToolItemStripBackground { get; set; }
	public required Color ToolStripForeground { get; set; }
	public required Color ToolStripBackground { get; set; }
	public required Color PanelForeground { get; set; }
	public required Color PanelBackground { get; set; }
	public required Color LabelForeground { get; set; }
	public required Color LabelBackground { get; set; }
	public required Color ToolStripLabelForeground { get; set; }
	public required Color ToolStripLabelBackground { get; set; }
	public required Color FormForeground { get; set; }
	public required Color FormBackground { get; set; }
}
public class DarkToolStripItemColors : ProfessionalColorTable
{
	public override Color MenuItemSelected => ThemeHelper.DefaultLightDark;
}

public static class ThemeHelper
{
	private const byte DarkRed = 39;
	private const byte DarkGreen = 39;
	private const byte DarkBlue = 39;

	private const byte LightDarkRed = 49;
	private const byte LightDarkGreen = 49;
	private const byte LightDarkBlue = 49;

	private const byte WhiteRed = 255;
	private const byte WhiteGreen = 255;
	private const byte WhiteBlue = 255;

	public static readonly Color DefaultDark = Color.FromArgb(DarkRed, DarkGreen, DarkBlue);
	public static readonly Color DefaultLightDark = Color.FromArgb(LightDarkRed, LightDarkGreen, LightDarkBlue);
	public static readonly Color DefaultWhite = Color.FromArgb(WhiteRed, WhiteGreen, WhiteBlue);
	public static ThemeColors DarkDefault
	{
		get
		{
			return new()
			{
				RichTextBoxForeground = DefaultWhite,
				RichTextBoxBackground = DefaultLightDark,
				MenuStripForeground = DefaultWhite,
				MenuStripBackground = DefaultDark,
				ToolItemStripBackground = DefaultDark,
				ToolItemStripForeground = DefaultWhite,
				ToolStripForeground = DefaultWhite,
				ToolStripBackground = DefaultDark,
				PanelForeground = DefaultWhite,
				PanelBackground = DefaultDark,
				LabelForeground = DefaultWhite,
				LabelBackground = DefaultDark,
				ToolStripLabelForeground = DefaultWhite,
				ToolStripLabelBackground = DefaultDark,
				FormForeground = DefaultWhite,
				FormBackground = DefaultDark
			};
		}
	}
	public static ThemeColors WhiteDefault
	{
		get
		{
			return new()
			{
				RichTextBoxForeground = Color.Black,
				RichTextBoxBackground = Color.FromArgb(233, 233, 233),
				MenuStripForeground = Color.Black,
				MenuStripBackground = DefaultWhite,
				ToolItemStripForeground = Color.Black,
				ToolItemStripBackground = DefaultWhite,
				ToolStripForeground = Color.Black,
				ToolStripBackground = DefaultWhite,
				PanelForeground = Color.Black,
				PanelBackground = DefaultWhite,
				LabelForeground = Color.Black,
				LabelBackground = DefaultWhite,
				ToolStripLabelForeground = Color.Black,
				ToolStripLabelBackground = DefaultWhite,
				FormForeground = Color.Black,
				FormBackground = DefaultWhite
			};
		}
	}
	public static void ChangeControlsTheme(IList control, ThemeColors color, ToolStripRenderer? render)
	{
		foreach (object? c in control)
		{
			if (c == null) continue;
			ChangeControlTheme(c, color, render);
		}
	}
	public static void ChangeControlTheme(object c, ThemeColors color, ToolStripRenderer? render)
	{
        Control.CheckForIllegalCrossThreadCalls = false;
        switch (c)
		{
			case MenuStrip menu:
				//menu.ForeColor = color.MenuStripForeground;
				menu.BackColor = color.MenuStripBackground;
				// menu.RenderMode = ToolStripRenderMode.Custom;
				//menu.Renderer = render;
				ChangeControlsTheme(menu.Items, color, render); // shit menu.Controls was zero for some reason
				break;
			case ToolStripMenuItem item:
				item.ForeColor = color.ToolItemStripForeground;
				item.BackColor = color.ToolItemStripBackground;
				ChangeControlsTheme(item.DropDownItems, color, render);
				break;
			case ToolStrip toolStrip:
				toolStrip.ForeColor = color.ToolStripForeground;
				toolStrip.BackColor = color.ToolStripBackground;
				// toolStrip.RenderMode = ToolStripRenderMode.Custom;
				toolStrip.Renderer = render;
				ChangeControlsTheme(toolStrip.Items, color, render);
				break;
			case TrackBarMenuItem trackBar:
				trackBar.BackColor = color.ToolStripBackground;
                break;
			case ToolStripSeparator separator:
				separator.BackColor = Color.Red; //test
				separator.ForeColor = Color.Red; //test cuz it not work
				break;
			case RichTextBox richTextBox:
				richTextBox.ForeColor = color.RichTextBoxForeground;
				richTextBox.BackColor = color.RichTextBoxBackground;
				break;
			case Panel panel:
				panel.ForeColor = color.PanelForeground;
				panel.BackColor = color.PanelBackground;
				ChangeControlsTheme(panel.Controls, color, render);
				break;
			case Label label:
				label.ForeColor = color.LabelForeground;
				label.BackColor = color.LabelBackground;
				break;
			case ToolStripLabel toolStripLabel:
				toolStripLabel.ForeColor = color.ToolStripLabelForeground;
				toolStripLabel.BackColor = color.ToolStripLabelBackground;
				break;
			case Form form:
				form.BackColor = color.FormBackground;
				form.ForeColor = color.FormForeground;
				ChangeControlsTheme(form.Controls, color, render);
				break;
			default:
				break;
		}
	}
}
