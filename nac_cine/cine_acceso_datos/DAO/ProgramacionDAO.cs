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
    public class ProgramacionDAO
    {

        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            try
            {
                DataTable dataTableprogramacion = new DataTable();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select id_proveedor, hora_inicio,hora_fin,estreno,estado from programacion";
                leer = comando.ExecuteReader();
                dataTableprogramacion.Load(leer);
                conexion.CerrarConexion();
                return dataTableprogramacion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede listar la programacion " + ex.Message);
            }

        }
        public void InsertarProgramacion(Programaciones nuevo)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "insert into programacion (Hora_inicio,hora_fin,estreno,estado)" +
                                    "Values( '" + nuevo.HoraInicio+ "', '" + nuevo.HoraFin + "', '" + nuevo.estreno + "'," + nuevo.estado + ")";
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede insertar programacion" + ex.Message);
            }

        }
        public void EliminarProgramacion(Programaciones idProgramacion)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "delete from programacion where id_proveedor= " + idProgramacion;
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se  eliminar programacion " + ex.Message);
            }


        }
        public void ActualizarProgramacion(Programaciones acnuevo)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE programacion set " +
                      "Hora_inicio='" + acnuevo.HoraInicio + "'," +
                      "Hora_fin='" + acnuevo.HoraFin + "'," +
                      "estado=" + acnuevo.estado + "," +
                      "estreno=" + acnuevo.estreno + "," +
                      "id_pelicula=" + acnuevo.idPelicula +
                      "where id_programacion=" + acnuevo.idProgramacion;

                comando.ExecuteNonQuery();
                conexion.CerrarConexion();


            }

            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar el programacion  " + error.Message);



            }

        }
    }
    }
}