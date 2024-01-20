namespace NotePadMinusMinus
{
    partial class findreplace
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
            tabControl1 = new System.Windows.Forms.TabControl();
            Find = new System.Windows.Forms.TabPage();
            Replace = new System.Windows.Forms.TabPage();
            Highlight = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Find);
            tabControl1.Controls.Add(Replace);
            tabControl1.Controls.Add(Highlight);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Find
            // 
            Find.Location = new System.Drawing.Point(4, 28);
            Find.Name = "Find";
            Find.Padding = new System.Windows.Forms.Padding(3);
            Find.Size = new System.Drawing.Size(792, 418);
            Find.TabIndex = 0;
            Find.Text = "Find";
            Find.UseVisualStyleBackColor = true;
            // 
            // Replace
            // 
            Replace.Location = new System.Drawing.Point(4, 28);
            Replace.Name = "Replace";
            Replace.Padding = new System.Windows.Forms.Padding(3);
            Replace.Size = new System.Drawing.Size(792, 418);
            Replace.TabIndex = 1;
            Replace.Text = "Replace";
            Replace.UseVisualStyleBackColor = true;
            // 
            // Highlight
            // 
            Highlight.Location = new System.Drawing.Point(4, 28);
            Highlight.Name = "Highlight";
            Highlight.Size = new System.Drawing.Size(792, 418);
            Highlight.TabIndex = 2;
            Highlight.Text = "Highlight";
            Highlight.UseVisualStyleBackColor = true;
            // 
            // findreplace
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tabControl1);
            Name = "findreplace";
            Text = "findreplace";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Find;
        private System.Windows.Forms.TabPage Replace;
        private System.Windows.Forms.TabPage Highlight;
    }
}