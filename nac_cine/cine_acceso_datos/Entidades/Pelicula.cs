using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Pelicula
    {
        public int idPelicula {  get; set; }
        public string nombre { get; set; }
        public string sinopsis { get; set; }
        public int anio { get; set; }
        public string trailer { get; set; }
        public string duracion { get; set; }
        public int genero { get; set; }
        public int stock { get; set; }
        public int stado { get; set; }

    }
}
