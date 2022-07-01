using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//libreria para Conexion
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using MySql.Data.Types;
using MySql.Data.MySqlClient;
using Impresoras.Data;
using Impresoras.Models;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing.Imaging;

namespace Impresoras.Views
{
    public partial class frmPrintUp : Form

    {
        mdImpresora mdPrint;
        
        public frmPrintUp()
        {
            mdPrint = new mdImpresora();
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
            gTxtObsEquipo.Enabled = false;
            gGroupBox.Enabled = false;

        }

        private void btnDesActivados()
        {
            gBtnRegistrarDispositivo.Enabled = true;
            gBtnRegistrarDispositivo.Visible = true;
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
            gTxtObsEquipo.Enabled = true;
            gGroupBox.Enabled = true;
        }

        public void CajasTxtPrintLimpias()
        {
            gTxtSerieEquipo.Text = "";
            gTxtNomEquipo.Text = "";
            gTxtNoEquipo.Text = "";
            gTxtModeloEquipo.Text = "";
            gTxtMarcaEquipo.Text = "";
            gTxtObsEquipo.Text = "";
            gChBoxAccesorio1.Checked = false;
            gChBoxAccesorio2.Checked = false;
            gChBoxAccesorio3.Checked = false;


        }


        //metodo para Guardar Equipo Print
        private void savePrint()
        {
            string accesorios = "";
            string fechaCaptura = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            bool status = true;
            try
            {
                dtImpresora dtImpresora = new dtImpresora();

                if (gChBoxAccesorio1.Checked == true)
                    accesorios += gChBoxAccesorio1.Text +",\n";
                if (gChBoxAccesorio2.Checked == true)
                    accesorios += gChBoxAccesorio2.Text + ",\n"; 
                if (gChBoxAccesorio3.Checked == true)
                    accesorios += gChBoxAccesorio3.Text;



                dtImpresora.NumeroEquipo = gTxtNoEquipo.Text;
                dtImpresora.NombreEquipo = gTxtNomEquipo.Text;
                dtImpresora.SerieEquipo = gTxtSerieEquipo.Text;
                dtImpresora.MarcaEquipo = gTxtMarcaEquipo.Text;
                dtImpresora.ModeloEquipo = gTxtModeloEquipo.Text;
                dtImpresora.ObsEquipo = gTxtObsEquipo.Text + "\n Siguientes Accesorios: " + accesorios;
                dtImpresora.EstadoEquipo = status;
                dtImpresora.FechaAlta = fechaCaptura;

                




                if (string.IsNullOrEmpty(gTxtNoEquipo.Text) || string.IsNullOrEmpty(gTxtNomEquipo.Text) || string.IsNullOrEmpty(gTxtSerieEquipo.Text) || string.IsNullOrEmpty(gTxtMarcaEquipo.Text) || string.IsNullOrEmpty(gTxtModeloEquipo.Text) || string.IsNullOrEmpty(gTxtObsEquipo.Text))
                {
                    MessageBox.Show("Debe Completar la información");
                }
                  else if (!mdPrint.ExistePrint(dtImpresora.SerieEquipo))
                {
                    if (mdPrint.insertImpresora(dtImpresora))
                    {
                        MessageBox.Show("Se Guardo Exitosamente");
                        mdPrint.llenargrid(dtgvPrint);
                       // scProducto.llenargrid(dtgvProductos);
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

        private void gBtnRegistrarDispositivo_Click(object sender, EventArgs e)
        {
            txtCajasActivadas();
            btnActivados();
        }

        private void gBtnGuardarDispositivo_Click(object sender, EventArgs e)
        {
            savePrint();
            mdPrint.llenargrid(dtgvPrint);
            CajasTxtPrintLimpias();
            txtCajasDesActivadas();
            btnDesActivados();
        }

        private void gBtnQrDispositivo_Click(object sender, EventArgs e)
        {

            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(gTxtNoEquipo.Text.Trim() + "\n" + gTxtNomEquipo.Text.Trim() + "\n" + gTxtSerieEquipo.Text.Trim() + "\n" + gTxtMarcaEquipo.Text.Trim() + "\n" + gTxtModeloEquipo.Text.Trim(),out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix,ImageFormat.Png,ms);

            var imgTmp = new Bitmap(ms);
            var img = new Bitmap(imgTmp, new Size(new Point(346,281)));

            pctQr.BackgroundImage = img;
            img.Save("QrImg.png", ImageFormat.Png);


        }
    }
}
