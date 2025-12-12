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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void latihan1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Contoh: Soal Nomor 1 adalah Form Kasir
            Login form1 = new Login();
            form1.ShowDialog();
        }

        private void latihan2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Contoh: Soal Nomor 2 adalah Form Kasir
            Kalkulator form2 = new Kalkulator();
            form2.ShowDialog();
        }

        private void latihan3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Contoh: Soal Nomor 3 adalah Form Kasir
            Validasi form3 = new Validasi();
            form3.ShowDialog();
        }

        private void latihan4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Contoh: Soal Nomor 4 adalah Form Kasir
            Kasir form4 = new Kasir();
            form4.ShowDialog();
        }

        private void latihan5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Contoh: Soal Nomor 5 adalah Form Kasir
            Suhu form5 = new Suhu();
            form5.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Nama : Kirana Larasati Dewi\nNIM : 202404009",
                "Tentang Aplikasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
