using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.DAO
{
    public class UsuarioDAO
    {
        private ConexionBD conexionDB = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarUsuario(Usuario nuevoUsuario)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "insert into USUARIO (NOMBRE_USUARIO,APELLIDO_USUARIO,CEDULA_USUARIO,EMAIL_USUARIO,TELEFONO_USUARIO,EDAD,USERNAME,PASSWORD,ESTADO)" +
                                          "values('"
                                          + nuevoUsuario.nombreUsuario + "','"
                                          + nuevoUsuario.apellidoUsuario + "','"
                                          + nuevoUsuario.cedulaUsuario + "','"
                                          + nuevoUsuario.emailUsuario + "','"
                                          + nuevoUsuario.telefonoUsuario + "',"
                                          + nuevoUsuario.edadUsuario + ",'"
                                          + nuevoUsuario.usernameUsuario + "','"
                                          + nuevoUsuario.passwordUsuario + "',"
                                          + nuevoUsuario.estadoUsuario
                                          + ")";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede insertar el usuario " + error.Message);
            }

        }

        public DataTable ListarUsuario()
        {

            try
            {
                DataTable dataTableUsuario = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from USUARIO";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableUsuario.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableUsuario;



            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede listar los usuarios " + error.Message);
            }

        }

        public DataTable BuscarUsuarioCI(string CedulaUsuario)
        {

            try
            {
                DataTable dataTableUsuario = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from USUARIO where CEDULA_USUARIO = '"+ CedulaUsuario + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableUsuario.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableUsuario;



            }
            catch (Exception error)
            {

                throw new Exception("Error al listar el usuario " + error.Message);
            }

        }

        public void ActualizarUsuario(Usuario nuevoUsuario)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "update USUARIO set "
                                          + "NOMBRE_USUARIO ='" + nuevoUsuario.nombreUsuario + "','"
                                          + "APELLIDO_USUARIO ='" + nuevoUsuario.apellidoUsuario + "','"
                                          + "CEDULA_USUARIO ='" + nuevoUsuario.cedulaUsuario + "','"
                                          + "EMAIL_USUARIO ='" + nuevoUsuario.emailUsuario + "','"
                                          + "TELEFONO_USUARIO ='" + nuevoUsuario.telefonoUsuario + "',"
                                          + "EDAD ='" + nuevoUsuario.edadUsuario + ",'"
                                          + "USERNAME ='" + nuevoUsuario.usernameUsuario + "','"
                                          + "PASSWORD ='" + nuevoUsuario.passwordUsuario + "',"
                                          + "ESTADO ='" + nuevoUsuario.estadoUsuario +
                                          " where ID_USUARIO = "+nuevoUsuario.idUsuario+" "; 
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar el usuario " + error.Message);
            }

        }

        public void EliminarUsuario(int idUsuario)
        {

            try
            {
                
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Delete from USUARIO where ID_USUARIO = " + idUsuario + " ";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();
  



            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el usuario " + error.Message);
            }

        }

    }
}
