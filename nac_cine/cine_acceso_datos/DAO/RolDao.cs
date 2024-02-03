using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cine_acceso_datos.Entidades;

namespace cine_acceso_datos.DAO
{
    public class RolDao

    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            try
            {
                DataTable dataTableSala = new DataTable();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select id_role, nombre, id_usuario,estado from rol";
                leer = comando.ExecuteReader();
                dataTableSala.Load(leer);
                conexion.CerrarConexion();
                return dataTableSala;
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede listar el rol " + ex.Message);
            }

        }
        public void InsertarRol(Role nuevo)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "insert into rol (nombre,, id_usuario,estado)" +
                                    "Values( '" + nuevo.Nombre + "', " + nuevo.idUsuario + "," + nuevo.Estado + ")";

                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede insertar roles " + ex.Message);
            }
        }


        public void EliminarRol(Role idRole)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "delete from Rol where id_rol= " + idRole;
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede eliminar " + ex.Message);
            }

        }
        public void ActualizarRol(Role acnuevo)
        {
            try
            {

                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE Rol set " +
                       "Nombre='" + acnuevo.Nombre + "'," +
                      "estado=" + acnuevo.Estado + "," +
                       "id_Usuario=" + acnuevo.idUsuario +
                       "where id_rol=" + acnuevo.idRole;
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar rol " + error.Message);
            }
        }
    }
}
    

    

        

    
