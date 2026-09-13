namespace StudentProfile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(271, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Profile — GitHub Beginner Lab.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 98);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 1;
            label2.Text = "Contact Number: 09171234567";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 149);
            label3.Name = "label3";
            label3.Size = new Size(262, 20);
            label3.TabIndex = 2;
            label3.Text = "Email Address: student@example.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 204);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "Year Level: 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
