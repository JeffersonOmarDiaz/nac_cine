using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.Entidades
{
    public class Compra
    {
        private int idCompra { get; set; }
        private int idUsuario { get; set; }
        private int cantidadCompra { get; set; }
        private decimal precioCompra { get; set; }
        private DateTime fechaCompra { get; set; }
        private bool estadoCompra { get; set; }
    }
}
