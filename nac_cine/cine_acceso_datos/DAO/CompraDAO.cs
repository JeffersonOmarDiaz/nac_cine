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
    public class CompraDAO
    {
        private ConexionBD conexionDB = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarCompra(Compra nuevaCompra)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "insert into COMPRA (ID_USUARIO,CANTIDAD,PRECIO,FECHA_COMPRA,ESTADO)" +
                                          "values(" + nuevaCompra.idUsuario + "," + nuevaCompra.cantidadCompra + "," + nuevaCompra.precioCompra + ",'" + nuevaCompra.fechaCompra + "'," + nuevaCompra.estadoCompra + ")";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede insertar la compra " + error.Message);
            }

        }

        public DataTable ListarCompra()
        {

            try
            {
                DataTable dataTableCompra = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from COMPRA";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableCompra.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableCompra;

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede listar las compras " + error.Message);
            }

        }

        public DataTable BuscarCompraFecha(string fechaCompra)
        {

            try
            {
                DataTable dataTableCompra = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from COMPRA where FECHA_COMPRA = '" + fechaCompra + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableCompra.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableCompra;



            }
            catch (Exception error)
            {

                throw new Exception("Error al listar la compra " + error.Message);
            }

        }

        public void ActualizarCompra(Compra nuevaCompra)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "update COMPRA set " + "ID_USUARIO ='" + nuevaCompra.idUsuario + "," + "CANTIDAD ='" + nuevaCompra.cantidadCompra + "," + "PRECIO ='" + nuevaCompra.precioCompra + ",'" + "FECHA_COMPRA ='" + nuevaCompra.fechaCompra + "'," + "ESTADO ='" + nuevaCompra.estadoCompra + " where ID_COMPRA = " + nuevaCompra.idCompra + " ";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar la compra " + error.Message);
            }

        }

        public void EliminarCompra(int idCompra)
        {

            try
            {

                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Delete from COMPRA where ID_COMPRA = " + idCompra + " ";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar la compra " + error.Message);
            }

        }


    }
}
