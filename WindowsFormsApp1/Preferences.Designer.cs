namespace NotePadMinusMinus
{
	partial class Preferences
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			OptionListBox = new System.Windows.Forms.ListBox();
			StylePanel = new System.Windows.Forms.Panel();
			TestTabPanel = new System.Windows.Forms.Panel();
			TestTabPanelCheck = new System.Windows.Forms.CheckBox();
			DarkThemeToggle = new System.Windows.Forms.CheckBox();
			ColorSelect = new System.Windows.Forms.ColorDialog();
			StylePanel.SuspendLayout();
			TestTabPanel.SuspendLayout();
			SuspendLayout();
			// 
			// OptionListBox
			// 
			OptionListBox.FormattingEnabled = true;
			OptionListBox.ItemHeight = 15;
			OptionListBox.Items.AddRange(new object[] { "Style", "Test Tab" });
			OptionListBox.Location = new System.Drawing.Point(9, 9);
			OptionListBox.Margin = new System.Windows.Forms.Padding(2);
			OptionListBox.Name = "OptionListBox";
			OptionListBox.Size = new System.Drawing.Size(118, 334);
			OptionListBox.TabIndex = 0;
			OptionListBox.SelectedIndexChanged += OnOptionListBoxChange;
			// 
			// StylePanel
			// 
			StylePanel.Controls.Add(DarkThemeToggle);
			StylePanel.Controls.Add(TestTabPanel);
			StylePanel.Location = new System.Drawing.Point(131, 9);
			StylePanel.Margin = new System.Windows.Forms.Padding(2);
			StylePanel.Name = "StylePanel";
			StylePanel.Size = new System.Drawing.Size(474, 333);
			StylePanel.TabIndex = 1;
			// 
			// TestTabPanel
			// 
			TestTabPanel.Controls.Add(TestTabPanelCheck);
			TestTabPanel.Location = new System.Drawing.Point(0, 0);
			TestTabPanel.Margin = new System.Windows.Forms.Padding(2);
			TestTabPanel.Name = "TestTabPanel";
			TestTabPanel.Size = new System.Drawing.Size(474, 333);
			TestTabPanel.TabIndex = 3;
			TestTabPanel.Visible = false;
			// 
			// TestTabPanelCheck
			// 
			TestTabPanelCheck.AutoSize = true;
			TestTabPanelCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			TestTabPanelCheck.Location = new System.Drawing.Point(20, 22);
			TestTabPanelCheck.Margin = new System.Windows.Forms.Padding(2);
			TestTabPanelCheck.Name = "TestTabPanelCheck";
			TestTabPanelCheck.Size = new System.Drawing.Size(46, 19);
			TestTabPanelCheck.TabIndex = 2;
			TestTabPanelCheck.Text = "Test";
			TestTabPanelCheck.UseVisualStyleBackColor = true;
			// 
			// DarkThemeToggle
			// 
			DarkThemeToggle.AutoSize = true;
			DarkThemeToggle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			DarkThemeToggle.Location = new System.Drawing.Point(20, 22);
			DarkThemeToggle.Margin = new System.Windows.Forms.Padding(2);
			DarkThemeToggle.Name = "DarkThemeToggle";
			DarkThemeToggle.Size = new System.Drawing.Size(84, 19);
			DarkThemeToggle.TabIndex = 2;
			DarkThemeToggle.Text = "Dark Mode";
			DarkThemeToggle.UseVisualStyleBackColor = true;
			DarkThemeToggle.CheckedChanged += ToggleDarkTheme;
			// 
			// Preferences
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(622, 355);
			Controls.Add(StylePanel);
			Controls.Add(OptionListBox);
			Margin = new System.Windows.Forms.Padding(2);
			Name = "Preferences";
			Text = "Preferences";
			StylePanel.ResumeLayout(false);
			StylePanel.PerformLayout();
			TestTabPanel.ResumeLayout(false);
			TestTabPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.ListBox OptionListBox;
		private System.Windows.Forms.Panel StylePanel;
		private System.Windows.Forms.ColorDialog ColorSelect;
		private System.Windows.Forms.CheckBox DarkThemeToggle;
		private System.Windows.Forms.Panel TestTabPanel;
		private System.Windows.Forms.CheckBox TestTabPanelCheck;
	}
}