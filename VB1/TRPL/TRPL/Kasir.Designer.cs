
namespace TRPL
{
    partial class Kasir
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
            this.TXTHarga = new System.Windows.Forms.TextBox();
            this.TXTJumlah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNHitung = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LBSubtotal = new System.Windows.Forms.Label();
            this.LBDiskon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBTotalAkhir = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harga Barang";
            // 
            // TXTHarga
            // 
            this.TXTHarga.Location = new System.Drawing.Point(160, 44);
            this.TXTHarga.Name = "TXTHarga";
            this.TXTHarga.Size = new System.Drawing.Size(100, 20);
            this.TXTHarga.TabIndex = 1;
            // 
            // TXTJumlah
            // 
            this.TXTJumlah.Location = new System.Drawing.Point(160, 90);
            this.TXTJumlah.Name = "TXTJumlah";
            this.TXTJumlah.Size = new System.Drawing.Size(100, 20);
            this.TXTJumlah.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jumlah Beli";
            // 
            // BTNHitung
            // 
            this.BTNHitung.BackColor = System.Drawing.Color.PeachPuff;
            this.BTNHitung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHitung.Location = new System.Drawing.Point(52, 144);
            this.BTNHitung.Name = "BTNHitung";
            this.BTNHitung.Size = new System.Drawing.Size(248, 41);
            this.BTNHitung.TabIndex = 5;
            this.BTNHitung.Text = "Hitung";
            this.BTNHitung.UseVisualStyleBackColor = false;
            this.BTNHitung.Click += new System.EventHandler(this.BTNHitung_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subtotal";
            // 
            // LBSubtotal
            // 
            this.LBSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LBSubtotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSubtotal.Location = new System.Drawing.Point(190, 215);
            this.LBSubtotal.Name = "LBSubtotal";
            this.LBSubtotal.Size = new System.Drawing.Size(70, 25);
            this.LBSubtotal.TabIndex = 7;
            this.LBSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBDiskon
            // 
            this.LBDiskon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LBDiskon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDiskon.Location = new System.Drawing.Point(190, 260);
            this.LBDiskon.Name = "LBDiskon";
            this.LBDiskon.Size = new System.Drawing.Size(70, 26);
            this.LBDiskon.TabIndex = 9;
            this.LBDiskon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Diskon (10%)";
            // 
            // LBTotalAkhir
            // 
            this.LBTotalAkhir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LBTotalAkhir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTotalAkhir.Location = new System.Drawing.Point(190, 300);
            this.LBTotalAkhir.Name = "LBTotalAkhir";
            this.LBTotalAkhir.Size = new System.Drawing.Size(70, 25);
            this.LBTotalAkhir.TabIndex = 11;
            this.LBTotalAkhir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Akhir";
            // 
            // Kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(347, 370);
            this.Controls.Add(this.LBTotalAkhir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBDiskon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNHitung);
            this.Controls.Add(this.TXTJumlah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTHarga);
            this.Controls.Add(this.label1);
            this.Name = "Kasir";
            this.Text = "Kasir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTHarga;
        private System.Windows.Forms.TextBox TXTJumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNHitung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBSubtotal;
        private System.Windows.Forms.Label LBDiskon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBTotalAkhir;
        private System.Windows.Forms.Label label8;
    }
}