using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_logica_negocios
{
    public class CompraLogica
    {
        private CompraDAO compraDAO = new CompraDAO();

        public Boolean InsertarCompra(Compra nuevaCompra)
        {
            try
            {
                compraDAO.InsertarCompra(nuevaCompra);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar la compra " + error.Message);
            }


        }


        public DataTable ListarCompra()
        {
            try
            {
                return compraDAO.ListarCompra();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar las compras " + error.Message);
            }


        }

        public DataTable BuscarCompra(string fechaCompra)
        {
            try
            {
                return compraDAO.BuscarCompraFecha(fechaCompra);

            }
            catch (Exception error)
            {

                throw new Exception("Error al buscar el usuario por fecha " + error.Message);
            }


        }

        public Boolean ActualizarCompra(Compra nuevaCompra)
        {
            try
            {
                compraDAO.ActualizarCompra(nuevaCompra);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al Actualizar compra" + error.Message);
            }


        }

        public Boolean EliminarCompra(int idCompra)
        {
            try
            {
                compraDAO.EliminarCompra(idCompra);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar la compra " + error.Message);
            }


        }


    }
}
