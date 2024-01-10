using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Sala
    {
        private int idSala { get; set; }
        private int idCine { get; set; }
        private string nombreSala { get; set; }
        private bool estadoSala { get; set; }
    }
}
