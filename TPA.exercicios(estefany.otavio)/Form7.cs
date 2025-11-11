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
    public partial class frmarea1 : Form
    {
        public frmarea1()
        {
            InitializeComponent();
        }

        double areatotal = 0.0, larg = 0.0, comp = 0.0, areacmd = 0.0;

        private void btnlimpar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        DialogResult resultado = DialogResult.Yes;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            larg = Convert.ToDouble(txtlarg.Text);
            comp = Convert.ToDouble(txtcomp.Text);
            areacmd = larg * comp;
            areatotal += areacmd;
            txtarea.Text = areacmd.ToString();

            resultado = MessageBox.Show("Deseja adicionar outro cômodo?", "Continuar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                txtarea.Clear();
                txtcomp.Clear();
                txtlarg.Clear();
                txtlarg.Focus();

            }
            else if (resultado == DialogResult.No)
            {

                txttotal.Text = areatotal.ToString();
                {
                }
            }
        }
    }
}







   