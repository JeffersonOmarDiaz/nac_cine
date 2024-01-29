using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class TipoSala
    {
        public int idTipoSala { get; set; }
        public int idSala { get; set; }
        public string nombreTipoSala { get; set; }
        public int estadoTipoSala { get; set; }
    }
}
