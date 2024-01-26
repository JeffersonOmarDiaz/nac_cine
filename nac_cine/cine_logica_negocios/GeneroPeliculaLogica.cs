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
    public class GeneroPeliculaLogica
    {
        private GeneroPeliculaDAO genPeliDAO = new GeneroPeliculaDAO();

        public Boolean insertarGeneroPelicula(PeliculaGenero nuevoGenPeli)
        {
            try
            {
                genPeliDAO.InsertarGeneroPelicula(nuevoGenPeli);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar la taquilla " + error.Message);
            }

        }

        public DataTable ListaGeneroPelicula()
        {
            try
            {
                return genPeliDAO.MostrarGenero();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar los generos de pelicula" + error.Message);
            }

        }

        public Boolean ActualizarGeneroPelicula(PeliculaGenero updatePeliGen)
        {
            try
            {
                genPeliDAO.ActualizarGeneroPelicula(updatePeliGen);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al Actualizar Genero de pelicula" + error.Message);
            }


        }

        public Boolean eliminarGeneroPelicula(int IdGeneroPeli)
        {
            try
            {
                genPeliDAO.EliminarGeneroPelicula(IdGeneroPeli);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el genero de pelicula " + error.Message);
            }

        }
    }
}
