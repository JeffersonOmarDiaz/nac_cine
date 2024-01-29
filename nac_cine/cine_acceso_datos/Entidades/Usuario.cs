using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string apellidoUsuario { get; set; }
        public string cedulaUsuario { get; set; }
        public string emailUsuario { get; set; }
        public string telefonoUsuario { get; set; }
        public int edadUsuario { get; set; }
        public string usernameUsuario { get; set; }
        public string passwordUsuario { get; set; }
        public int estadoUsuario { get; set; }
    }
}
