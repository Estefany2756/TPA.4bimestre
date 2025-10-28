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
    public partial class frmtabuada3 : Form
    {
        public frmtabuada3()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Int32 I = 1, num, result;

            num = Convert.ToInt32(txtnum.Text);

            for (I = 1; I <=10; I++)
            {
                result = num * I;
                txtresult.Text += num + "x" + I + "=" + result + "\n";
              
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
            txtresult.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
