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
    public partial class frmtabuada1 : Form
    {
        public frmtabuada1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Int32 result, I = 1, num;
            num = Convert.ToInt32(txtnum.Text);

            while (I <= 10)
            {
                result = num * I;
                txtresult.Text += num + "x" + I + "=" + result + "\n";
                I++;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
