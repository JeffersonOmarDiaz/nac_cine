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
    public class CineDAO
    {
        private ConexionBD conexionDB = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarCine(Cine nuevoCine)
    {
        try
        {
            ejecutarSql.Connection = conexionDB.AbrirConexion();
            ejecutarSql.CommandText = "insert into USUARIO (id_cine, nombre_cine, direccion_cine, horario_apertura, horario_cierre, estado)" +
                                      "values ('" + nuevoCine.idCine + "','" + nuevoCine.nombre + "','" + nuevoCine.direccion + "','" + 
                                      nuevoCine.horario_apertura + "','" + nuevoCine.horario_cierre + "'," + nuevoCine.horario_cierre + "')";
            ejecutarSql.ExecuteNonQuery();
            conexionDB.CerrarConexion();
        }
        catch (Exception error)
        {
                throw new Exception("Error no se puede crear el cine " + error.Message);
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

                throw new Exception("Error no se puede listar los cines " + error.Message);
            }

        }

        public void ActualizarCine(Cine updatecine)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE CINE SET " +
                                          "nombre_cine = '" + updatecine.nombre + "', " +
                                          "direccion_cine = '" + updatecine.direccion + "', " +
                                          "horario_apertura = '" + updatecine.horario_apertura + "', " +
                                          "horario_cierre = '" + updatecine.horario_cierre + "', " +
                                          "ESTADO = '" + updatecine.estado + "' " +
                                          "WHERE id_cine = " + updatecine.idCine;
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar el cine " + error.Message);
            }

        }

        public void EliminarCine(int idCine)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Delete from cine WHERE id_cine = " + idCine;
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el cine " + error.Message);
            }

        }
    }
}
