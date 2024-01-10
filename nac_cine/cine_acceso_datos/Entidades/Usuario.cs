using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Usuario
    {
        private int idUsuario { get; set; }
        private string nombreUsuario { get; set; }
        private string apellidoUsuario { get; set; }
        private string cedulaUsuario { get; set; }
        private string emailUsuario { get; set; }
        private string telefonoUsuario { get; set; }
        private int edadUsuario { get; set; }
        private string usernameUsuario { get; set; }
        private string passwordUsuario { get; set; }
        private bool estadoUsuario { get; set; }
    }
}
