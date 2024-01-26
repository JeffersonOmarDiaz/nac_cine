using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos.DAO
{
    public class RepartoDAO
    {

        private ConexionDB conexion = new ConexionDB();
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
            conexion.AbrirConexion();
            return tabla;

        }
        public void InsertarReparto(Reparto nuevo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insertar Reparto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idReparto ", nuevo.idReparto);
            comando.Parameters.AddWithValue("@idPelicula", nuevo.idPelicula);
            comando.Parameters.AddWithValue("@idNombreActor", nuevo.idNombreActor);
            comando.Parameters.AddWithValue("@idPersonaje", nuevo.idEstado);         
            comando.Parameters.AddWithValue("@estado", nuevo.estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

    }
}
