using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Ticket
    {
        public int idTicket { get; set; }
        public int idTaquilla { get; set; }
        public int idProgramacion { get; set; }
        public int idCompra { get; set; }
        public string codigoTicket { get; set; }
        public bool estadoTicket { get; set; }
    }
}
