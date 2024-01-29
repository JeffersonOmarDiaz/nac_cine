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
    public  class CineLogica
    {
        private CineDAO cineDAO = new CineDAO();

        public Boolean insertarGenero(Cine nuevoCine)
        {
            try
            {
                cineDAO.InsertarCine(nuevoCine);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar el cine " + error.Message);
            }

        }

        public DataTable ListarCine()
        {
            try
            {
                return cineDAO.ListarCine();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar los cines " + error.Message);
            }

        }

        public Boolean ActualizarCine(Cine updateCine)
        {
            try
            {
                cineDAO.ActualizarCine(updateCine);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al Actualizar Cine" + error.Message);
            }


        }

        public Boolean EliminarCine(int IdCine)
        {
            try
            {
                cineDAO.EliminarCine(IdCine);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el cine " + error.Message);
            }


        }
    }

}
