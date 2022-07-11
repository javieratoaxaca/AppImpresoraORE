using System;

using MySql.Data.MySqlClient;

using System.Data;
using System.Windows.Forms;
using Impresoras.Data;



namespace Impresoras.Models
{
    class mdlAsignacionPrint : Config.DBImpresora
    {


        public mdlAsignacionPrint() { }
        //Metodo para Registrar 
        public bool insertAssignPrint(dtDetallesAsignacion dtDetailsAssignPrint)
        {
            string Query = string.Format("INSERT INTO detalleasignacion (idInventarioEquipo,idRegion,fechaAsignacion)" +
                                         "VALUES({0},{1},'{2}')",dtDetailsAssignPrint.IdInventarioEquipo,dtDetailsAssignPrint.IdRegion,dtDetailsAssignPrint.FechaAsignacion);

            //MySqlCommand
            try
            {
                Console.Write(Query);

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

        //Metodo para Llenar el DataGridView con los Datos 
        public void llenargrid(DataGridView grid)
        {
            try
            {
                string Query = string.Format("select a.idRegion as IdRegion, a.idSare as SARE,a.sare AS NOMBRESARE, a.jefeSare as RESPONSABLE, b.idInventarioEquipo as IdInventarioEquipo, b.nombreEquipo as EQUIPO, b.serieEquipo as SERIE, b.marcaEquipo as MARCA, c.fechaAsignacion as FECHA_ASIGNACION from region as a, inventarioequipo as b, detalleasignacion as c where c.idRegion=a.idRegion  and c.idInventarioEquipo=b.idInventarioEquipo and b.statusEquipo=2");
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

        //Metodo para actualizar el estado de la impresora cuando se recupera su valor
        public bool UpdatePrintStatusAssign(dtImpresora dtPrint)
        {
            string Query = string.Format("UPDATE inventarioequipo SET statusEquipo={0} Where idInventarioEquipo={1}", dtPrint.EstadoEquipo, dtPrint.IdInventarioEquipo);
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
    }
    
}
