namespace NotePadMinusMinus
{
	partial class FindReplace
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
			FindLabel = new System.Windows.Forms.Label();
			FindInput = new System.Windows.Forms.RichTextBox();
			ReplaceCheckBox = new System.Windows.Forms.CheckBox();
			ReplaceInput = new System.Windows.Forms.RichTextBox();
			ReplaceButton = new System.Windows.Forms.Button();
			ReplaceAllButton = new System.Windows.Forms.Button();
			FindNextButton = new System.Windows.Forms.Button();
			HightLightCheckBox = new System.Windows.Forms.CheckBox();
			BackwardCheckBox = new System.Windows.Forms.CheckBox();
			tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// FindLabel
			// 
			FindLabel.AutoSize = true;
			FindLabel.Dock = System.Windows.Forms.DockStyle.Right;
			FindLabel.Location = new System.Drawing.Point(75, 0);
			FindLabel.Name = "FindLabel";
			FindLabel.Size = new System.Drawing.Size(33, 42);
			FindLabel.TabIndex = 0;
			FindLabel.Text = "Find:";
			// 
			// FindInput
			// 
			FindInput.Location = new System.Drawing.Point(110, 30);
			FindInput.Name = "FindInput";
			FindInput.Size = new System.Drawing.Size(265, 42);
			FindInput.TabIndex = 1;
			FindInput.Text = "";
			// 
			// ReplaceCheckBox
			// 
			ReplaceCheckBox.AutoSize = true;
			ReplaceCheckBox.Location = new System.Drawing.Point(9, 78);
			ReplaceCheckBox.Name = "ReplaceCheckBox";
			ReplaceCheckBox.Size = new System.Drawing.Size(95, 19);
			ReplaceCheckBox.TabIndex = 2;
			ReplaceCheckBox.Text = "Replace With";
			ReplaceCheckBox.UseVisualStyleBackColor = true;
			ReplaceCheckBox.CheckedChanged += ReplaceCheckBox_CheckedChanged;
			// 
			// ReplaceInput
			// 
			ReplaceInput.Enabled = false;
			ReplaceInput.Location = new System.Drawing.Point(110, 78);
			ReplaceInput.Name = "ReplaceInput";
			ReplaceInput.Size = new System.Drawing.Size(265, 44);
			ReplaceInput.TabIndex = 3;
			ReplaceInput.Text = "";
			// 
			// ReplaceButton
			// 
			ReplaceButton.Enabled = false;
			ReplaceButton.Location = new System.Drawing.Point(110, 128);
			ReplaceButton.Name = "ReplaceButton";
			ReplaceButton.Size = new System.Drawing.Size(75, 23);
			ReplaceButton.TabIndex = 4;
			ReplaceButton.Text = "Replace";
			ReplaceButton.UseVisualStyleBackColor = true;
			ReplaceButton.Click += ReplaceButton_Click;
			// 
			// ReplaceAllButton
			// 
			ReplaceAllButton.Enabled = false;
			ReplaceAllButton.Location = new System.Drawing.Point(272, 128);
			ReplaceAllButton.Name = "ReplaceAllButton";
			ReplaceAllButton.Size = new System.Drawing.Size(103, 23);
			ReplaceAllButton.TabIndex = 5;
			ReplaceAllButton.Text = "Replace All";
			ReplaceAllButton.UseVisualStyleBackColor = true;
			ReplaceAllButton.Click += ReplaceAllButton_Click;
			// 
			// FindNextButton
			// 
			FindNextButton.Location = new System.Drawing.Point(110, 157);
			FindNextButton.Name = "FindNextButton";
			FindNextButton.Size = new System.Drawing.Size(75, 23);
			FindNextButton.TabIndex = 6;
			FindNextButton.Text = "Find Next";
			FindNextButton.UseVisualStyleBackColor = true;
			FindNextButton.Click += FindNextButton_Click;
			// 
			// HightLightCheckBox
			// 
			HightLightCheckBox.AutoSize = true;
			HightLightCheckBox.Location = new System.Drawing.Point(12, 132);
			HightLightCheckBox.Name = "HightLightCheckBox";
			HightLightCheckBox.Size = new System.Drawing.Size(76, 19);
			HightLightCheckBox.TabIndex = 7;
			HightLightCheckBox.Text = "Highlight";
			HightLightCheckBox.UseVisualStyleBackColor = true;
			// 
			// BackwardCheckBox
			// 
			BackwardCheckBox.AutoSize = true;
			BackwardCheckBox.Location = new System.Drawing.Point(12, 157);
			BackwardCheckBox.Name = "BackwardCheckBox";
			BackwardCheckBox.Size = new System.Drawing.Size(77, 19);
			BackwardCheckBox.TabIndex = 8;
			BackwardCheckBox.Text = "Backward";
			BackwardCheckBox.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(FindLabel, 0, 0);
			tableLayoutPanel1.Location = new System.Drawing.Point(-1, 30);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new System.Drawing.Size(111, 42);
			tableLayoutPanel1.TabIndex = 9;
			// 
			// FindReplace
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(409, 190);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(BackwardCheckBox);
			Controls.Add(HightLightCheckBox);
			Controls.Add(FindNextButton);
			Controls.Add(ReplaceAllButton);
			Controls.Add(ReplaceButton);
			Controls.Add(ReplaceInput);
			Controls.Add(ReplaceCheckBox);
			Controls.Add(FindInput);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Margin = new System.Windows.Forms.Padding(2);
			Name = "FindReplace";
			Text = "findreplace";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label FindLabel;
		private System.Windows.Forms.RichTextBox FindInput;
		private System.Windows.Forms.CheckBox ReplaceCheckBox;
		private System.Windows.Forms.RichTextBox ReplaceInput;
		private System.Windows.Forms.Button ReplaceButton;
		private System.Windows.Forms.Button ReplaceAllButton;
		private System.Windows.Forms.Button FindNextButton;
		private System.Windows.Forms.CheckBox HightLightCheckBox;
		private System.Windows.Forms.CheckBox BackwardCheckBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}