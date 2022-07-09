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
        int initPrint;
        int initRegion;

        public frmAsignacion()
        {
            InitializeComponent();
            mdlRegion = new mdRegion();
            dtRegiones = new dtRegion();
            mdPrint = new mdImpresora();
            dtImpresora = new dtImpresora();
        }
        
        private void frmAsignacion_Load(object sender, EventArgs e)
        {
            mdlRegion.llenarCmbxRegion(gcmbxRegion);
            mdPrint.llenarCmbxPrint(gcmbxPrint);
           
           
           
        }

        private void gcmbxPrint_SelectedIndexChanged(object sender, EventArgs e)
        {
            gLbl.Text = gcmbxPrint.SelectedIndex.ToString();
            initPrint =Convert.ToInt32( gLbl.Text);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            gLblFecha.Text = mthCalendar.SelectionStart.ToShortDateString().ToString();
        }
    }
}
