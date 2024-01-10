using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Reparto
    {
        private int idReparto { get; set; }
        private int idPelicula { get; set; }
        private string NombreActor { get; set; }
        private string Personaje { get; set; }
        private int Estado { get; set; }
    }
}
