namespace övning___text_och_tecken
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
            this.labelNam1 = new System.Windows.Forms.Label();
            this.labelNam2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelInitials = new System.Windows.Forms.Label();
            this.btnKor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNam1
            // 
            this.labelNam1.AutoSize = true;
            this.labelNam1.Location = new System.Drawing.Point(87, 74);
            this.labelNam1.Name = "labelNam1";
            this.labelNam1.Size = new System.Drawing.Size(55, 15);
            this.labelNam1.TabIndex = 0;
            this.labelNam1.Text = "Förnamn";
            // 
            // labelNam2
            // 
            this.labelNam2.AutoSize = true;
            this.labelNam2.Location = new System.Drawing.Point(87, 131);
            this.labelNam2.Name = "labelNam2";
            this.labelNam2.Size = new System.Drawing.Size(62, 15);
            this.labelNam2.TabIndex = 1;
            this.labelNam2.Text = "Efternamn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // labelInitials
            // 
            this.labelInitials.AutoSize = true;
            this.labelInitials.Location = new System.Drawing.Point(149, 185);
            this.labelInitials.Name = "labelInitials";
            this.labelInitials.Size = new System.Drawing.Size(0, 15);
            this.labelInitials.TabIndex = 4;
            // 
            // btnKor
            // 
            this.btnKor.Location = new System.Drawing.Point(207, 230);
            this.btnKor.Name = "btnKor";
            this.btnKor.Size = new System.Drawing.Size(75, 23);
            this.btnKor.TabIndex = 5;
            this.btnKor.Text = "Kör";
            this.btnKor.UseVisualStyleBackColor = true;
            this.btnKor.Click += new System.EventHandler(this.btnKor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 316);
            this.Controls.Add(this.btnKor);
            this.Controls.Add(this.labelInitials);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNam2);
            this.Controls.Add(this.labelNam1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNam1;
        private Label labelNam2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelInitials;
        private Button btnKor;
    }
}