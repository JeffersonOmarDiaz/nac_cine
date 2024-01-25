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
            conexion.AbrirConexion();
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

    }
}

