namespace NotePadMinusMinus
{
	partial class Goto
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
			OptionLabel = new System.Windows.Forms.Label();
			GotoInput = new System.Windows.Forms.TextBox();
			GoButton = new System.Windows.Forms.Button();
			CancelGotoButton = new System.Windows.Forms.Button();
			OptionLine = new System.Windows.Forms.RadioButton();
			OptionPos = new System.Windows.Forms.RadioButton();
			OptionsGroupBox = new System.Windows.Forms.GroupBox();
			IgnoreOverflowCheckBox = new System.Windows.Forms.CheckBox();
			OptionsGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// OptionLabel
			// 
			OptionLabel.AutoSize = true;
			OptionLabel.Location = new System.Drawing.Point(14, 23);
			OptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			OptionLabel.Name = "OptionLabel";
			OptionLabel.Size = new System.Drawing.Size(36, 15);
			OptionLabel.TabIndex = 0;
			OptionLabel.Text = "Goto:";
			// 
			// GotoInput
			// 
			GotoInput.Location = new System.Drawing.Point(30, 76);
			GotoInput.Margin = new System.Windows.Forms.Padding(2);
			GotoInput.Name = "GotoInput";
			GotoInput.Size = new System.Drawing.Size(318, 23);
			GotoInput.TabIndex = 1;
			GotoInput.KeyPress += GotoInputEvent;
			// 
			// GoButton
			// 
			GoButton.Location = new System.Drawing.Point(83, 114);
			GoButton.Margin = new System.Windows.Forms.Padding(2);
			GoButton.Name = "GoButton";
			GoButton.Size = new System.Drawing.Size(73, 23);
			GoButton.TabIndex = 2;
			GoButton.Text = "Go";
			GoButton.UseVisualStyleBackColor = true;
			GoButton.Click += Go_Click;
			// 
			// CancelGotoButton
			// 
			CancelGotoButton.Location = new System.Drawing.Point(211, 114);
			CancelGotoButton.Margin = new System.Windows.Forms.Padding(2);
			CancelGotoButton.Name = "CancelGotoButton";
			CancelGotoButton.Size = new System.Drawing.Size(73, 23);
			CancelGotoButton.TabIndex = 3;
			CancelGotoButton.Text = "Cancel";
			CancelGotoButton.UseVisualStyleBackColor = true;
			CancelGotoButton.Click += Cancel_Click;
			// 
			// OptionLine
			// 
			OptionLine.AutoSize = true;
			OptionLine.Checked = true;
			OptionLine.Location = new System.Drawing.Point(53, 21);
			OptionLine.Margin = new System.Windows.Forms.Padding(2);
			OptionLine.Name = "OptionLine";
			OptionLine.Size = new System.Drawing.Size(44, 19);
			OptionLine.TabIndex = 4;
			OptionLine.TabStop = true;
			OptionLine.Text = "line";
			OptionLine.UseVisualStyleBackColor = true;
			OptionLine.Click += OptionLine_Click;
			// 
			// OptionPos
			// 
			OptionPos.AutoSize = true;
			OptionPos.Location = new System.Drawing.Point(101, 21);
			OptionPos.Margin = new System.Windows.Forms.Padding(2);
			OptionPos.Name = "OptionPos";
			OptionPos.Size = new System.Drawing.Size(44, 19);
			OptionPos.TabIndex = 5;
			OptionPos.TabStop = true;
			OptionPos.Text = "pos";
			OptionPos.UseVisualStyleBackColor = true;
			OptionPos.Click += OptionPos_Click;
			// 
			// OptionsGroupBox
			// 
			OptionsGroupBox.Controls.Add(IgnoreOverflowCheckBox);
			OptionsGroupBox.Controls.Add(OptionLabel);
			OptionsGroupBox.Controls.Add(OptionPos);
			OptionsGroupBox.Controls.Add(OptionLine);
			OptionsGroupBox.Location = new System.Drawing.Point(30, 6);
			OptionsGroupBox.Name = "OptionsGroupBox";
			OptionsGroupBox.Size = new System.Drawing.Size(200, 65);
			OptionsGroupBox.TabIndex = 6;
			OptionsGroupBox.TabStop = false;
			OptionsGroupBox.Text = "Options";
			// 
			// IgnoreOverflowCheckBox
			// 
			IgnoreOverflowCheckBox.AutoSize = true;
			IgnoreOverflowCheckBox.Location = new System.Drawing.Point(53, 40);
			IgnoreOverflowCheckBox.Name = "IgnoreOverflowCheckBox";
			IgnoreOverflowCheckBox.Size = new System.Drawing.Size(111, 19);
			IgnoreOverflowCheckBox.TabIndex = 6;
			IgnoreOverflowCheckBox.Text = "Ignore Overflow";
			IgnoreOverflowCheckBox.UseVisualStyleBackColor = true;
			// 
			// Goto
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(377, 148);
			Controls.Add(OptionsGroupBox);
			Controls.Add(CancelGotoButton);
			Controls.Add(GoButton);
			Controls.Add(GotoInput);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Margin = new System.Windows.Forms.Padding(2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Goto";
			Text = "Goto";
			OptionsGroupBox.ResumeLayout(false);
			OptionsGroupBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label OptionLabel;
		private System.Windows.Forms.Button CancelGotoButton;
		public System.Windows.Forms.Button GoButton;
		public System.Windows.Forms.TextBox GotoInput;
		public System.Windows.Forms.RadioButton OptionLine;
		private System.Windows.Forms.GroupBox OptionsGroupBox;
		public System.Windows.Forms.RadioButton OptionPos;
		private System.Windows.Forms.CheckBox IgnoreOverflowCheckBox;
	}
}