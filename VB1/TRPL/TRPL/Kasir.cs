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
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
        }

        private void BTNHitung_Click(object sender, EventArgs e)
        {
            try
            {
                double harga = double.Parse(TXTHarga.Text);
                double jumlah = double.Parse(TXTJumlah.Text);

                double subtotal = harga * jumlah;

                double diskon = 0;
                if (subtotal > 100000)
                {
                    diskon = subtotal * 0.10;
                }

                double totalAkhir = subtotal - diskon;

                LBSubtotal.Text = subtotal.ToString("");
                LBDiskon.Text = diskon.ToString("");
                LBTotalAkhir.Text = totalAkhir.ToString("");
            }
            catch
            {
                MessageBox.Show(
                    "Input harus angka! Tidak boleh huruf.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
