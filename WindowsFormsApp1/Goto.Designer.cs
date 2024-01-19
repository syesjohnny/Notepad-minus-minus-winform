namespace WindowsFormsApp1
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
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            buttongo = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(38, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 19);
            label1.TabIndex = 0;
            label1.Text = "Goto:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(38, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(408, 27);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += intonlyinput;
            // 
            // buttongo
            // 
            buttongo.Location = new System.Drawing.Point(88, 131);
            buttongo.Name = "buttongo";
            buttongo.Size = new System.Drawing.Size(94, 29);
            buttongo.TabIndex = 2;
            buttongo.Text = "Go";
            buttongo.UseVisualStyleBackColor = true;
            buttongo.Click += buttongo_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(294, 131);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(131, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(55, 23);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "line";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(209, 35);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(55, 23);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "pos";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // Goto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(485, 188);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(buttongo);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Goto";
            Text = "Goto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button buttongo;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
    }
}