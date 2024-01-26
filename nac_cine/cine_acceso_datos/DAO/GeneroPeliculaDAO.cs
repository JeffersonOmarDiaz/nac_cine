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
    public class GeneroPeliculaDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();



        public void InsertarGeneroPelicula(PeliculaGenero nuevaPeliGenero)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_C_GeneroPelicula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_pelicula", nuevaPeliGenero.idPeliculaGenero);
            comando.Parameters.AddWithValue("@id_genero", nuevaPeliGenero.idGenero);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable MostrarGenero()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_R_PeliculasPorGenero";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void ActualizarGeneroPelicula(PeliculaGenero updatePeliculaGenero)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SP_U_PeliculaGenero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_pelicula_genero", updatePeliculaGenero.idPeliculaGenero);
            comando.Parameters.AddWithValue("@id_pelicula", updatePeliculaGenero.idPelicula);
            comando.Parameters.AddWithValue("@id_genero", updatePeliculaGenero.idGenero);
            comando.Parameters.AddWithValue("@estado", updatePeliculaGenero.estado);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarGeneroPelicula(int idPeliculaGenero)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_D_PeliculaGenero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id_pelicula_genero", idPeliculaGenero));
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
