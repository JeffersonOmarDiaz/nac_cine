using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Cine
    {
        public int idCine { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string horario_apertura { get; set; }
        public string horario_cierre { get; set; }
        public int estado { get; set; }
    }
}
