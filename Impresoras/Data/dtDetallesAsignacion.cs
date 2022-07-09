using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresoras.Data
{
    class dtDetallesAsignacion
    {
        int idDetalleAsignacion;
        int idInventarioEquipo;
        int idRegion;
        string fechaAsignacion;

        public int IdDetalleAsignacion
        {
            get
            {
                return idDetalleAsignacion;
            }

            set
            {
                idDetalleAsignacion = value;
            }
        }

        public int IdInventarioEquipo
        {
            get
            {
                return idInventarioEquipo;
            }

            set
            {
                idInventarioEquipo = value;
            }
        }

        public int IdRegion
        {
            get
            {
                return idRegion;
            }

            set
            {
                idRegion = value;
            }
        }

        public string FechaAsignacion
        {
            get
            {
                return fechaAsignacion;
            }

            set
            {
                fechaAsignacion = value;
            }
        }
    }
}
