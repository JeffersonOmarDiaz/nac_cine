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
            try
            {
                DataTable dataTablepedido = new DataTable();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select id_pedido, fecha_pedido, estado_Pedido,Pedido_Valor,estado from pedido";
                leer = comando.ExecuteReader();
                dataTablepedido.Load(leer);
                conexion.CerrarConexion();
                return dataTablepedido;
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede listar el pedido " + ex.Message);
            }


        }
        public void InsertarPedido(Pedidos nuevo)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "insert into pedido (fecha_pedido, estado_Pedido,Pedido_Valor,estado, id_pelicula)" +
                                    "Values( '" + nuevo.fechaPedido + "', '" + nuevo.EstadoPedido + "', " + nuevo.PedidoValor + "," + nuevo.Estado + "'," + nuevo.idPelicula + " )";
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede insertar pedido" + ex.Message);
            }

        }

        public void EliminarPedido(Pedidos idPedido)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "delete from pedido where id_pedido= " + idPedido;

                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se  eliminar pedido " + ex.Message);
            }
        }
        public void ActualizarPedido(Pedidos acnuevo)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE pedido set " +
                      "fecha_pedido='" + acnuevo.fechaPedido + "'," +
                      "Estado_Pedido='" + acnuevo.EstadoPedido + "'," +
                      "estado=" + acnuevo.Estado + "," +
                      "id_pelicula=" + acnuevo.idPelicula +
                      "where id_pedido=" + acnuevo.idPedido;

                comando.ExecuteNonQuery();
                conexion.CerrarConexion();


            }

            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar el pedido  " + error.Message);



            }

        }
    }
}
