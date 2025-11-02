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

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //CÓDIGO NÃO FINALIZADO!
            Int32 I = 1, cmd;
            double comp, larg, area, total = 0;

            cmd = Convert.ToInt32(txtcmd.Text);

            while (I <= cmd)
            {
                comp = Convert.ToDouble(txtcomp.Text);
                larg = Convert.ToDouble(txtlarg.Text);

                area = larg * comp;
                total += total + area;


                txtarea.Text = area + "m² \n";
                I++;
                //area = Convert.ToDouble(txtarea.Text);
            }
            txttotal.Text = total + "m²";
        }
    }
}
