namespace Övning_1
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
            this.btnKor = new System.Windows.Forms.Button();
            this.lblTal1 = new System.Windows.Forms.Label();
            this.lblTal2 = new System.Windows.Forms.Label();
            this.lblSumma = new System.Windows.Forms.Label();
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKor
            // 
            this.btnKor.Location = new System.Drawing.Point(118, 164);
            this.btnKor.Name = "btnKor";
            this.btnKor.Size = new System.Drawing.Size(75, 23);
            this.btnKor.TabIndex = 0;
            this.btnKor.Text = "Kör";
            this.btnKor.UseVisualStyleBackColor = true;
            this.btnKor.Click += new System.EventHandler(this.btnKlick_Click);
            // 
            // lblTal1
            // 
            this.lblTal1.AutoSize = true;
            this.lblTal1.Location = new System.Drawing.Point(26, 26);
            this.lblTal1.Name = "lblTal1";
            this.lblTal1.Size = new System.Drawing.Size(30, 15);
            this.lblTal1.TabIndex = 1;
            this.lblTal1.Text = "Tal 1";
            // 
            // lblTal2
            // 
            this.lblTal2.AutoSize = true;
            this.lblTal2.Location = new System.Drawing.Point(26, 80);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(30, 15);
            this.lblTal2.TabIndex = 2;
            this.lblTal2.Text = "Tal 2";
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(26, 129);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(51, 15);
            this.lblSumma.TabIndex = 3;
            this.lblSumma.Text = "Summa:";
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(118, 23);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 23);
            this.tbxTal1.TabIndex = 4;
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(118, 77);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 23);
            this.tbxTal2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 223);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.lblTal1);
            this.Controls.Add(this.btnKor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Övning 1 Räkna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnKor;
        private Label lblTal1;
        private Label lblTal2;
        private Label lblSumma;
        private TextBox tbxTal1;
        private TextBox tbxTal2;
    }
}