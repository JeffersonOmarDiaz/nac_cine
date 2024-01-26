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
    public class GeneroDAO
    {
        private ConexionBD conexionDB = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarGenero(Genero nuevoGenero)
        {
            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "insert into GENERO (id_genero, nombre_genero, estado)" +
                                          "values('" + nuevoGenero.idGenero + "','" + nuevoGenero.nombreGenero + "','" + nuevoGenero.estado + "')";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception error)
            {
                throw new Exception("Error no se puede crear el genero " + error.Message);
            }
        }

        public DataTable ListarGenero()
        {

            try
            {
                DataTable dataTableSala = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "select * from GENERO";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableSala.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableSala;

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede listar los generos " + error.Message);
            }

        }

        public void ActualizarGenero(Genero updateGenero)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "UPDATE GENERO SET " +
                                          "nombre_genero = '" + updateGenero.nombreGenero + "', " +
                                          "estado = '" + updateGenero.estado + "' " +
                                          "WHERE id_genero = " + updateGenero.idGenero;
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar el genero " + error.Message);
            }

        }

        public void EliminarGenero(int idGenero)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Delete from GENERO WHERE id_genero = '" + idGenero;
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();
            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el genero " + error.Message);
            }

        }
    }
}
