using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impresoras.Config;

namespace Impresoras.Views
{
    public partial class vwPrincipal : Form
    {
        public vwPrincipal()
        {
            DBImpresora cnx= new DBImpresora();
            InitializeComponent();
            MessageBox.Show("Conexion Exitosa" + cnx.getConnection());
        }
    }
}
