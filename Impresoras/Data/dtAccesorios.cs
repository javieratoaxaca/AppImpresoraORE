using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresoras.Data
{
    class dtAccesorios
    {
        int idAccesorioEquipo;
        string nombreAccesorio;
        bool estado;

        public int IdAccesorioEquipo
        {
            get
            {
                return idAccesorioEquipo;
            }

            set
            {
                idAccesorioEquipo = value;
            }
        }

        public string NombreAccesorio
        {
            get
            {
                return nombreAccesorio;
            }

            set
            {
                nombreAccesorio = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}
