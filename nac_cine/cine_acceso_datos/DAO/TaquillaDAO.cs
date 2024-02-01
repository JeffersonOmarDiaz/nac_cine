using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.DAO
{
    public class TaquillaDAO
    {
        private ConexionBD conexionDB = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarTaquilla(Taquilla nuevaTaquilla)
        {
            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "insert into taquilla ( id_cine, id_usuario, numero_taquilla,  estado)" +
                                          "values (" + nuevaTaquilla.idCine + "," +
                                          nuevaTaquilla.idUsuario + "," + nuevaTaquilla.idNumeroTaquilla + "," + nuevaTaquilla.estado + ")";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception error)
            {
                throw new Exception("Error no se puede crear la taquilla " + error.Message);
            }
        }

        public DataTable ListarTaquilla()
        {

            try
            {
                DataTable dataTableSala = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "select id_taquilla, id_cine, id_usuario, numero_taquilla, estado from taquilla";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableSala.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableSala;

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede listar las taquillas " + error.Message);
            }

        }

        public DataTable ListarCine()
        {

            try
            {
                DataTable dataTableSala = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "select * from cine";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableSala.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableSala;

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede listar las taquillas " + error.Message);
            }

        }

        public DataTable ListarUsuario()
        {

            try
            {
                DataTable dataTableUsuario = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select concat(NOMBRE_USUARIO, apellido_usuario) as nombre, id_usuario from USUARIO";
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

        public void ActualizarTaquilla(Taquilla updateTaquilla)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE TAQUILLA SET " +
                                          "id_cine = '" + updateTaquilla.idCine + "', " +
                                          "id_usuario = '" + updateTaquilla.idUsuario + "', " +
                                          "numero_taquilla = '" + updateTaquilla.idNumeroTaquilla + "', " +
                                          "ESTADO = '" + updateTaquilla.estado + "' " +
                                          "WHERE id_taquilla = " + updateTaquilla.idTaquilla;
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar la taquilla " + error.Message);
            }

        }

        public void EliminarTaquilla(int idTaquilla)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Delete from TAQUILLA WHERE id_taquilla = " + idTaquilla;
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar la taquilla " + error.Message);
            }

        }
    }
}
