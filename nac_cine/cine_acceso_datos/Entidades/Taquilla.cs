using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Taquilla
    {
        public int idTaquilla {  get; set; }
        public int idCine { get; set; }
        public int idUsuario { get; set; }
        public int idNumeroTaquilla { get; set; }
        public int estado { get; set; }

    }
}
