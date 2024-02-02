using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Proveedores
    {
        public int idProveedor { get; set; }
        public string Nombre { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string ruc { get; set; }
        public int estado { get; set; }

    }
}
