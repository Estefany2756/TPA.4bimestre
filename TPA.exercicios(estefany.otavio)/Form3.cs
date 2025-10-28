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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void tsmitabuada1_Click(object sender, EventArgs e)
        {
            Hide();
            frmtabuada1 tab1 = new frmtabuada1();
            tab1.Show();
        }

        private void tsmitabuada2_Click(object sender, EventArgs e)
        {
            Hide();
            frmtabuada2 tab2 = new frmtabuada2();
            tab2.Show();
        }

        private void tsmisair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmitabuada3_Click(object sender, EventArgs e)
        {
            Hide();
            frmtabuada3 tab3 = new frmtabuada3();
            tab3.Show();
        }
    }
}
