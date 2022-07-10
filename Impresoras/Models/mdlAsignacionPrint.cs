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
    }
    
}
