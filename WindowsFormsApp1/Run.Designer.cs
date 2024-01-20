namespace NotePadMinusMinus
{
	partial class Run
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
			FileSelectorInput = new System.Windows.Forms.TextBox();
			FileSelectorButton = new System.Windows.Forms.Button();
			RunFileSelectorGroup = new System.Windows.Forms.GroupBox();
			RunButton = new System.Windows.Forms.Button();
			RunFileSelectorGroup.SuspendLayout();
			SuspendLayout();
			// 
			// FileSelectorInput
			// 
			FileSelectorInput.Location = new System.Drawing.Point(16, 32);
			FileSelectorInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			FileSelectorInput.Name = "FileSelectorInput";
			FileSelectorInput.Size = new System.Drawing.Size(219, 23);
			FileSelectorInput.TabIndex = 0;
			// 
			// FileSelectorButton
			// 
			FileSelectorButton.Location = new System.Drawing.Point(247, 81);
			FileSelectorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			FileSelectorButton.Name = "FileSelectorButton";
			FileSelectorButton.Size = new System.Drawing.Size(26, 23);
			FileSelectorButton.TabIndex = 2;
			FileSelectorButton.Text = "...";
			FileSelectorButton.UseVisualStyleBackColor = true;
			FileSelectorButton.Click += FileSelectorButton_Click;
			// 
			// RunFileSelectorGroup
			// 
			RunFileSelectorGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			RunFileSelectorGroup.Controls.Add(FileSelectorInput);
			RunFileSelectorGroup.Location = new System.Drawing.Point(9, 49);
			RunFileSelectorGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			RunFileSelectorGroup.Name = "RunFileSelectorGroup";
			RunFileSelectorGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			RunFileSelectorGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
			RunFileSelectorGroup.Size = new System.Drawing.Size(275, 71);
			RunFileSelectorGroup.TabIndex = 3;
			RunFileSelectorGroup.TabStop = false;
			RunFileSelectorGroup.Text = "Run With...";
			// 
			// RunButton
			// 
			RunButton.Location = new System.Drawing.Point(25, 136);
			RunButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			RunButton.Name = "RunButton";
			RunButton.Size = new System.Drawing.Size(73, 23);
			RunButton.TabIndex = 4;
			RunButton.Text = "Run";
			RunButton.UseVisualStyleBackColor = true;
			RunButton.Click += RunButton_Click;
			// 
			// Run
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(293, 188);
			Controls.Add(RunButton);
			Controls.Add(FileSelectorButton);
			Controls.Add(RunFileSelectorGroup);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			Name = "Run";
			Text = "Run";
			RunFileSelectorGroup.ResumeLayout(false);
			RunFileSelectorGroup.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TextBox FileSelectorInput;
		private System.Windows.Forms.Button FileSelectorButton;
		private System.Windows.Forms.GroupBox RunFileSelectorGroup;
		private System.Windows.Forms.Button RunButton;
	}
}