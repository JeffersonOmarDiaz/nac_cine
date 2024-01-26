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
    public class PeliculaLogica
    {
        private PeliculaDAO peliculaDAO = new PeliculaDAO();

        public Boolean insertarPelicula(Pelicula nuevaPelicula)
        {
            try
            {
                peliculaDAO.InsertarPelicula(nuevaPelicula);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar la pelicula " + error.Message);
            }

        }

        public DataTable ListaGeneroPelicula()
        {
            try
            {
                return peliculaDAO.MostrarPeliculas();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar las peliculas" + error.Message);
            }

        }

        public Boolean ActualizarGeneroPelicula(Pelicula updatePelicula)
        {
            try
            {
                peliculaDAO.ActualizarPelicula(updatePelicula);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al Actualizar la pelicula" + error.Message);
            }


        }

        public Boolean eliminarPelicula(int IdPelicula)
        {
            try
            {
                peliculaDAO.EliminarPelicula(IdPelicula);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar la pelicula " + error.Message);
            }

        }
    }
}
