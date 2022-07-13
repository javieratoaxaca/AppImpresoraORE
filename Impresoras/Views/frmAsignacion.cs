using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impresoras.Data;
using Impresoras.Models;

namespace Impresoras.Views
{
    public partial class frmAsignacion : Form
    {
        mdRegion mdlRegion;
        dtRegion dtRegiones;
        mdImpresora mdPrint;
        dtImpresora dtPrint;
        mdlAsignacionPrint mdlAssign;
        dtDetallesAsignacion dtAssign;
        int IdPrint;
        int IdRegion;
        string fechAsignacion;
        string intIdEquipoSerie;

        public frmAsignacion()
        {
            InitializeComponent();
            mdlRegion = new mdRegion();
            dtRegiones = new dtRegion();
            mdPrint = new mdImpresora();
            dtPrint = new dtImpresora();
            mdlAssign = new mdlAsignacionPrint();
            dtAssign = new dtDetallesAsignacion();
            mdlRegion.llenarCmbxRegion(gcmbxRegion);
            mdPrint.llenarCmbxPrint(gcmbxPrint);
            mdlAssign.llenargrid(dtgvAssignDetails);
        }
        
        private void frmAsignacion_Load(object sender, EventArgs e)
        {
            mdlRegion.llenarCmbxRegion(gcmbxRegion);
            mdPrint.llenarCmbxPrint(gcmbxPrint);
        }

        private void gcmbxPrint_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serie;
            gLblItem.Text = gcmbxPrint.SelectedItem.ToString(); 
            serie = gLblItem.Text;
            dtPrint = mdPrint.GetPrint(serie);
            gLblId.Text= Convert.ToString(dtPrint.IdInventarioEquipo);
            IdPrint = Convert.ToInt32( gLblId.Text);
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            gLblFecha.Text = mthCalendar.SelectionStart.Date.ToString("yyyy-MM-dd");
            //for(int i=0;i<=gLblFecha.)
            fechAsignacion = gLblFecha.Text;
        }
        private void gcmbxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sare;
            gLblItemRegion.Text = gcmbxRegion.SelectedItem.ToString();
            sare = gLblItemRegion.Text;
            dtRegiones = mdlRegion.GetRegion(sare);
            gLblIdRegion.Text = Convert.ToString( dtRegiones.IdRegion);
            IdRegion = Convert.ToInt32(gLblIdRegion.Text);
        }

        #region Metodo para Guardar Asignacion
        private void saveAssignPrint()
        {
            
            int status = 2;
            //Seccion para tomar el valor del idInventarioEquipo 
            string serie;
            gLblItem.Text = gcmbxPrint.SelectedItem.ToString(); 
            serie = gLblItem.Text;
            dtPrint = mdPrint.GetPrint(serie);
            gLblId.Text = Convert.ToString(dtPrint.IdInventarioEquipo);
            IdPrint = Convert.ToInt32(gLblId.Text);
            //Seccion para tomar el valor del idRegion 
            string sare;
            gLblItemRegion.Text = gcmbxRegion.SelectedItem.ToString();
            sare = gLblItemRegion.Text;
            dtRegiones = mdlRegion.GetRegion(sare);
            gLblIdRegion.Text = Convert.ToString(dtRegiones.IdRegion);
            IdRegion = Convert.ToInt32(gLblIdRegion.Text);


            try
            {
                
                //los datos que se guardaran en la tabla de Detalleasignacion
                dtAssign.IdRegion = IdRegion;
                dtAssign.IdInventarioEquipo = IdPrint;
                dtAssign.FechaAsignacion = fechAsignacion;

                // los datos que se actualizaran en la tabla de inventarioequipo
                dtPrint.EstadoEquipo = status;
          
                

                // if (!mdlAssign. .ExistePrint(dtImpresora.SerieEquipo))
               // {
                    if (mdlAssign.insertAssignPrint(dtAssign) && mdPrint.UpdatePrintStatus(dtPrint, dtAssign))
                    {
                        MessageBox.Show("Se Guardo Exitosamente");
                        mdlAssign.llenargrid(dtgvAssignDetails);
                        mdlRegion.llenarCmbxRegion(gcmbxRegion);
                        mdPrint.llenarCmbxPrint(gcmbxPrint);
                    // scInventario.llenargridInv(dtgvInventario);
                }
                //}
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

        private void returnAssignPrint()
        {

            int status = 1;
            try
            {

                dtPrint.IdInventarioEquipo = Convert.ToInt32(intIdEquipoSerie);
                dtPrint.EstadoEquipo = status;


                if (mdlAssign.UpdatePrintStatusAssign(dtPrint))
                {
                    MessageBox.Show("Gracias por la Devolucion");
                    mdlAssign.llenargrid(dtgvAssignDetails);

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

        //Metodo para actualizar 

        #endregion

        private void gbtnAssignPrint_Click(object sender, EventArgs e)
        {
            saveAssignPrint();
            mdlAssign.llenargrid(dtgvAssignDetails);
            mdPrint.llenarCmbxPrint(gcmbxPrint);
            
        }

        private void gBtnReturnPrint_Click(object sender, EventArgs e)
        {
            returnAssignPrint();
            mdlAssign.llenargrid(dtgvAssignDetails);
            mdPrint.llenarCmbxPrint(gcmbxPrint);
        }

        private void dtgvAssignDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            intIdEquipoSerie = dtgvAssignDetails.CurrentRow.Cells[4].Value.ToString();
            dtAssign.IdInventarioEquipo = Convert.ToInt32(intIdEquipoSerie.ToString());
            gLblEquipoSerie.Text = dtAssign.IdInventarioEquipo.ToString();
            
        }

        
    }
}
