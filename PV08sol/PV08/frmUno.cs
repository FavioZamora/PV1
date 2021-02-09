using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV08
{
    public partial class frmUno : Form
    {
        public frmUno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDos frmDos = new frmDos();
            frmDos.Show();
        }

        private void btnLlamaraformaTres_Click(object sender, EventArgs e)
        {
            frmTres frmTres = new frmTres();
            frmTres.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmUno frmUno = new frmUno();
            this.Close();
        }
    }
}
