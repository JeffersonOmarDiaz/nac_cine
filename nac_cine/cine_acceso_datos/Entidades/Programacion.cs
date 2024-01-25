using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Programacion
    {
       public int idProgramacion { get; set; }
        public int idSala { get; set; }
        public int idPelicula { get; set; }
        public int idUsuario { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string estreno { get; set; }
        public int estado { get; set; }
              
    }
}
