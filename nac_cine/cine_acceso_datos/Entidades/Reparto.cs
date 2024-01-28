using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Reparto
    {
        public int idReparto { get; set; }
        public int idPelicula { get; set; }
        public string NombreActor { get; set; }
        public string Personaje { get; set; }
        public int Estado { get; set; }
    }
}
