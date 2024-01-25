using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public int idPelicula { get; set; }
        public int idProveedor { get; set; }
        public string fechaPedido { get; set; }
        public int EstadoPedido { get; set; }
        public int PedidoValor { get; set; }

        public int Estado { get; set; }
    }
}

