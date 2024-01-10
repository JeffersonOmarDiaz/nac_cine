using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Programacion
    {
        private int idProgramacion { get; set; }
        private int idSala { get; set; }
        private int idPelicula { get; set; }
        private int idUsuario { get; set; }
        private string HoraInicio { get; set; }
        private string HoraFin { get; set; }
        private string estreno { get; set; }
        private int estado { get; set; }
              
    }
}
