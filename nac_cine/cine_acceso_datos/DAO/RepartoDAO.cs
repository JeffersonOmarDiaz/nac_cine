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
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar Reparto";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void InsertarReparto(Reparto nuevo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insertar Reparto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idReparto ", nuevo.idReparto);
            comando.Parameters.AddWithValue("@idPelicula", nuevo.idPelicula);
            comando.Parameters.AddWithValue("@idNombreActor", nuevo.NombreActor);
            comando.Parameters.AddWithValue("@Personaje", nuevo.Personaje);
            comando.Parameters.AddWithValue("@estado", nuevo.Estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void EliminarReparto(Reparto idReparto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Elimina Reparto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@idReparto", idReparto));
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        public void ActualizarReparto(Reparto acnuevo)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Actualiza Reparto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idReparto", acnuevo.idReparto) ;
            comando.Parameters.AddWithValue("@IdPelicula", acnuevo.idPelicula);
            comando.Parameters.AddWithValue("@NombreActor", acnuevo.NombreActor);
            comando.Parameters.AddWithValue("@Personaje",acnuevo.Personaje);        
            comando.Parameters.AddWithValue("@Estado", acnuevo.Estado);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}

