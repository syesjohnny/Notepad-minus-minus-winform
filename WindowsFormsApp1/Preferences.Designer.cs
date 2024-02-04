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
			this.OptionListBox = new System.Windows.Forms.ListBox();
			this.ColorSelect = new System.Windows.Forms.ColorDialog();
			this.SettingTabPanel = new System.Windows.Forms.Panel();
			this.discordrpcpanel = new System.Windows.Forms.Panel();
			this.showname = new System.Windows.Forms.CheckBox();
			this.enablerpc = new System.Windows.Forms.CheckBox();
			this.loadsetting = new System.Windows.Forms.Button();
			this.savesetting = new System.Windows.Forms.Button();
			this.Hint = new System.Windows.Forms.Label();
			this.SettingTabPanel.SuspendLayout();
			this.discordrpcpanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// OptionListBox
			// 
			this.OptionListBox.FormattingEnabled = true;
			this.OptionListBox.ItemHeight = 15;
			this.OptionListBox.Items.AddRange(new object[] { "Settings", "Discord RPC", "Experimentals" });
			this.OptionListBox.Location = new System.Drawing.Point(9, 9);
			this.OptionListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.OptionListBox.Name = "OptionListBox";
			this.OptionListBox.Size = new System.Drawing.Size(118, 319);
			this.OptionListBox.TabIndex = 0;
			this.OptionListBox.SelectedIndexChanged += this.OnOptionListBoxChange;
			// 
			// SettingTabPanel
			// 
			this.SettingTabPanel.Controls.Add(this.loadsetting);
			this.SettingTabPanel.Controls.Add(this.savesetting);
			this.SettingTabPanel.Location = new System.Drawing.Point(131, 9);
			this.SettingTabPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SettingTabPanel.Name = "SettingTabPanel";
			this.SettingTabPanel.Size = new System.Drawing.Size(474, 316);
			this.SettingTabPanel.TabIndex = 3;
			this.SettingTabPanel.Visible = false;
			// 
			// discordrpcpanel
			// 
			this.discordrpcpanel.Controls.Add(this.showname);
			this.discordrpcpanel.Controls.Add(this.enablerpc);
			this.discordrpcpanel.Location = new System.Drawing.Point(131, 9);
			this.discordrpcpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.discordrpcpanel.Name = "discordrpcpanel";
			this.discordrpcpanel.Size = new System.Drawing.Size(474, 316);
			this.discordrpcpanel.TabIndex = 4;
			this.discordrpcpanel.Visible = false;
			// 
			// showname
			// 
			this.showname.AutoSize = true;
			this.showname.Location = new System.Drawing.Point(14, 39);
			this.showname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.showname.Name = "showname";
			this.showname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.showname.Size = new System.Drawing.Size(111, 19);
			this.showname.TabIndex = 1;
			this.showname.Text = "Show File Name";
			this.showname.UseVisualStyleBackColor = true;
			// 
			// enablerpc
			// 
			this.enablerpc.AutoSize = true;
			this.enablerpc.Location = new System.Drawing.Point(14, 17);
			this.enablerpc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.enablerpc.Name = "enablerpc";
			this.enablerpc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.enablerpc.Size = new System.Drawing.Size(61, 19);
			this.enablerpc.TabIndex = 0;
			this.enablerpc.Text = "Enable";
			this.enablerpc.UseVisualStyleBackColor = true;
			this.enablerpc.CheckedChanged += this.enablerpc_CheckedChanged;
			// 
			// loadsetting
			// 
			this.loadsetting.Location = new System.Drawing.Point(14, 48);
			this.loadsetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.loadsetting.Name = "loadsetting";
			this.loadsetting.Size = new System.Drawing.Size(92, 23);
			this.loadsetting.TabIndex = 1;
			this.loadsetting.Text = "Load Settings";
			this.loadsetting.UseVisualStyleBackColor = true;
			this.loadsetting.Click += this.loadsetting_Click;
			// 
			// savesetting
			// 
			this.savesetting.Location = new System.Drawing.Point(14, 12);
			this.savesetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.savesetting.Name = "savesetting";
			this.savesetting.Size = new System.Drawing.Size(92, 23);
			this.savesetting.TabIndex = 0;
			this.savesetting.Text = "Save Settings";
			this.savesetting.UseVisualStyleBackColor = true;
			this.savesetting.Click += this.savesetting_Click;
			// 
			// Hint
			// 
			this.Hint.AutoSize = true;
			this.Hint.Location = new System.Drawing.Point(9, 333);
			this.Hint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Hint.Name = "Hint";
			this.Hint.Size = new System.Drawing.Size(38, 15);
			this.Hint.TabIndex = 2;
			this.Hint.Text = "label1";
			// 
			// Preferences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 355);
			this.Controls.Add(this.discordrpcpanel);
			this.Controls.Add(this.Hint);
			this.Controls.Add(this.SettingTabPanel);
			this.Controls.Add(this.OptionListBox);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Preferences";
			this.Text = "Preferences";
			this.SettingTabPanel.ResumeLayout(false);
			this.discordrpcpanel.ResumeLayout(false);
			this.discordrpcpanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ListBox OptionListBox;
		private System.Windows.Forms.ColorDialog ColorSelect;
        private System.Windows.Forms.Panel SettingTabPanel;
        private System.Windows.Forms.Button loadsetting;
        private System.Windows.Forms.Button savesetting;
        private System.Windows.Forms.Label Hint;
        private System.Windows.Forms.Panel discordrpcpanel;
        private System.Windows.Forms.CheckBox showname;
        private System.Windows.Forms.CheckBox enablerpc;
    }
}