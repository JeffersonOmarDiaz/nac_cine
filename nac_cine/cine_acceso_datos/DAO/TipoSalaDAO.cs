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
    public class TipoSalaDAO
    {
        private ConexionBD conexionDB = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarTipoSala(TipoSala nuevoTipoSala)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "insert into TIPO_SALA (ID_SALA,NOMBRE_SALA,ESTADO)" +
                                          "values(" + nuevoTipoSala.idSala + ",'" + nuevoTipoSala.nombreTipoSala + "'," + nuevoTipoSala.estadoTipoSala + ")";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede insertar el tipo de sala " + error.Message);
            }

        }

        public DataTable ListarTipoSala()
        {

            try
            {
                DataTable dataTableTipoSala = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from TIPO_SALA";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableTipoSala.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableTipoSala;

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede listar los tipos de salas " + error.Message);
            }

        }

        public DataTable BuscarTipoSalaNombre(string nombreTipoSala)
        {

            try
            {
                DataTable dataTableTipoSala = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from TIPO_SALA where NOMBRE_SALA = '" + nombreTipoSala + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableTipoSala.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableTipoSala;

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar el tipo de sala " + error.Message);
            }

        }

        public void ActualizarTipoSala(TipoSala nuevoTipoSala)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "update TIPO_SALA set " + "ID_SALA ='" + nuevoTipoSala.idSala + ",'" + "NOMBRE_SALA ='" + nuevoTipoSala.nombreTipoSala + "','" + "ESTADO ='" + nuevoTipoSala.estadoTipoSala + " where ID_TIPO_SALA = " + nuevoTipoSala.idTipoSala + " ";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar el tipo de sala " + error.Message);
            }

        }

        public void EliminarTipoSala(int idTipoSala)
        {

            try
            {

                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Delete from TIPO_SALA where ID_TIPO_SALA = " + idTipoSala + " ";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el tipo de sala " + error.Message);
            }

        }

    }
}
