namespace WindowsFormsApp3
{
    partial class Form1
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
            this.label1Kalimat = new System.Windows.Forms.Label();
            this.textBox1Kalimat = new System.Windows.Forms.TextBox();
            this.label2Huruf = new System.Windows.Forms.Label();
            this.textBox2Huruf = new System.Windows.Forms.TextBox();
            this.label3Jadi = new System.Windows.Forms.Label();
            this.textBox3Jadi = new System.Windows.Forms.TextBox();
            this.button1Konversi = new System.Windows.Forms.Button();
            this.label4Hasil = new System.Windows.Forms.Label();
            this.label5Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1Kalimat
            // 
            this.label1Kalimat.AutoSize = true;
            this.label1Kalimat.Location = new System.Drawing.Point(12, 26);
            this.label1Kalimat.Name = "label1Kalimat";
            this.label1Kalimat.Size = new System.Drawing.Size(94, 13);
            this.label1Kalimat.TabIndex = 0;
            this.label1Kalimat.Text = "Masukkan Kalimat";
            // 
            // textBox1Kalimat
            // 
            this.textBox1Kalimat.Location = new System.Drawing.Point(112, 23);
            this.textBox1Kalimat.Name = "textBox1Kalimat";
            this.textBox1Kalimat.Size = new System.Drawing.Size(222, 20);
            this.textBox1Kalimat.TabIndex = 1;
            // 
            // label2Huruf
            // 
            this.label2Huruf.AutoSize = true;
            this.label2Huruf.Location = new System.Drawing.Point(12, 63);
            this.label2Huruf.Name = "label2Huruf";
            this.label2Huruf.Size = new System.Drawing.Size(86, 13);
            this.label2Huruf.TabIndex = 2;
            this.label2Huruf.Text = "Masukkan Huruf";
            // 
            // textBox2Huruf
            // 
            this.textBox2Huruf.Location = new System.Drawing.Point(112, 60);
            this.textBox2Huruf.MaxLength = 1;
            this.textBox2Huruf.Name = "textBox2Huruf";
            this.textBox2Huruf.Size = new System.Drawing.Size(58, 20);
            this.textBox2Huruf.TabIndex = 3;
            // 
            // label3Jadi
            // 
            this.label3Jadi.AutoSize = true;
            this.label3Jadi.Location = new System.Drawing.Point(219, 63);
            this.label3Jadi.Name = "label3Jadi";
            this.label3Jadi.Size = new System.Drawing.Size(44, 13);
            this.label3Jadi.TabIndex = 4;
            this.label3Jadi.Text = "Menjadi";
            // 
            // textBox3Jadi
            // 
            this.textBox3Jadi.Location = new System.Drawing.Point(269, 60);
            this.textBox3Jadi.MaxLength = 1;
            this.textBox3Jadi.Name = "textBox3Jadi";
            this.textBox3Jadi.Size = new System.Drawing.Size(65, 20);
            this.textBox3Jadi.TabIndex = 5;
            // 
            // button1Konversi
            // 
            this.button1Konversi.Location = new System.Drawing.Point(112, 97);
            this.button1Konversi.Name = "button1Konversi";
            this.button1Konversi.Size = new System.Drawing.Size(222, 23);
            this.button1Konversi.TabIndex = 6;
            this.button1Konversi.Text = "Konversi!";
            this.button1Konversi.UseVisualStyleBackColor = true;
            this.button1Konversi.Click += new System.EventHandler(this.button1Konversi_Click);
            // 
            // label4Hasil
            // 
            this.label4Hasil.AutoSize = true;
            this.label4Hasil.Location = new System.Drawing.Point(12, 150);
            this.label4Hasil.Name = "label4Hasil";
            this.label4Hasil.Size = new System.Drawing.Size(36, 13);
            this.label4Hasil.TabIndex = 7;
            this.label4Hasil.Text = "Hasil :";
            // 
            // label5Output
            // 
            this.label5Output.AutoSize = true;
            this.label5Output.Location = new System.Drawing.Point(109, 150);
            this.label5Output.Name = "label5Output";
            this.label5Output.Size = new System.Drawing.Size(13, 13);
            this.label5Output.TabIndex = 8;
            this.label5Output.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 181);
            this.Controls.Add(this.label5Output);
            this.Controls.Add(this.label4Hasil);
            this.Controls.Add(this.button1Konversi);
            this.Controls.Add(this.textBox3Jadi);
            this.Controls.Add(this.label3Jadi);
            this.Controls.Add(this.textBox2Huruf);
            this.Controls.Add(this.label2Huruf);
            this.Controls.Add(this.textBox1Kalimat);
            this.Controls.Add(this.label1Kalimat);
            this.Name = "Form1";
            this.Text = "QUIZ PANDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Kalimat;
        private System.Windows.Forms.TextBox textBox1Kalimat;
        private System.Windows.Forms.Label label2Huruf;
        private System.Windows.Forms.TextBox textBox2Huruf;
        private System.Windows.Forms.Label label3Jadi;
        private System.Windows.Forms.TextBox textBox3Jadi;
        private System.Windows.Forms.Button button1Konversi;
        private System.Windows.Forms.Label label4Hasil;
        private System.Windows.Forms.Label label5Output;
    }
}

