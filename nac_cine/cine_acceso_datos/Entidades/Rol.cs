using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Rol
    {
        public int idRole { get; set; }
        public int idUsuario { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }

    }
}
