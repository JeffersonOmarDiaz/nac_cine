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
    public class SalaLogica
    {
        private SalaDAO salaDAO = new SalaDAO();

        public Boolean insertarSala(Sala nuevaSala)
        {
            try
            {
                salaDAO.InsertarSala(nuevaSala);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar la sala " + error.Message);
            }


        }


        public DataTable ListarSala()
        {
            try
            {
                return salaDAO.ListarSala();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar las salas " + error.Message);
            }


        }

        public DataTable BuscarSala(string nombreSala)
        {
            try
            {
                return salaDAO.BuscarSalaNombre(nombreSala);

            }
            catch (Exception error)
            {

                throw new Exception("Error al buscar la sala por nombre " + error.Message);
            }


        }

        public Boolean ActualizarSala(Sala nuevaSala)
        {
            try
            {
                salaDAO.ActualizarSala(nuevaSala);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al Actualizar sala " + error.Message);
            }


        }

        public Boolean EliminarSala(int idSala)
        {
            try
            {
                salaDAO.EliminarSala(idSala);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar la sala " + error.Message);
            }


        }
    }
}
