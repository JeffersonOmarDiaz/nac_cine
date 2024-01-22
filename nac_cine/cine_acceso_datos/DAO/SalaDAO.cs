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
    public class SalaDAO
    {
        private ConexionBD conexionDB = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarSala(Sala nuevaSala)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "insert into SALA (ID_CINE,NOMBRE_SALA,ESTADO)" +
                                          "values("
                                          + nuevaSala.idCine + ",'"
                                          + nuevaSala.nombreSala + "',"
                                          + nuevaSala.estadoSala
                                          + ")";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede insertar la sala " + error.Message);
            }

        }

        public DataTable ListarSala()
        {

            try
            {
                DataTable dataTableSala = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from SALA";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableSala.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableSala;

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede listar las salas " + error.Message);
            }

        }

        public DataTable BuscarSalaNombre(string nombreSala)
        {

            try
            {
                DataTable dataTableSala = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from SALA where NOMBRE_SALA = '" + nombreSala + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableSala.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableSala;

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar la sala " + error.Message);
            }

        }

        public void ActualizarSala(Sala nuevaSala)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "update SALA set "
                                          + nuevaSala.idCine + ",'"
                                          + nuevaSala.nombreSala + "','"
                                          + nuevaSala.estadoSala +
                                          " where ID_SALA = " + nuevaSala.idSala + " ";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar la sala " + error.Message);
            }

        }

        public void EliminarSala(int idSala)
        {

            try
            {

                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Delete from SALA where ID_SALA = " + idSala + " ";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar la sala " + error.Message);
            }

        }


    }
}
