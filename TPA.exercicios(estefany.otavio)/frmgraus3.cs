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
    public partial class frmgraus3 : Form
    {
        public frmgraus3()
        {
            InitializeComponent();
        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            Int32 I = 0;
            double Cel = 0, Fah;

            for (I=1; I <= 10; I++)
            {
                Cel = Cel + 10;
                Fah = (Cel * 1.8) + 32;
                txtgraus.Text += Cel + "° = " + Fah + "\n";
            }
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
    }
}
