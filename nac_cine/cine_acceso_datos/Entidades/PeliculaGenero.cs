using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class PeliculaGenero
    {
        public int idPeliculaGenero { get; set; }
        public int idPelicula { get; set; }
        public int idGenero { get; set; }
        public int estado { get; set; }
    }
}
