
namespace TRPL
{
    partial class Login
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
            this.BTNLOGIN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTPassword = new System.Windows.Forms.TextBox();
            this.CBSP = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNLOGIN
            // 
            this.BTNLOGIN.BackColor = System.Drawing.Color.RosyBrown;
            this.BTNLOGIN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLOGIN.Location = new System.Drawing.Point(69, 240);
            this.BTNLOGIN.Name = "BTNLOGIN";
            this.BTNLOGIN.Size = new System.Drawing.Size(102, 39);
            this.BTNLOGIN.TabIndex = 0;
            this.BTNLOGIN.Text = "Click";
            this.BTNLOGIN.UseVisualStyleBackColor = false;
            this.BTNLOGIN.Click += new System.EventHandler(this.BTNLOGIN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Salmon;
            this.groupBox1.Controls.Add(this.CBSP);
            this.groupBox1.Controls.Add(this.TXTUsername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXTPassword);
            this.groupBox1.Controls.Add(this.BTNLOGIN);
            this.groupBox1.Location = new System.Drawing.Point(52, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 329);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // TXTUsername
            // 
            this.TXTUsername.Location = new System.Drawing.Point(68, 77);
            this.TXTUsername.Multiline = true;
            this.TXTUsername.Name = "TXTUsername";
            this.TXTUsername.Size = new System.Drawing.Size(189, 20);
            this.TXTUsername.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // TXTPassword
            // 
            this.TXTPassword.Location = new System.Drawing.Point(68, 146);
            this.TXTPassword.Multiline = true;
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PasswordChar = '*';
            this.TXTPassword.Size = new System.Drawing.Size(189, 20);
            this.TXTPassword.TabIndex = 10;
            // 
            // CBSP
            // 
            this.CBSP.AutoSize = true;
            this.CBSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBSP.Location = new System.Drawing.Point(69, 172);
            this.CBSP.Name = "CBSP";
            this.CBSP.Size = new System.Drawing.Size(102, 17);
            this.CBSP.TabIndex = 12;
            this.CBSP.Text = "Show Password";
            this.CBSP.UseVisualStyleBackColor = false;
            this.CBSP.CheckedChanged += new System.EventHandler(this.CBSP_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 392);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNLOGIN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXTUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTPassword;
        private System.Windows.Forms.CheckBox CBSP;
    }
}

