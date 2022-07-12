using System;

using System.Windows.Forms;
using Impresoras.Data;
using Impresoras.Models;

namespace Impresoras.Views
{
    public partial class frmPrint : Form
    {
        mdImpresora mdPrint;
        dtImpresora dtImpresora;
        public frmPrint()
        {
            InitializeComponent();
            mdPrint = new mdImpresora();
            dtImpresora = new dtImpresora();
            mdPrint.llenargridAll(dtgvPrints);
        }

        private void lblMsnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void gTxtBuscarODP_TextChanged(object sender, EventArgs e)
        {
            if (gTxtBuscarPrint.Text != "")
                mdPrint.cargaGridBuscador(dtgvPrints, gTxtBuscarPrint.Text);
            else
                mdPrint.llenargridAll(dtgvPrints);
        }
    }
}
