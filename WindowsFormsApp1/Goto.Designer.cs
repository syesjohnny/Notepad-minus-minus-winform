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
            OptionLine.Location = new System.Drawing.Point(68, 27);
            OptionLine.Name = "OptionLine";
            OptionLine.Size = new System.Drawing.Size(55, 23);
            OptionLine.TabIndex = 4;
            OptionLine.TabStop = true;
            OptionLine.Text = "line";
            OptionLine.UseVisualStyleBackColor = true;
            OptionLine.Click += OptionLine_Click;
            // 
            // OptionPos
            // 
            OptionPos.AutoSize = true;
            OptionPos.Location = new System.Drawing.Point(130, 27);
            OptionPos.Name = "OptionPos";
            OptionPos.Size = new System.Drawing.Size(55, 23);
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
            OptionsGroupBox.Location = new System.Drawing.Point(39, 8);
            OptionsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            OptionsGroupBox.Name = "OptionsGroupBox";
            OptionsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            OptionsGroupBox.Size = new System.Drawing.Size(257, 96);
            OptionsGroupBox.TabIndex = 6;
            OptionsGroupBox.TabStop = false;
            OptionsGroupBox.Text = "Options";
            // 
            // IgnoreOverflowCheckBox
            // 
            IgnoreOverflowCheckBox.AutoSize = true;
            IgnoreOverflowCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            IgnoreOverflowCheckBox.Location = new System.Drawing.Point(18, 57);
            IgnoreOverflowCheckBox.Margin = new System.Windows.Forms.Padding(4);
            IgnoreOverflowCheckBox.Name = "IgnoreOverflowCheckBox";
            IgnoreOverflowCheckBox.Size = new System.Drawing.Size(148, 23);
            IgnoreOverflowCheckBox.TabIndex = 6;
            IgnoreOverflowCheckBox.Text = "Ignore Overflow:";
            IgnoreOverflowCheckBox.UseVisualStyleBackColor = true;
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