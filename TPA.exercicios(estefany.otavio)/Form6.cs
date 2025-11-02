using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPA.exercicios_estefany.otavio_
{
    public partial class frmgraus2 : Form
    {
        public frmgraus2()
        {
            InitializeComponent();
        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            Int32 I = 1;
            double Cel = 0, Fah;

            do
            {
                Cel = Cel + 10;
                Fah = (Cel * 1.8) + 32;
                txtgraus.Text += Cel + "° = " + Fah + "\n";
                I++;
            }

            while (I <= 10);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtgraus.Clear();

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void lblgraus_Click(object sender, EventArgs e)
        {

        }

        private void txtgraus_TextChanged(object sender, EventArgs e)
        {

        }
    }
   }

