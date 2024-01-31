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
    public class PedidoDAO
    {

        private ConexionBD conexion = new ConexionBD();
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
        public void InsertarPedido(Pedidos nuevo)
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

        public void EliminarPedido(Pedidos idPedido)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Elimina Pedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@idPedido", idPedido));
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void ActualizarPedido (Pedidos acnuevo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Actualiza Pedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idPedido ", acnuevo.idPedido);
            comando.Parameters.AddWithValue("@idPelicula", acnuevo.idPelicula);
            comando.Parameters.AddWithValue("@idProveedor", acnuevo.idProveedor);
            comando.Parameters.AddWithValue("@fechaPedido", acnuevo.fechaPedido);
            comando.Parameters.AddWithValue("@EstadoPedido", acnuevo.EstadoPedido);
            comando.Parameters.AddWithValue("@PedidoValor", acnuevo.PedidoValor);
            comando.Parameters.AddWithValue("@estado", acnuevo.Estado);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
    }
}
