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
    public class TipoSalaLogica
    {
        private TipoSalaDAO TipoSalaDAO = new TipoSalaDAO();

        public Boolean InsertarTipoSala(TipoSala nuevoTipoSala)
        {
            try
            {
                TipoSalaDAO.InsertarTipoSala(nuevoTipoSala);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar el tipo de sala " + error.Message);
            }


        }


        public DataTable ListarTipoSala()
        {
            try
            {
                return TipoSalaDAO.ListarTipoSala();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar los tipos de salas " + error.Message);
            }


        }

        public DataTable BuscarTipoSala(string nombreTipoSala)
        {
            try
            {
                return TipoSalaDAO.BuscarTipoSalaNombre(nombreTipoSala);

            }
            catch (Exception error)
            {

                throw new Exception("Error al buscar el tipo de sala por nombre " + error.Message);
            }


        }

        public Boolean ActualizarTipoSala(TipoSala nuevoTipoSala)
        {
            try
            {
                TipoSalaDAO.ActualizarTipoSala(nuevoTipoSala);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al Actualizar el tipo de sala " + error.Message);
            }


        }

        public Boolean EliminarTipoSala(int idTipoSala)
        {
            try
            {
                TipoSalaDAO.EliminarTipoSala(idTipoSala);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el tipo de sala " + error.Message);
            }


        }

    }
}
