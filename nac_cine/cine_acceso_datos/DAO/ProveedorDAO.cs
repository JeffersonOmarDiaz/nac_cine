using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.DAO
{

    public class ProveedorDAO
    {


        private ConexionDB conexion = new ConexionDB();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar Proveedor";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarProveedor(Proveedor nuevo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insertar Proveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor ", nuevo.idProveedor);
            comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
            comando.Parameters.AddWithValue("@direccion", nuevo.direccion);
            comando.Parameters.AddWithValue("@email", nuevo.email);
            comando.Parameters.AddWithValue("@ruc", nuevo.ruc);
            comando.Parameters.AddWithValue("@estado", nuevo.estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();


        }

        public void EliminarProveedor(Proveedor idProveedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Elimina Proveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@idProveedor", idProveedor));
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void ActualizarProveedor(Proveedor acnuevo)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Actualiza Proveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", acnuevo.idProveedor));
            comando.Parameters.AddWithValue("@Nombre", acnuevo.idNombre);
            comando.Parameters.AddWithValue("@direccion", acnuevo.direccion);
            comando.Parameters.AddWithValue("@email",acnuevo.email);
            comando.Parameters.AddWithValue("@ruc", acnuevo.ruc);
            comando.Parameters.AddWithValue("@estado", acnuevo.estado);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}

