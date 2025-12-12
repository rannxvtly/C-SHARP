
namespace TRPL
{
    partial class Kalkulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXTAngkaPertama = new System.Windows.Forms.TextBox();
            this.TXTAngkaKedua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNTambah = new System.Windows.Forms.Button();
            this.LBHaasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka Pertama";
            // 
            // TXTAngkaPertama
            // 
            this.TXTAngkaPertama.Location = new System.Drawing.Point(127, 55);
            this.TXTAngkaPertama.Multiline = true;
            this.TXTAngkaPertama.Name = "TXTAngkaPertama";
            this.TXTAngkaPertama.Size = new System.Drawing.Size(100, 20);
            this.TXTAngkaPertama.TabIndex = 1;
            this.TXTAngkaPertama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTAngkaPertama_KeyPress);
            // 
            // TXTAngkaKedua
            // 
            this.TXTAngkaKedua.Location = new System.Drawing.Point(127, 107);
            this.TXTAngkaKedua.Multiline = true;
            this.TXTAngkaKedua.Name = "TXTAngkaKedua";
            this.TXTAngkaKedua.Size = new System.Drawing.Size(100, 20);
            this.TXTAngkaKedua.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angka Kedua";
            // 
            // BTNTambah
            // 
            this.BTNTambah.BackColor = System.Drawing.Color.Salmon;
            this.BTNTambah.Location = new System.Drawing.Point(44, 188);
            this.BTNTambah.Name = "BTNTambah";
            this.BTNTambah.Size = new System.Drawing.Size(101, 39);
            this.BTNTambah.TabIndex = 4;
            this.BTNTambah.Text = "TAMBAH";
            this.BTNTambah.UseVisualStyleBackColor = false;
            this.BTNTambah.Click += new System.EventHandler(this.BTNTambah_Click);
            // 
            // LBHaasil
            // 
            this.LBHaasil.AutoSize = true;
            this.LBHaasil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBHaasil.Location = new System.Drawing.Point(123, 151);
            this.LBHaasil.Name = "LBHaasil";
            this.LBHaasil.Size = new System.Drawing.Size(47, 19);
            this.LBHaasil.TabIndex = 5;
            this.LBHaasil.Text = "Hasil";
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(389, 288);
            this.Controls.Add(this.LBHaasil);
            this.Controls.Add(this.BTNTambah);
            this.Controls.Add(this.TXTAngkaKedua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTAngkaPertama);
            this.Controls.Add(this.label1);
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTAngkaPertama;
        private System.Windows.Forms.TextBox TXTAngkaKedua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNTambah;
        private System.Windows.Forms.Label LBHaasil;
    }
}