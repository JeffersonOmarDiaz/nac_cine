using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Pedidos
    {
        public int idPedido { get; set; }
        public int idPelicula { get; set; }
        public int idProveedor { get; set; }
        public DateTime fechaPedido { get; set; }
        public bool EstadoPedido { get; set; }
        public string PedidoValor { get; set; }

        public int Estado { get; set; }
    }
}

