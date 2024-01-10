using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Cine
    {
        private int idCine { get; set; }
        private string nombre { get; set; }
        private string direccion { get; set; }
        private string horario_apertura { get; set; }
        private string horario_cierre { get; set; }
        private int estado { get; set; }
    }
}
