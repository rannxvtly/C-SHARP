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
    public partial class Validasi : Form
    {
        public Validasi()
        {
            InitializeComponent();
        }

        private void BTNSimpan_Click(object sender, EventArgs e)
        {
            if (CMBJabatan.Text.Length == 0)
            {
                MessageBox.Show("Jabatannya isi dulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (RBMenikah.Checked == false && RBBLMMenikah.Checked == false)
            {
                MessageBox.Show("Pilih status pernikahan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (RBMenikah.Checked)
                {
                    MessageBox.Show(
                        "Status Perkawinan\t: Menikah\n" +
                        "Jabatan\t\t: " + CMBJabatan.Text + "\n" +
                        "Tanggal Lahir\t: " +
                        DTPTanggalLahir.Value.Day.ToString("00") + "-" +
                        DTPTanggalLahir.Value.Month.ToString("00") + "-" +
                        DTPTanggalLahir.Value.Year.ToString()
                    );
                }

                else if (RBBLMMenikah.Checked)
                {
                    MessageBox.Show(
                        "Status Perkawinan\t: Belum Menikah\n" +
                        "Jabatan\t\t: " + CMBJabatan.Text,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }
    }
}