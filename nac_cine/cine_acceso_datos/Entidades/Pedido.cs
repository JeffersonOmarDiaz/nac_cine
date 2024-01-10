using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Pedido
    {
        private int idPedido { get; set; }
        private int idPelicula { get; set; }
        private int idProveedor { get; set; }
        private string fechaPedido { get; set; }
        private int EstadoPedido { get; set; }
        private int PedidoValor { get; set; }

        private int Estado { get; set; }
    }
}

