using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Ticket
    {
        private int idTicket { get; set; }
        private int idTaquilla { get; set; }
        private int idProgramacion { get; set; }
        private int idCompra { get; set; }
        private string codigoTicket { get; set; }
        private bool estadoTicket { get; set; }
    }
}
