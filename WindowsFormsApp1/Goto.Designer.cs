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
            OptionLabel2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            IgnoreOverflowCheckBox = new System.Windows.Forms.RadioButton();
            OptionsGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // OptionLabel
            // 
            OptionLabel.AutoSize = true;
            OptionLabel.Location = new System.Drawing.Point(18, 29);
            OptionLabel.Name = "OptionLabel";
            OptionLabel.Size = new System.Drawing.Size(46, 19);
            OptionLabel.TabIndex = 0;
            OptionLabel.Text = "Goto:";
            // 
            // GotoInput
            // 
            GotoInput.Location = new System.Drawing.Point(39, 111);
            GotoInput.Name = "GotoInput";
            GotoInput.Size = new System.Drawing.Size(408, 27);
            GotoInput.TabIndex = 1;
            GotoInput.KeyPress += GotoInputEvent;
            // 
            // GoButton
            // 
            GoButton.Location = new System.Drawing.Point(107, 144);
            GoButton.Name = "GoButton";
            GoButton.Size = new System.Drawing.Size(94, 29);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += Go_Click;
            // 
            // CancelGotoButton
            // 
            CancelGotoButton.Location = new System.Drawing.Point(271, 144);
            CancelGotoButton.Name = "CancelGotoButton";
            CancelGotoButton.Size = new System.Drawing.Size(94, 29);
            CancelGotoButton.TabIndex = 3;
            CancelGotoButton.Text = "Cancel";
            CancelGotoButton.UseVisualStyleBackColor = true;
            CancelGotoButton.Click += Cancel_Click;
            // 
            // OptionLine
            // 
            OptionLine.AutoSize = true;
            OptionLine.Checked = true;
            OptionLine.Location = new System.Drawing.Point(69, 27);
            OptionLine.Name = "OptionLine";
            OptionLine.Size = new System.Drawing.Size(55, 23);
            OptionLine.TabIndex = 4;
            OptionLine.TabStop = true;
            OptionLine.Text = "line";
            OptionLine.UseVisualStyleBackColor = true;
            // 
            // OptionPos
            // 
            OptionPos.AutoSize = true;
            OptionPos.Location = new System.Drawing.Point(130, 27);
            OptionPos.Name = "OptionPos";
            OptionPos.Size = new System.Drawing.Size(55, 23);
            OptionPos.TabIndex = 5;
            OptionPos.Text = "pos";
            OptionPos.UseVisualStyleBackColor = true;
            // 
            // OptionsGroupBox
            // 
            OptionsGroupBox.Controls.Add(OptionLabel2);
            OptionsGroupBox.Controls.Add(OptionLabel);
            OptionsGroupBox.Controls.Add(OptionPos);
            OptionsGroupBox.Controls.Add(OptionLine);
            OptionsGroupBox.Controls.Add(panel1);
            OptionsGroupBox.Location = new System.Drawing.Point(39, 8);
            OptionsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            OptionsGroupBox.Name = "OptionsGroupBox";
            OptionsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            OptionsGroupBox.Size = new System.Drawing.Size(257, 96);
            OptionsGroupBox.TabIndex = 6;
            OptionsGroupBox.TabStop = false;
            OptionsGroupBox.Text = "Options";
            // 
            // OptionLabel2
            // 
            OptionLabel2.AutoSize = true;
            OptionLabel2.Location = new System.Drawing.Point(18, 61);
            OptionLabel2.Name = "OptionLabel2";
            OptionLabel2.Size = new System.Drawing.Size(126, 19);
            OptionLabel2.TabIndex = 9;
            OptionLabel2.Text = "Ignore Overflow:";
            // 
            // panel1
            // 
            panel1.Controls.Add(IgnoreOverflowCheckBox);
            panel1.Location = new System.Drawing.Point(150, 61);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(35, 23);
            panel1.TabIndex = 8;
            panel1.Click += IgnoreOverflowCheckBox_Click;
            // 
            // IgnoreOverflowCheckBox
            // 
            IgnoreOverflowCheckBox.AutoSize = true;
            IgnoreOverflowCheckBox.Checked = true;
            IgnoreOverflowCheckBox.Location = new System.Drawing.Point(8, 3);
            IgnoreOverflowCheckBox.Name = "IgnoreOverflowCheckBox";
            IgnoreOverflowCheckBox.Size = new System.Drawing.Size(17, 16);
            IgnoreOverflowCheckBox.TabIndex = 7;
            IgnoreOverflowCheckBox.TabStop = true;
            IgnoreOverflowCheckBox.UseVisualStyleBackColor = true;
            IgnoreOverflowCheckBox.Click += IgnoreOverflowCheckBox_Click;
            // 
            // Goto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(485, 187);
            Controls.Add(OptionsGroupBox);
            Controls.Add(CancelGotoButton);
            Controls.Add(GoButton);
            Controls.Add(GotoInput);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Goto";
            Text = "Goto";
            OptionsGroupBox.ResumeLayout(false);
            OptionsGroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton IgnoreOverflowCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OptionLabel2;
    }
}