using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.DAO
{
    public class PedidoDAO
    {

        private ConexionDB conexion = new ConexionDB();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar Pedido";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarPedido(Pedido nuevo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insertar Pedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idPedido ", nuevo.idPedido);
            comando.Parameters.AddWithValue("@idPelicula", nuevo.idPelicula);
            comando.Parameters.AddWithValue("@idProveedor", nuevo.idProveedor);
            comando.Parameters.AddWithValue("@fechaPedido", nuevo.fechaPedido);
            comando.Parameters.AddWithValue("@EstadoPedido", nuevo.EstadoPedido);
            comando.Parameters.AddWithValue("@PedidoValor", nuevo.PedidoValor);
            comando.Parameters.AddWithValue("@estado", nuevo.Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void EliminarPedido(Pedido idPedido)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Elimina Pedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@idPedido", idPedido));
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void ActualizarPedido (Pedido nuevo)
        {

            comando.Parameters.AddWithValue("@idPedido ", nuevo.idPedido);
            comando.Parameters.AddWithValue("@idPelicula", nuevo.idPelicula);
            comando.Parameters.AddWithValue("@idProveedor", nuevo.idProveedor);
            comando.Parameters.AddWithValue("@fechaPedido", nuevo.fechaPedido);
            comando.Parameters.AddWithValue("@EstadoPedido", nuevo.EstadoPedido);
            comando.Parameters.AddWithValue("@PedidoValor", nuevo.PedidoValor);
            comando.Parameters.AddWithValue("@estado", nuevo.Estado);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
    }
}
