namespace NotePadMinusMinus
{
    partial class inserttag
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
            opening = new System.Windows.Forms.Label();
            open = new System.Windows.Forms.TextBox();
            ok = new System.Windows.Forms.Button();
            cancel = new System.Windows.Forms.Button();
            closing = new System.Windows.Forms.Label();
            ClosingTag = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // opening
            // 
            opening.AutoSize = true;
            opening.Location = new System.Drawing.Point(31, 35);
            opening.Name = "opening";
            opening.Size = new System.Drawing.Size(100, 19);
            opening.TabIndex = 0;
            opening.Text = "Opening Tag";
            // 
            // open
            // 
            open.Location = new System.Drawing.Point(31, 57);
            open.Name = "open";
            open.Size = new System.Drawing.Size(242, 27);
            open.TabIndex = 1;
            open.Text = "<tag>";
            open.TextChanged += open_TextChanged;
            // 
            // ok
            // 
            ok.Location = new System.Drawing.Point(316, 55);
            ok.Name = "ok";
            ok.Size = new System.Drawing.Size(94, 29);
            ok.TabIndex = 2;
            ok.Text = "OK";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // cancel
            // 
            cancel.Location = new System.Drawing.Point(316, 133);
            cancel.Name = "cancel";
            cancel.Size = new System.Drawing.Size(94, 29);
            cancel.TabIndex = 3;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // closing
            // 
            closing.AutoSize = true;
            closing.Location = new System.Drawing.Point(31, 104);
            closing.Name = "closing";
            closing.Size = new System.Drawing.Size(164, 19);
            closing.TabIndex = 4;
            closing.Text = "Closing Tag (Can Edit)";
            // 
            // ClosingTag
            // 
            ClosingTag.Location = new System.Drawing.Point(31, 135);
            ClosingTag.Name = "ClosingTag";
            ClosingTag.Size = new System.Drawing.Size(242, 27);
            ClosingTag.TabIndex = 5;
            ClosingTag.Text = "</tag>";
            // 
            // inserttag
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(437, 201);
            Controls.Add(ClosingTag);
            Controls.Add(closing);
            Controls.Add(cancel);
            Controls.Add(ok);
            Controls.Add(open);
            Controls.Add(opening);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "inserttag";
            Text = "Insert HTML/XML Tag";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label opening;
        private System.Windows.Forms.TextBox open;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label closing;
        private System.Windows.Forms.TextBox ClosingTag;
    }
}