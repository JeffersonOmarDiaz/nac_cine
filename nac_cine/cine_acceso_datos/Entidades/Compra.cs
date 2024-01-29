using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Compra
    {
        public int idCompra { get; set; }
        public int idUsuario { get; set; }
        public int cantidadCompra { get; set; }
        public decimal precioCompra { get; set; }
        public DateTime fechaCompra { get; set; }
        public int estadoCompra { get; set; }
    }
}
