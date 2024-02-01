using cine_acceso_datos;
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
    public class AsientoLogica
    {
        private AsientoDAO asientoDAO = new AsientoDAO();

        public Boolean insertarAsiento(Asiento nuevaAsiento)
        {
            try
            {
                asientoDAO.Insertarasiento(nuevaAsiento);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar el asiento " + error.Message);
            }

        }

        public DataTable ListarAsiento()
        {
            try
            {
                return asientoDAO.MostrarAsientos();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar los asientos" + error.Message);
            }

        }

        public Boolean ActualizarAsientos(Asiento updateAsiento)
        {
            try
            {
                asientoDAO.ActualizarAsiento(updateAsiento);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al Actualizar el asiento" + error.Message);
            }


        }

        public Boolean eliminarAsiento(int IdAsiento)
        {
            try
            {
                asientoDAO.EliminarAsiento(IdAsiento);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el asiento " + error.Message);
            }

        }

        public DataTable Listarsala()
        {
            try
            {
                return asientoDAO.ListarSala();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar las salas " + error.Message);
            }

        }
    }
}
