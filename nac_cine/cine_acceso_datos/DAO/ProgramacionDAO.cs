using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.DAO
{
    public class ProgramacionDAO
    {

        private ConexionDB conexion = new ConexionDB();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar Programacion";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarProgramacion(Programacion nuevo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insertar Programacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProgramacion ", nuevo.idProgramacion);
            comando.Parameters.AddWithValue("@idSala", nuevo.idSala);
            comando.Parameters.AddWithValue("@idPelicula", nuevo.idPelicula);
            comando.Parameters.AddWithValue("@idUsuario", nuevo.idUsuario);
            comando.Parameters.AddWithValue("@Horainicio", nuevo.HoraInicio);
            comando.Parameters.AddWithValue("@HoraFin", nuevo.HoraFin);
            comando.Parameters.AddWithValue("@estreno", nuevo.estreno);
            comando.Parameters.AddWithValue("@estado", nuevo.estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void EliminarProgramacion(Programacion idProgramacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Elimina Programacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@idProgramacion", idProgramacion));
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void ActualizarProgramacion(Programacion nuevo)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Actualiza Programacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProgramacion", nuevo.idProgramacion);
            comando.Parameters.AddWithValue("@idSala", nuevo.idSala);
            comando.Parameters.AddWithValue("@idPelicula", nuevo.idPelicula);
            comando.Parameters.AddWithValue("@idUsuario", nuevo.idUsuario);
            comando.Parameters.AddWithValue("@Horainicio", nuevo.HoraInicio);
            comando.Parameters.AddWithValue("@HoraFin", nuevo.HoraFin);
            comando.Parameters.AddWithValue("@estreno", nuevo.estreno);
            comando.Parameters.AddWithValue("@estado", nuevo.estado);      
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
    }
}