using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    internal class Asiento
    {
        private int idAsiento {  get; set; }
        private int idSala { get; set; }
        private string numeroAsiento { get; set; }
        private string filaAsiento { get; set; }
        private int ocupado { get; set; }
        private int estado { get; set; }
    }
}
