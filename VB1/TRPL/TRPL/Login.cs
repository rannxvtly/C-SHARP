using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            if ((TXTPassword.Text.Length == 0) || (TXTPassword.Text.Length == 0))
            {
                MessageBox.Show("Please enter both Username and Password. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if ((TXTPassword.Text.Equals("User")) && (TXTPassword.Text.Equals("User") && TXTPassword.Text.Equals("123")))
                {
                    MessageBox.Show("Succes Login. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Password dan Username anda salah. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
        }

        private void CBSP_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSP.Checked)
            {
                TXTPassword.PasswordChar= '\0';
            }
            else
            {
                TXTPassword.PasswordChar = '*';
            }
        }
    }
}