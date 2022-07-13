using System;
using System.Windows.Forms;
using Impresoras.Data;
using Impresoras.Models;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Drawing;
using SpreadsheetLight;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Impresoras.Views
{
    public partial class frmRegion : Form
    {
        mdRegion mdlRegion;
        dtRegion dtRegiones;
        int sare;
        public frmRegion()
        {
            InitializeComponent();
            mdlRegion = new mdRegion();
            dtRegiones=new dtRegion();
            txtCajasDesactivadas();
            btnDesactivados();
            mdlRegion.llenarGrid(dtgvRegiones);
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
                dtRegiones.IdSare = gTxtIdSare.Text;
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
                    if (mdlRegion.UpdateRegion(dtRegiones))
                    {
                        MessageBox.Show("Se Actualizacion Exitosamente");
                        mdlRegion.llenarGrid(dtgvRegiones);
                    }
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

        private void gBtnEditarregion_Click(object sender, EventArgs e)
        {
            txtCajasActivadas();
            gTxtIdSare.Enabled = false;
            gBtnEliminarRegion.Enabled = false;
            gBtnGuardarRegion.Enabled = true;

        }

        private void dtgvRegiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idSare;
            idSare = dtgvRegiones.CurrentRow.Cells[2].Value.ToString();
            lblPrueba.Text = idSare;
            dtRegiones = mdlRegion.GetRegion(idSare);
            gTxtIdSare.Text = dtRegiones.IdSare;
            gTxtNameSare.Text = dtRegiones.Sare;
            gTxtCveInegi.Text = dtRegiones.CveOfiLocalidad;
            gTxtCveMun.Text = dtRegiones.CveMun;
            gTxtMunicipio.Text = dtRegiones.Municipio;
            gTxtCveLoc.Text = dtRegiones.CveLocalidad;
            gTxtLocalidad.Text = dtRegiones.Localidad;
            gTxtCupo.Text = Convert.ToString( dtRegiones.Cupo);
            gTxtJefeSare.Text = dtRegiones.JefeSare;
            gTxtEmailSare.Text = dtRegiones.Email;
            gTxtDomicilioSare.Text = dtRegiones.Domicilio;
            gTxtHorario.Text = dtRegiones.Horario;
            gTxtTelefono.Text = dtRegiones.Telefono;
            gTxtLatitud.Text = dtRegiones.Latitud;
            gTxtLongitud.Text = dtRegiones.Longitud;
            gBtnRegistrarRegion.Enabled = false;
            gBtnEditarregion.Enabled = true;
            gBtnEliminarRegion.Enabled = true;
        }

        private void gBtnEliminarRegion_Click(object sender, EventArgs e)
        {
            string idSare;
            idSare = dtgvRegiones.CurrentRow.Cells[2].Value.ToString();
            lblPrueba.Text = idSare;
            mdlRegion.deleteRegion(idSare);
        }

        private void gBtnGenExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // string CodBarras;
                //CodBarras = scProducto.llenargrid(dtgvProductos);
                System.Drawing.Color cl = new System.Drawing.Color();
                System.Drawing.Color cl2 = new System.Drawing.Color();

                cl = System.Drawing.Color.FromArgb(158, 207, 185);
                cl2 = System.Drawing.Color.FromArgb(52, 83, 101);
                SLDocument sl = new SLDocument();
                SLStyle style = new SLStyle();
                SLStyle style2 = new SLStyle();
                //Seccion para las celdas de titulo
                style.Font.FontSize = 15;
                style.Font.FontName = "Heltica";
                style.Font.FontColor = cl;
                style.Font.Bold = true;
                style.Fill.SetPattern(PatternValues.Solid, cl2, cl);
                style.Border.LeftBorder.BorderStyle = BorderStyleValues.Thick;
                style.Border.LeftBorder.Color = System.Drawing.Color.BlanchedAlmond;
                style.Border.BottomBorder.BorderStyle = BorderStyleValues.DashDotDot;
                style.Border.BottomBorder.Color = System.Drawing.Color.Brown;
                //style.SetTopBorder(BorderStyleValues.Medium, SLThemeColorIndexValues.Accent6Color);


                //Seccion para las celdas del Grid
                style2.Font.FontSize = 12;
                style2.Font.FontName = "Heltica";
                style2.Border.LeftBorder.BorderStyle = BorderStyleValues.Thick;
                style2.Border.LeftBorder.Color = System.Drawing.Color.BlanchedAlmond;
                style2.Border.BottomBorder.BorderStyle = BorderStyleValues.DashDotDot;
                style2.Border.BottomBorder.Color = System.Drawing.Color.Brown;
                //style2.SetTopBorder(BorderStyleValues.Medium, SLThemeColorIndexValues.Accent6Color);

                sl.SetCellValue("B1", "IdEstado");
                sl.SetCellStyle("B1", style);
                sl.SetCellValue("C1", "Estado");
                sl.SetCellStyle("C1", style);
                sl.SetCellValue("D1", "IdSare");
                sl.SetCellStyle("D1", style);
                sl.SetCellValue("E1", "Nombre_SARE");
                sl.SetCellStyle("E1", style);
                sl.SetCellValue("F1", "CveOfi_Localidad");
                sl.SetCellStyle("F1", style);
                sl.SetCellValue("G1", "CveMunicipio");
                sl.SetCellStyle("G1", style);
                sl.SetCellValue("H1", "Municipio");
                sl.SetCellStyle("H1", style);
                sl.SetCellValue("I1", "CveLocalidad");
                sl.SetCellStyle("I1", style);
                sl.SetCellValue("J1", "Localidad");
                sl.SetCellStyle("J1", style);
                sl.SetCellValue("K1", "Cupo");
                sl.SetCellStyle("K1", style);
                sl.SetCellValue("L1", "Responsable_Sare");
                sl.SetCellStyle("L1", style);
                sl.SetCellValue("M1", "Email");
                sl.SetCellStyle("M1", style);
                sl.SetCellValue("N1", "Domicilio");
                sl.SetCellStyle("N1", style);
                sl.SetCellValue("O1", "Horario");
                sl.SetCellStyle("O1", style);
                sl.SetCellValue("P1", "Telefono");
                sl.SetCellStyle("P1", style);
                sl.SetCellValue("Q1", "Latitud");
                sl.SetCellStyle("Q1", style);
                sl.SetCellValue("R1", "Latitud");
                sl.SetCellStyle("R1", style);


                int iR = 2;

                foreach (DataGridViewRow row in dtgvRegiones.Rows)
                {
                    //sl.SetCellValue("", true);
                    // sl.SetCellValue(iR, 1, "A");
                    // MessageBox.Show(row.Cells[0].Value.ToString());
                    sl.SetCellValue(iR, 2, row.Cells[0].Value.ToString());
                    sl.SetCellStyle(iR, 2, style2);
                    sl.SetCellValue(iR, 3, row.Cells[1].Value.ToString());
                    sl.SetCellStyle(iR, 3, style2);
                    sl.SetCellValue(iR, 4, row.Cells[2].Value.ToString());
                    sl.SetCellStyle(iR, 4, style2);
                    sl.SetCellValue(iR, 5, row.Cells[3].Value.ToString());
                    sl.SetCellStyle(iR, 5, style2);
                    sl.SetCellValue(iR, 6, row.Cells[4].Value.ToString());
                    sl.SetCellStyle(iR, 6, style2);
                    sl.SetCellValue(iR, 7, row.Cells[5].Value.ToString());
                    sl.SetCellStyle(iR, 7, style2);
                    sl.SetCellValue(iR, 8, row.Cells[6].Value.ToString());
                    sl.SetCellStyle(iR, 8, style2);
                    sl.SetCellValue(iR, 9, row.Cells[7].Value.ToString());
                    sl.SetCellStyle(iR, 9, style2);
                    sl.SetCellValue(iR, 10, row.Cells[8].Value.ToString());
                    sl.SetCellStyle(iR, 10, style2);
                    sl.SetCellValue(iR, 11, row.Cells[9].Value.ToString());
                    sl.SetCellStyle(iR, 11, style2);
                    sl.SetCellValue(iR, 12, row.Cells[10].Value.ToString());
                    sl.SetCellStyle(iR, 12, style2);
                    sl.SetCellValue(iR, 13, row.Cells[11].Value.ToString());
                    sl.SetCellStyle(iR, 13, style2);
                    sl.SetCellValue(iR, 14, row.Cells[12].Value.ToString());
                    sl.SetCellStyle(iR, 14, style2);
                    sl.SetCellValue(iR, 15, row.Cells[13].Value.ToString());
                    sl.SetCellStyle(iR, 15, style2);
                    sl.SetCellValue(iR, 16, row.Cells[14].Value.ToString());
                    sl.SetCellStyle(iR, 16, style2);
                    sl.SetCellValue(iR, 17, row.Cells[15].Value.ToString());
                    sl.SetCellStyle(iR, 17, style2);
                    sl.SetCellValue(iR, 18, row.Cells[16].Value.ToString());
                    sl.SetCellStyle(iR, 18, style2);

                    iR++;
                }
                sl.SaveAs(@"D:\Directorio_Regiones.xlsx");
                MessageBox.Show("Se Guardo Archivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gBtnGenPdf_Click(object sender, EventArgs e)
        {

        }
    }
}
