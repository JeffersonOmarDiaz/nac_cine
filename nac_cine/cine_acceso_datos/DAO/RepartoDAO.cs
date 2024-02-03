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
    public class RepartoDAO
    {

        private ConexionBD conexion = new ConexionBD();
        //DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;

        public DataTable Mostrar()
        {
            try
            {
             DataTable dataTableSala = new DataTable();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select id_reparto, nombre_actor, personaje, id_pelicula,estado from reparto" ;
                leer = comando.ExecuteReader();
                dataTableSala.Load(leer);
                conexion.CerrarConexion();
                return dataTableSala;
            }catch (Exception ex)
            {
                throw new Exception("Error no se puede listar las taquillas " + ex.Message);
            }

        }
        public void InsertarReparto(Repartos nuevo)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "insert into reparto (nombre_actor, personaje, id_pelicula,estado)" +
                                    "Values( '" + nuevo.NombreActor + "', '" + nuevo.Personaje + "', " + nuevo.idPelicula + "," + nuevo.Estado + ")";


                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede listar las taquillas " + ex.Message);
            }

        }
        public void EliminarReparto(int idReparto)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "delete from Reparto where id_reparto= " + idReparto;
                //comando.CommandText="UPDATE Reparto set " +
                //      "estado=" + 0  +
                //      "where id_reparto=" + idReparto;

                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede listar las taquillas " + ex.Message);
            }


        }


        public void ActualizarReparto(Repartos acnuevo)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE Reparto set " +
                      "Nombre_actor='" + acnuevo.NombreActor + "'," +
                      "personaje='" + acnuevo.Personaje + "'," +
                      "estado=" + acnuevo.Estado + "," +
                      "id_pelicula=" + acnuevo.idPelicula +
                      "where id_reparto=" + acnuevo.idReparto;
               
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();


            }

            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar la taquilla " + error.Message);
           
            
            
            }
           
        }
    }
}

