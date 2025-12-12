
namespace TRPL
{
    partial class Validasi
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
            this.CMBJabatan = new System.Windows.Forms.ComboBox();
            this.BTNSimpan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RBMenikah = new System.Windows.Forms.RadioButton();
            this.RBBLMMenikah = new System.Windows.Forms.RadioButton();
            this.DTPTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jabatan";
            // 
            // CMBJabatan
            // 
            this.CMBJabatan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBJabatan.FormattingEnabled = true;
            this.CMBJabatan.Items.AddRange(new object[] {
            "Manager",
            "Supervisor",
            "Staff",
            "Admin"});
            this.CMBJabatan.Location = new System.Drawing.Point(144, 49);
            this.CMBJabatan.Name = "CMBJabatan";
            this.CMBJabatan.Size = new System.Drawing.Size(134, 22);
            this.CMBJabatan.TabIndex = 1;
            // 
            // BTNSimpan
            // 
            this.BTNSimpan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSimpan.Location = new System.Drawing.Point(51, 253);
            this.BTNSimpan.Name = "BTNSimpan";
            this.BTNSimpan.Size = new System.Drawing.Size(88, 31);
            this.BTNSimpan.TabIndex = 2;
            this.BTNSimpan.Text = "SIMPAN";
            this.BTNSimpan.UseVisualStyleBackColor = true;
            this.BTNSimpan.Click += new System.EventHandler(this.BTNSimpan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // RBMenikah
            // 
            this.RBMenikah.AutoSize = true;
            this.RBMenikah.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMenikah.Location = new System.Drawing.Point(144, 96);
            this.RBMenikah.Name = "RBMenikah";
            this.RBMenikah.Size = new System.Drawing.Size(72, 18);
            this.RBMenikah.TabIndex = 4;
            this.RBMenikah.TabStop = true;
            this.RBMenikah.Text = "Menikah";
            this.RBMenikah.UseVisualStyleBackColor = true;
            // 
            // RBBLMMenikah
            // 
            this.RBBLMMenikah.AutoSize = true;
            this.RBBLMMenikah.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBBLMMenikah.Location = new System.Drawing.Point(144, 131);
            this.RBBLMMenikah.Name = "RBBLMMenikah";
            this.RBBLMMenikah.Size = new System.Drawing.Size(110, 18);
            this.RBBLMMenikah.TabIndex = 5;
            this.RBBLMMenikah.TabStop = true;
            this.RBBLMMenikah.Text = "Belum Menikah";
            this.RBBLMMenikah.UseVisualStyleBackColor = true;
            // 
            // DTPTanggalLahir
            // 
            this.DTPTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTanggalLahir.Location = new System.Drawing.Point(151, 186);
            this.DTPTanggalLahir.Name = "DTPTanggalLahir";
            this.DTPTanggalLahir.Size = new System.Drawing.Size(127, 20);
            this.DTPTanggalLahir.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tanggal Lahir";
            // 
            // Validasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(375, 317);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPTanggalLahir);
            this.Controls.Add(this.RBBLMMenikah);
            this.Controls.Add(this.RBMenikah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNSimpan);
            this.Controls.Add(this.CMBJabatan);
            this.Controls.Add(this.label1);
            this.Name = "Validasi";
            this.Text = "Validasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBJabatan;
        private System.Windows.Forms.Button BTNSimpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBMenikah;
        private System.Windows.Forms.RadioButton RBBLMMenikah;
        private System.Windows.Forms.DateTimePicker DTPTanggalLahir;
        private System.Windows.Forms.Label label3;
    }
}