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
    public class GeneroLogica
    {
        private GeneroDAO generoLogicaDOA = new GeneroDAO();

        public Boolean insertarGenero(Genero nuevoGenero)
        {
            try
            {
                generoLogicaDOA.InsertarGenero(nuevoGenero);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar el genero " + error.Message);
            }

        }

        public DataTable ListarGeneros()
        {
            try
            {
                return generoLogicaDOA.ListarGenero();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar los generos " + error.Message);
            }

        }

        public Boolean ActualizarGenero(Genero updateGenero)
        {
            try
            {
                generoLogicaDOA.ActualizarGenero(updateGenero);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al Actualizar Genero" + error.Message);
            }


        }

        public Boolean Eliminargenero(int IdGenero)
        {
            try
            {
                generoLogicaDOA.EliminarGenero(IdGenero);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el genero " + error.Message);
            }


        }
    }


}
