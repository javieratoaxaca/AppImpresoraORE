using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MySql.Data.MySqlClient;
using System.Data.OleDb;

using System.Data;
using System.Windows.Forms;

using Impresoras.Data;

namespace Impresoras.Models
{
    class mdImpresora:Config.DBImpresora
    {
       
        public mdImpresora() { }
        public bool insertImpresora(dtImpresora dtPrint) {

            string Query = string.Format("INSERT INTO inventarioequipo (numEquipo,nombreEquipo,serieEquipo,marcaEquipo," +
                                         "modeloEquipo,obsEquipo,statusEquipo,fechaRegistro,imgQr) " +
                                         "VALUES('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}')",
                                         dtPrint.NumeroEquipo,dtPrint.NombreEquipo,dtPrint.SerieEquipo,dtPrint.MarcaEquipo, 
                                         dtPrint.ModeloEquipo, dtPrint.ObsEquipo,dtPrint.EstadoEquipo,dtPrint.FechaAlta,dtPrint.ImgQr);
            try
            {
                int result = ExecuteQuery(Query);
                if (result > 0)
                    return true;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return false;
        }


        //Metodo para saber si existe una impresora
        public bool ExistePrint(string serie)
        {

            dtImpresora dtPrint = new dtImpresora();
            try
            {
                string Query = string.Format("SELECT serieEquipo FROM inventarioequipo WHERE serieEquipo LIKE '{0}'", serie);
                MySqlDataReader dr = GetDataReader(Query);
                return dr.HasRows;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Metodo para Actualizar el Registro Completo y se muestre en el Datagrid
        /*public bool UpdateProducto(dtImpresora dtPrint)
        {
            string Query = string.Format("UPDATE producto SET NombreProducto='{0}',descripcion='{1}',TipoUnidad='{2}',PrecioCosto={3},PrecioVenta={4},PrecioMayoreo={5},PrecioMenudeo={6},CantidadProducto={7},IdDeptoCatego={8} WHERE CodBarras like '{9}'", dtProducto.nombreproducto, dtProducto.descripcion, dtProducto.tipounidad, dtProducto.preciocosto, dtProducto.precioventa, dtProducto.preciomayoreo, dtProducto.preciomenudeo, dtProducto.cantproducto, dtProducto.deptocategoria, dtProducto.codbarras);
            try
            {
                int result = ExecuteQuery(Query);
                if (result > 0)

                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;
        }*/

        //Metodo para llenar el DataGridView
        public void llenargrid(DataGridView grid)
        {
            try
            {
                string Query = string.Format("select * from inventarioequipo");
                MySqlCommand Query2 = new MySqlCommand(Query, getConnection());
                MySqlDataAdapter da = new MySqlDataAdapter(Query2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
