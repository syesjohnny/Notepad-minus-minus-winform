namespace NotePadMinusMinus
{
    partial class What_s_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(What_s_New));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            version = new System.Windows.Forms.Label();
            changeloggroupbox = new System.Windows.Forms.GroupBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            FullChangeLog = new System.Windows.Forms.LinkLabel();
            AllReleases = new System.Windows.Forms.LinkLabel();
            OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            changeloggroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(254, 254, 254);
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(80, 127);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // version
            // 
            version.AutoSize = true;
            version.Location = new System.Drawing.Point(129, 424);
            version.Name = "version";
            version.Size = new System.Drawing.Size(64, 19);
            version.TabIndex = 1;
            version.Text = "V0.0.3.0";
            // 
            // changeloggroupbox
            // 
            changeloggroupbox.Controls.Add(richTextBox1);
            changeloggroupbox.Location = new System.Drawing.Point(129, 12);
            changeloggroupbox.Name = "changeloggroupbox";
            changeloggroupbox.Size = new System.Drawing.Size(290, 404);
            changeloggroupbox.TabIndex = 3;
            changeloggroupbox.TabStop = false;
            changeloggroupbox.Text = "What's New?";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.Color.FromArgb(254, 254, 254);
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Location = new System.Drawing.Point(6, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(278, 370);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // FullChangeLog
            // 
            FullChangeLog.AutoSize = true;
            FullChangeLog.Location = new System.Drawing.Point(10, 186);
            FullChangeLog.Name = "FullChangeLog";
            FullChangeLog.Size = new System.Drawing.Size(115, 19);
            FullChangeLog.TabIndex = 4;
            FullChangeLog.TabStop = true;
            FullChangeLog.Text = "Full Changelog";
            FullChangeLog.LinkClicked += FullChangeLog_LinkClicked;
            // 
            // AllReleases
            // 
            AllReleases.AutoSize = true;
            AllReleases.Location = new System.Drawing.Point(10, 225);
            AllReleases.Name = "AllReleases";
            AllReleases.Size = new System.Drawing.Size(91, 19);
            AllReleases.TabIndex = 5;
            AllReleases.TabStop = true;
            AllReleases.Text = "All Releases";
            AllReleases.LinkClicked += AllReleases_LinkClicked;
            // 
            // OK
            // 
            OK.Location = new System.Drawing.Point(214, 419);
            OK.Name = "OK";
            OK.Size = new System.Drawing.Size(94, 29);
            OK.TabIndex = 6;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // What_s_New
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(254, 254, 254);
            ClientSize = new System.Drawing.Size(425, 499);
            ControlBox = false;
            Controls.Add(OK);
            Controls.Add(AllReleases);
            Controls.Add(FullChangeLog);
            Controls.Add(changeloggroupbox);
            Controls.Add(version);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "What_s_New";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "What's New?";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            changeloggroupbox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.GroupBox changeloggroupbox;
        private System.Windows.Forms.LinkLabel FullChangeLog;
        private System.Windows.Forms.LinkLabel AllReleases;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}