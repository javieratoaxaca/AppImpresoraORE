using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impresoras.Views
{
    public partial class frmPrintUp : Form
    {
        public frmPrintUp()
        {
            InitializeComponent();
            txtCajasDesActivadas();
            btnDesActivados();
        }

        private void lblMsnDashboard_Click(object sender, EventArgs e)
        {

        }

        #region Metodos

        //Desactivacion de Botones
        private void txtCajasDesActivadas()
        {
            gTxtSerieEquipo.Enabled = false;
            gTxtNomEquipo.Enabled = false;
            gTxtNoEquipo.Enabled = false;
            gTxtModeloEquipo.Enabled = false;
            gTxtMarcaEquipo.Enabled = false;

        }

        private void btnDesActivados()
        {
            gBtnEditarDispositivo.Enabled = false;
            
            gBtnQrDispositivo.Enabled = false;
            gBtnEliminarDispositivo.Enabled = false;
            gBtnGuardarDispositivo.Enabled = false;
            gBtnGuardarDispositivo.Visible = false;
        }
        private void btnActivados()
        {
            gBtnEditarDispositivo.Enabled = true;
            gBtnGuardarDispositivo.Enabled = true;
            gBtnGuardarDispositivo.Visible = true;
            gBtnQrDispositivo.Enabled = true;
            gBtnEliminarDispositivo.Enabled = true;
            gBtnRegistrarDispositivo.Enabled = false;
            gBtnRegistrarDispositivo.Visible = false;
        }

        private void txtCajasActivadas()
        {
            gTxtSerieEquipo.Enabled = true;
            gTxtNomEquipo.Enabled = true;
            gTxtNoEquipo.Enabled = true;
            gTxtModeloEquipo.Enabled = true;
            gTxtMarcaEquipo.Enabled = true;
        }


        #endregion

        private void gBtnRegistrarDispositivo_Click(object sender, EventArgs e)
        {
            txtCajasActivadas();
            btnActivados();
        }
    }
}
