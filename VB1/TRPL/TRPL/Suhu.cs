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
    public partial class Suhu : Form
    {
        public Suhu()
        {
            InitializeComponent();
        }

        private void TXTCelcius_TextChanged(object sender, EventArgs e)
        {
            if (TXTCelcius.Text.Trim() == "")
            {
                LBFahrenheit.Text = "-";
                LBKelvin.Text = "-";
                return;
            }

            double c;

            if (!double.TryParse(TXTCelcius.Text, out c))
            {
                LBFahrenheit.Text = "-";
                LBKelvin.Text = "-";
                return;
            }

            double f = (c * 9.0 / 5.0) + 32;
            double k = c + 273.0;

            LBFahrenheit.Text = f.ToString("N2");
            LBKelvin.Text = k.ToString("N2");
        }
    }
 }
