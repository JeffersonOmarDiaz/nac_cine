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
    public class UsuarioLogica
    {
        private UsuarioDAO usuarioDAO= new UsuarioDAO();

        public Boolean insertarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                usuarioDAO.InsertarUsuario(nuevoUsuario);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar el usuario " + error.Message);
            }
           

        }


        public DataTable ListarUsuario()
        {
            try
            {
                return usuarioDAO.ListarUsuario();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar los usuarios " + error.Message);
            }


        }

        public DataTable BuscarUsuario(string CedulaUsuario)
        {
            try
            {
                return usuarioDAO.BuscarUsuarioCI(CedulaUsuario);

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar el usuario por CI " + error.Message);
            }


        }

        public Boolean ActualizarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                usuarioDAO.ActualizarUsuario(nuevoUsuario);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar el usuario por CI " + error.Message);
            }


        }

        public Boolean EliminarUsuario(int idUsuario)
        {
            try
            {
                usuarioDAO.EliminarUsuario(idUsuario);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el usuario " + error.Message);
            }


        }



    }
}
