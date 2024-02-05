namespace NotePadMinusMinus
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            OKButton = new System.Windows.Forms.Button();
            APPImage = new System.Windows.Forms.PictureBox();
            APPName = new System.Windows.Forms.Label();
            APPVersion = new System.Windows.Forms.Label();
            NotepadMinusMinusGithub = new System.Windows.Forms.LinkLabel();
            APPLICENSES = new System.Windows.Forms.LinkLabel();
            AboutArea = new System.Windows.Forms.GroupBox();
            AboutText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)APPImage).BeginInit();
            AboutArea.SuspendLayout();
            SuspendLayout();
            // 
            // OKButton
            // 
            OKButton.Location = new System.Drawing.Point(158, 345);
            OKButton.Name = "OKButton";
            OKButton.Size = new System.Drawing.Size(94, 29);
            OKButton.TabIndex = 0;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // APPImage
            // 
            APPImage.Image = (System.Drawing.Image)resources.GetObject("APPImage.Image");
            APPImage.Location = new System.Drawing.Point(34, 39);
            APPImage.Name = "APPImage";
            APPImage.Size = new System.Drawing.Size(100, 100);
            APPImage.TabIndex = 1;
            APPImage.TabStop = false;
            // 
            // APPName
            // 
            APPName.AutoSize = true;
            APPName.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            APPName.Location = new System.Drawing.Point(156, 39);
            APPName.Name = "APPName";
            APPName.Size = new System.Drawing.Size(117, 26);
            APPName.TabIndex = 2;
            APPName.Text = "Notepad--";
            // 
            // APPVersion
            // 
            APPVersion.AutoSize = true;
            APPVersion.Location = new System.Drawing.Point(158, 74);
            APPVersion.Name = "APPVersion";
            APPVersion.Size = new System.Drawing.Size(204, 19);
            APPVersion.TabIndex = 3;
            APPVersion.Text = "Version: v0.0.3.0 pre-release";
            // 
            // NotepadMinusMinusGithub
            // 
            NotepadMinusMinusGithub.AutoSize = true;
            NotepadMinusMinusGithub.Location = new System.Drawing.Point(158, 105);
            NotepadMinusMinusGithub.Name = "NotepadMinusMinusGithub";
            NotepadMinusMinusGithub.Size = new System.Drawing.Size(56, 19);
            NotepadMinusMinusGithub.TabIndex = 4;
            NotepadMinusMinusGithub.TabStop = true;
            NotepadMinusMinusGithub.Text = "Github";
            NotepadMinusMinusGithub.LinkClicked += NotepadMinusMinusGithub_LinkClicked;
            // 
            // APPLICENSES
            // 
            APPLICENSES.AutoSize = true;
            APPLICENSES.Location = new System.Drawing.Point(220, 105);
            APPLICENSES.Name = "APPLICENSES";
            APPLICENSES.Size = new System.Drawing.Size(77, 19);
            APPLICENSES.TabIndex = 5;
            APPLICENSES.TabStop = true;
            APPLICENSES.Text = "LICENSES";
            APPLICENSES.LinkClicked += APPLICENSES_LinkClicked;
            // 
            // AboutArea
            // 
            AboutArea.Controls.Add(AboutText);
            AboutArea.Location = new System.Drawing.Point(34, 166);
            AboutArea.Name = "AboutArea";
            AboutArea.Size = new System.Drawing.Size(359, 99);
            AboutArea.TabIndex = 6;
            AboutArea.TabStop = false;
            AboutArea.Text = "About";
            // 
            // AboutText
            // 
            AboutText.AutoSize = true;
            AboutText.Location = new System.Drawing.Point(27, 32);
            AboutText.Name = "AboutText";
            AboutText.Size = new System.Drawing.Size(306, 38);
            AboutText.TabIndex = 0;
            AboutText.Text = "Notepad-- is an free open-source notepad \r\napplication based on notepad++ (WIP)\r\n";
            // 
            // About
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(425, 450);
            ControlBox = false;
            Controls.Add(AboutArea);
            Controls.Add(APPLICENSES);
            Controls.Add(NotepadMinusMinusGithub);
            Controls.Add(APPVersion);
            Controls.Add(APPName);
            Controls.Add(APPImage);
            Controls.Add(OKButton);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "About";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)APPImage).EndInit();
            AboutArea.ResumeLayout(false);
            AboutArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.PictureBox APPImage;
        private System.Windows.Forms.Label APPName;
        private System.Windows.Forms.Label APPVersion;
        private System.Windows.Forms.LinkLabel NotepadMinusMinusGithub;
        private System.Windows.Forms.LinkLabel APPLICENSES;
        private System.Windows.Forms.GroupBox AboutArea;
        private System.Windows.Forms.Label AboutText;
    }
}