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
    public class TaquillaLogica
    {
        private TaquillaDAO taquillaDAO = new TaquillaDAO();

        public Boolean insertarTaquilla(Taquilla nuevoTaquilla)
        {
            try
            {
                taquillaDAO.InsertarTaquilla(nuevoTaquilla);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar la taquilla " + error.Message);
            }

        }

        public DataTable LstarTaquilla()
        {
            try
            {
                return taquillaDAO.ListarTaquilla();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar los generos " + error.Message);
            }

        }

        public Boolean ActualizarTaquilla(Taquilla updateTaquilla)
        {
            try
            {
                taquillaDAO.ActualizarTaquilla(updateTaquilla);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al Actualizar Taquilla" + error.Message);
            }


        }

        public Boolean eliminarTaquilla(int IdGenero)
        {
            try
            {
                taquillaDAO.EliminarTaquilla(IdGenero);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar la taquilla " + error.Message);
            }

        }


        /*para mostrar el cine*/
        public DataTable ListarCine()
        {
            try
            {
                return taquillaDAO.ListarCine();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar los cines " + error.Message);
            }

        }

        public DataTable ListarUsuario()
        {
            try
            {
                return taquillaDAO.ListarUsuario();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar los usuarios " + error.Message);
            }

        }
    }

    }
