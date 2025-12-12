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
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void BTNTambah_Click(object sender, EventArgs e)
        {
            int Angka1 = Convert.ToInt32(TXTAngkaPertama.Text);
            int Angka2 = Convert.ToInt32(TXTAngkaKedua.Text);
            int Hasil = Angka1 + Angka2;

            LBHaasil.Text = Hasil.ToString();
        }

        private void TXTAngkaPertama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() != "\b")
            {
                if (!char.IsDigit(e.KeyChar))

                {
                    e.Handled = true;
                }
            }
        }
    }
}
