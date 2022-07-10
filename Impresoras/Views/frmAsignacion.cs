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
        dtImpresora dtImpresora;
        mdlAsignacionPrint mdlAssign;
        dtDetallesAsignacion dtAssign;
        int intPrint;
        int intRegion;
        string fechAsignacion;

        public frmAsignacion()
        {
            InitializeComponent();
            mdlRegion = new mdRegion();
            dtRegiones = new dtRegion();
            mdPrint = new mdImpresora();
            dtImpresora = new dtImpresora();
            mdlAssign = new mdlAsignacionPrint();
            dtAssign = new dtDetallesAsignacion();
            mdlRegion.llenarCmbxRegion(gcmbxRegion);
            mdPrint.llenarCmbxPrint(gcmbxPrint);
        }
        
        private void frmAsignacion_Load(object sender, EventArgs e)
        {
            mdlRegion.llenarCmbxRegion(gcmbxRegion);
            mdPrint.llenarCmbxPrint(gcmbxPrint);
        }

        private void gcmbxPrint_SelectedIndexChanged(object sender, EventArgs e)
        {
            gLbl.Text = gcmbxPrint.SelectedIndex.ToString();
            intPrint = int.Parse( gLbl.Text);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            gLblFecha.Text = mthCalendar.SelectionStart.Date.ToString("yyyy-MM-dd");
            //for(int i=0;i<=gLblFecha.)
            fechAsignacion = gLblFecha.Text;
        }
        private void gcmbxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            gLblSare.Text = gcmbxRegion.SelectedIndex.ToString();
            intRegion =int.Parse(gLblSare.Text.ToString());
        }

        #region Metodo para Guardar Asignacion
        private void saveAssignPrint()
        {
            
            int status = 2;
            try
            {
                //dtImpresora dtImpresora = new dtImpresora();
                dtAssign.IdRegion = intRegion;
                dtAssign.IdInventarioEquipo = intPrint;
                dtAssign.FechaAsignacion = fechAsignacion;
                dtImpresora.EstadoEquipo = status;

                // if (!mdlAssign. .ExistePrint(dtImpresora.SerieEquipo))
               // {
                    if (mdlAssign.insertAssignPrint(dtAssign) && mdPrint.UpdatePrintStatus(dtImpresora,dtAssign))
                    {
                        MessageBox.Show("Se Guardo Exitosamente");
                        //mdPrint.llenargrid(dtgvPrint);
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

        #endregion

        private void gbtnAssignPrint_Click(object sender, EventArgs e)
        {
            saveAssignPrint();
        }
    }
}
