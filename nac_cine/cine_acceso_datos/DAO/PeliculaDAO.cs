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
    public class PeliculaDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();



        public void InsertarPelicula(Pelicula nuevaPelicula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_C_PeliculaNew";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_pelicula", nuevaPelicula.nombre);
            comando.Parameters.AddWithValue("@sinopsis", nuevaPelicula.sinopsis);
            comando.Parameters.AddWithValue("@anio_pelicula", nuevaPelicula.anio);
            comando.Parameters.AddWithValue("@trailer", nuevaPelicula.trailer);
            comando.Parameters.AddWithValue("@duracion", nuevaPelicula.duracion);
            comando.Parameters.AddWithValue("@id_genero_genero", nuevaPelicula.genero);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable MostrarPeliculas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_R_PeliculasNew";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void ActualizarPelicula(Pelicula updatePelicula)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_U_PeliculaNew";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_pelicula", updatePelicula.idPelicula);
            comando.Parameters.AddWithValue("@nombre_pelicula", updatePelicula.nombre);
            comando.Parameters.AddWithValue("@sinopsis", updatePelicula.sinopsis);
            comando.Parameters.AddWithValue("@anio_pelicula", updatePelicula.anio);
            comando.Parameters.AddWithValue("@trailer", updatePelicula.trailer);
            comando.Parameters.AddWithValue("@duracion", updatePelicula.duracion);
            comando.Parameters.AddWithValue("@idGenero", updatePelicula.genero);
            comando.Parameters.AddWithValue("@stock", updatePelicula.stock);
            comando.Parameters.AddWithValue("@estado", updatePelicula.stado);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarPelicula(int idPelicula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_D_PeliculaNew";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id_pelicula", idPelicula));
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
   