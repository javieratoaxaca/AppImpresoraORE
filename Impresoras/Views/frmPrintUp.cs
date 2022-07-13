using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
//libreria para Conexion
using Impresoras.Data;
using Impresoras.Models;
//Librerias para el primer metodo para Generar el QR
//using Gma.QrCodeNet.Encoding;
//using Gma.QrCodeNet.Encoding.Windows.Render;
//Librerias para el segundo metodo para generar el QR
using ZXing;
using ZXing.Common;

using System.Drawing.Imaging;

namespace Impresoras.Views
{
    public partial class frmPrintUp : Form

    {
        mdImpresora mdPrint;
        dtImpresora dtPrint;
        byte[] aByte=null;
        string encoded = "";
        string intIdEquipoSerie;
        string serie;
        public frmPrintUp()
        {
            mdPrint = new mdImpresora();
            dtPrint = new dtImpresora();
            InitializeComponent();
            mdPrint.llenargridOne(dtgvPrint);
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
            pctQr.Image = null;

        }


        //metodo para Guardar Equipo Print
        private void savePrint()
        {
            string accesorios = "";
            
            int status = 1;
            try
            {
                dtImpresora dtImpresora = new dtImpresora();
                string fechaCaptura = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
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
                dtImpresora.ImgQr = encoded;

                
                if (string.IsNullOrEmpty(gTxtNoEquipo.Text) || string.IsNullOrEmpty(gTxtNomEquipo.Text) || string.IsNullOrEmpty(gTxtSerieEquipo.Text) || string.IsNullOrEmpty(gTxtMarcaEquipo.Text) || string.IsNullOrEmpty(gTxtModeloEquipo.Text) || string.IsNullOrEmpty(gTxtObsEquipo.Text))
                {
                    MessageBox.Show("Debe Completar la información");
                    return;
                }
                if (!mdPrint.ExistePrint(dtImpresora.SerieEquipo))
                {
                    if (mdPrint.insertImpresora(dtImpresora))
                    {
                        MessageBox.Show("Se Guardo Exitosamente");
                        mdPrint.llenargridOne(dtgvPrint);
                       // scInventario.llenargridInv(dtgvInventario);
                    }
                }
                else
                {
                    if (mdPrint.UpdatePrint(dtImpresora))
                    {
                        MessageBox.Show("Se Actualizacion Exitosamente");
                        mdPrint.llenargridOne(dtgvPrint);
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //
        private void savePrintDelete()
        {
            string accesorios = "";
            string fechaCaptura = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            int status = 0;
            try
            {
                dtImpresora dtImpresora = new dtImpresora();
         
                if (gChBoxAccesorio1.Checked == true)
                    accesorios += gChBoxAccesorio1.Text + ",\n";
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
                dtImpresora.ImgQr = encoded;


                if (string.IsNullOrEmpty(gTxtNoEquipo.Text) || string.IsNullOrEmpty(gTxtNomEquipo.Text) || string.IsNullOrEmpty(gTxtSerieEquipo.Text) || string.IsNullOrEmpty(gTxtMarcaEquipo.Text) || string.IsNullOrEmpty(gTxtModeloEquipo.Text) || string.IsNullOrEmpty(gTxtObsEquipo.Text))
                {
                    MessageBox.Show("Debe Completar la información");
                    return;
                }
                if (!mdPrint.ExistePrint(dtImpresora.SerieEquipo))
                {
                   /* if (mdPrint.insertImpresora(dtImpresora))
                    {
                        MessageBox.Show("Se Guardo Exitosamente");
                        mdPrint.llenargridOne(dtgvPrint);
                        // scInventario.llenargridInv(dtgvInventario);
                    }*/
                }
                else
                {
                    if (mdPrint.UpdatePrintStatusDelete(dtImpresora))
                    {
                        MessageBox.Show("Se Elimino Exitosamente");
                        mdPrint.llenargridOne(dtgvPrint);
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Metodos para el manejo de la imagen que se guardara o mostrara en la base de datos
        // de Byte a Img
        /*   private static MemoryStream byteToImage(byte[] array)
       {
           MemoryStream ms = new MemoryStream();
           return ms;
       }

       // de Img a Byte
       private static byte [] imgToByte(Image imgIn)
       {
           MemoryStream ms = new MemoryStream();
           imgIn.Save(ms, ImageFormat.Png);
           return ms.ToArray();
       }*/
        #endregion

        private void gBtnRegistrarDispositivo_Click(object sender, EventArgs e)
        {
            txtCajasActivadas();
            btnActivados();
        }

        private void gBtnGuardarDispositivo_Click(object sender, EventArgs e)
        {
            savePrint();
            mdPrint.llenargridOne(dtgvPrint);
            CajasTxtPrintLimpias();
            txtCajasDesActivadas();
            btnDesActivados();
        }


        //Seccion para Generar el Qr
        private void gBtnQrDispositivo_Click(object sender, EventArgs e)
        {
            //Primer Modo para Generar el QR
            /*
               QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
               QrCode qrCode = new QrCode();
               qrEncoder.TryEncode(gTxtNoEquipo.Text.Trim() + "\n" + gTxtNomEquipo.Text.Trim() + "\n" + gTxtSerieEquipo.Text.Trim() + "\n" + gTxtMarcaEquipo.Text.Trim() + "\n" + gTxtModeloEquipo.Text.Trim(),out qrCode);

               GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

               MemoryStream ms = new MemoryStream();
               renderer.WriteToStream(qrCode.Matrix,ImageFormat.Png,ms);

               var imgTmp = new Bitmap(ms);
               var img = new Bitmap(imgTmp, new Size(new Point(346,281)));

               pctQr.Image = img;
               img.Save(ms, ImageFormat.Png);
               aByte = ms.ToArray();
               encoded = Convert.ToBase64String(aByte);*/
            
            // Segundo modo para Generar el QR pero no guarda en la Base de Datos
            Bitmap img;
            MemoryStream ms = new MemoryStream();
            BarcodeWriter QrWriter = new BarcodeWriter();
            QrWriter.Format = BarcodeFormat.QR_CODE;  
            EncodingOptions options = new EncodingOptions() { Width = 323, Height = 281, Margin = 1 };
            QrWriter.Options = options;
            img = QrWriter.Write(gTxtNoEquipo.Text.Trim() + "\n" + gTxtNomEquipo.Text.Trim() + "\n" + gTxtSerieEquipo.Text.Trim() + "\n" + gTxtMarcaEquipo.Text.Trim() + "\n" + gTxtModeloEquipo.Text.Trim());
            pctQr.Image = img;
            img.Save(ms, ImageFormat.Png);
            aByte = ms.ToArray();
            encoded = Convert.ToBase64String(aByte);
        }

        private void dtgvPrint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serie = dtgvPrint.CurrentRow.Cells[3].Value.ToString();
            gLblIdInventarioEquipo.Text = serie;
            gBtnEditarDispositivo.Enabled = true;
            gBtnEliminarDispositivo.Enabled = true;
            dtPrint = mdPrint.GetPrint(serie);
            gTxtNoEquipo.Text = dtPrint.NumeroEquipo;
            gTxtNomEquipo.Text = dtPrint.NombreEquipo;
            gTxtSerieEquipo.Text = dtPrint.SerieEquipo;
            gTxtMarcaEquipo.Text = dtPrint.MarcaEquipo;
            gTxtModeloEquipo.Text = dtPrint.ModeloEquipo;
            gTxtObsEquipo.Text = dtPrint.ObsEquipo;
            //pctQr.Image = dtPrint.ImgQr;
        }

        private void gBtnEditarDispositivo_Click(object sender, EventArgs e)
        {
            txtCajasActivadas();
            gBtnRegistrarDispositivo.Enabled = false;
            gBtnRegistrarDispositivo.Visible = false;
            gBtnGuardarDispositivo.Enabled = true;
            gBtnGuardarDispositivo.Visible = true;
            //gBtnEliminarDispositivo.Enabled = true;
            //gBtnEliminarDispositivo.Visible = true;
            gBtnQrDispositivo.Enabled = true;
            gBtnEditarDispositivo.Enabled = false;
        }

        private void gBtnEliminarDispositivo_Click(object sender, EventArgs e)
        {
            serie = dtgvPrint.CurrentRow.Cells[3].Value.ToString();
            gLblIdInventarioEquipo.Text = serie;
            gBtnEditarDispositivo.Enabled = true;
            savePrintDelete();
            txtCajasDesActivadas();
            CajasTxtPrintLimpias();
            btnDesActivados();

        }
    }
}
