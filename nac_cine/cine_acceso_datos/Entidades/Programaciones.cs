using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Programaciones
    {
       public int idProgramacion { get; set; }
        public int idSala { get; set; }
        public int idPelicula { get; set; }
        public int idUsuario { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string estreno { get; set; }
        public int estado { get; set; }
              
    }
}
