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
            listBox1 = new System.Windows.Forms.ListBox();
            stylepanel = new System.Windows.Forms.Panel();
            themetoggle = new System.Windows.Forms.CheckBox();
            ColorSelect = new System.Windows.Forms.ColorDialog();
            stylepanel.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Items.AddRange(new object[] { "Style" });
            listBox1.Location = new System.Drawing.Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(150, 422);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += changepanel;
            // 
            // stylepanel
            // 
            stylepanel.Controls.Add(themetoggle);
            stylepanel.Location = new System.Drawing.Point(168, 12);
            stylepanel.Name = "stylepanel";
            stylepanel.Size = new System.Drawing.Size(610, 422);
            stylepanel.TabIndex = 1;
            // 
            // themetoggle
            // 
            themetoggle.AutoSize = true;
            themetoggle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            themetoggle.Location = new System.Drawing.Point(26, 28);
            themetoggle.Name = "themetoggle";
            themetoggle.Size = new System.Drawing.Size(109, 23);
            themetoggle.TabIndex = 2;
            themetoggle.Text = "Dark Mode";
            themetoggle.UseVisualStyleBackColor = true;
            themetoggle.CheckedChanged += themetoggle_CheckedChanged;
            // 
            // Preferences
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(stylepanel);
            Controls.Add(listBox1);
            Name = "Preferences";
            Text = "Preferences";
            stylepanel.ResumeLayout(false);
            stylepanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel stylepanel;
        private System.Windows.Forms.ColorDialog ColorSelect;
        private System.Windows.Forms.CheckBox themetoggle;
    }
}