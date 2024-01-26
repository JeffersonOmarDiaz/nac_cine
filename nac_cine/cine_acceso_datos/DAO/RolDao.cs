using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.DAO
{
    public class RolDao

    {
        private ConexionDB conexion = new ConexionDB();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar Rol";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarRol(Rol nuevo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insertar Rol";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idRole", nuevo.idRole);
            comando.Parameters.AddWithValue("@idUsuario", nuevo.idUsuario);
            comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
            comando.Parameters.AddWithValue("@Estado", nuevo.Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }


        public void EliminarRol (Rol idRole)
        {         
               comando.Connection= conexion.AbrirConexion();
               comando.CommandText = "Elimina rol";
               comando.CommandType = CommandType.StoredProcedure;
               comando.Parameters.Add(new SqlParameter("@idRole", idRole));
               comando.ExecuteNonQuery();
               conexion.CerrarConexion();
        }


        public void ActualizarRol(Rol acnuevo)
        {

            comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Actualiza rol";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IDRole", acnuevo.idRol);
                comando.Parameters.AddWithValue("@IdUsuario", acnuevo.idUsuario);
                comando.Parameters.AddWithValue("@Nombre",acnuevo .Nombre);
                comando.Parameters.AddWithValue("@Estado", acnuevo.Estado);                    
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            }
        }
    

    

        

    
