using System;
using System.Windows.Forms;
using Impresoras.Data;
using Impresoras.Models;

namespace Impresoras.Views
{
    public partial class frmRegion : Form
    {
        mdRegion mdlRegion;
        dtRegion dtRegiones;
        public frmRegion()
        {
            InitializeComponent();
            mdlRegion = new mdRegion();
            dtRegiones=new dtRegion();
            txtCajasDesactivadas();
            btnDesactivados();
         
        }

        #region Cajas
        //Metodos para las cajas de texto
        private void txtCajasDesactivadas()
        {
            gTxtCupo.Enabled = false;
            gTxtCveInegi.Enabled = false;
            gTxtCveLoc.Enabled = false;
            gTxtCveMun.Enabled = false;
            gTxtDomicilioSare.Enabled = false;
            gTxtEmailSare.Enabled = false;
            gTxtHorario.Enabled = false;
            gTxtIdSare.Enabled = false;
            gTxtJefeSare.Enabled = false;
            gTxtLatitud.Enabled = false;
            gTxtLocalidad.Enabled = false;
            gTxtLongitud.Enabled = false;
            gTxtMunicipio.Enabled = false;
            gTxtNameSare.Enabled = false;
            gTxtTelefono.Enabled = false;

        }
        private void txtCajasActivadas()
        {
            gTxtCupo.Enabled = true;
            gTxtCveInegi.Enabled = true;
            gTxtCveLoc.Enabled = true;
            gTxtCveMun.Enabled = true;
            gTxtDomicilioSare.Enabled = true;
            gTxtEmailSare.Enabled = true;
            gTxtHorario.Enabled = true;
            gTxtIdSare.Enabled = true;
            gTxtJefeSare.Enabled = true;
            gTxtLatitud.Enabled = true;
            gTxtLocalidad.Enabled = true;
            gTxtLongitud.Enabled = true;
            gTxtMunicipio.Enabled = true;
            gTxtNameSare.Enabled = true;
            gTxtTelefono.Enabled = true;

        }

        public void CajasTxtLimpias()
        {
            gTxtCupo.Text = "";
            gTxtCveInegi.Text = "";
            gTxtCveLoc.Text = "";
            gTxtCveMun.Text = "";
            gTxtDomicilioSare.Text = "";
            gTxtEmailSare.Text = "";
            gTxtHorario.Text = "";
            gTxtIdSare.Text = "";
            gTxtJefeSare.Text = "";
            gTxtLatitud.Text = "";
            gTxtLocalidad.Text = "";
            gTxtLongitud.Text = "";
            gTxtMunicipio.Text = "";
            gTxtNameSare.Text = "";
            gTxtTelefono.Text = "";
        }
        #endregion

        #region Botones

       
        //Metodos para los Botones
        private void btnDesactivados()
        {
            gBtnRegistrarRegion.Enabled = true;
            gBtnGuardarRegion.Enabled = false;
            gBtnEliminarRegion.Enabled = false;
            gBtnEditarregion.Enabled = false;
        }
        private void btnActivados()
        {
            gBtnRegistrarRegion.Enabled = false;
            gBtnGuardarRegion.Enabled = true;
            gBtnEliminarRegion.Enabled = true;
            gBtnEditarregion.Enabled = true;
        }

        #endregion

        #region SaveRegion
        //Metodo que guarda los datos en la Tabla de Region de la BD
        private void saveRegion()
        {
            int idestado = 20;
            string edo = "Oaxaca";
            try
            {
                dtRegiones.IdEdo = idestado;
                dtRegiones.Estado = edo;
                dtRegiones.IdSare = Convert.ToInt32(gTxtIdSare.Text);
                dtRegiones.Sare = gTxtNameSare.Text;
                dtRegiones.CveOfiLocalidad = gTxtCveInegi.Text;
                dtRegiones.CveMun = gTxtCveMun.Text;
                dtRegiones.Municipio = gTxtMunicipio.Text;
                dtRegiones.CveLocalidad = gTxtCveLoc.Text;
                dtRegiones.Localidad = gTxtLocalidad.Text;
                dtRegiones.Cupo = Convert.ToInt32( gTxtCupo.Text);
                dtRegiones.JefeSare = gTxtJefeSare.Text;
                dtRegiones.Email = gTxtEmailSare.Text;
                dtRegiones.Domicilio = gTxtDomicilioSare.Text;
                dtRegiones.Horario = gTxtHorario.Text;
                dtRegiones.Telefono = gTxtTelefono.Text;
                dtRegiones.Latitud = gTxtLatitud.Text;
                dtRegiones.Longitud = gTxtLongitud.Text;

                if (gTxtIdSare.Text=="" || gTxtNameSare.Text=="" || gTxtCveInegi.Text=="" || gTxtCveMun.Text == "" || gTxtMunicipio.Text == "" || gTxtCveLoc.Text == "" || gTxtLocalidad.Text == "" || gTxtCupo.Text == "" || gTxtJefeSare.Text == "" || gTxtEmailSare.Text  == "" || gTxtHorario.Text == "" || gTxtTelefono.Text == "" || gTxtLatitud.Text == "" || gTxtLatitud.Text == "" || gTxtLongitud.Text == "" )
                {
                    MessageBox.Show("Debe Completar la información");
                    return;
                }
                else if (!mdlRegion.existeRegion(dtRegiones.IdSare))
                {
                    if (mdlRegion.insertRegiones(dtRegiones))
                    {
                        MessageBox.Show("Se Guardo Exitosamente");
                        mdlRegion.llenarGrid(dtgvRegiones);
                        // scInventario.llenargridInv(dtgvInventario);
                    }
                }
                else
                {
                    /*if (scProducto.UpdateProducto(dtImpresora))
                    {
                        MessageBox.Show("Se Actualizacion Exitosamente");
                        scProducto.llenargrid(dtgvProductos);
                        scInventario.llenargridInv(dtgvInventario);
                    }*/
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        private void gBtnGuardarRegion_Click(object sender, EventArgs e)
        {
            saveRegion();
            CajasTxtLimpias();
            txtCajasDesactivadas();
            btnDesactivados();
        }

        private void gBtnRegistrarRegion_Click(object sender, EventArgs e)
        {
            txtCajasActivadas();
            btnActivados();
        }
    }
}
