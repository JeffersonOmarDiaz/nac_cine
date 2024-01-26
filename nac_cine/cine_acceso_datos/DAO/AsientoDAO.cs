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
    internal class AsientoDAO
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();



        public void Insertarasiento(Asiento nuevoAsiento)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_C_Asiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_sala", nuevoAsiento.idSala);
            comando.Parameters.AddWithValue("@numero", nuevoAsiento.numeroAsiento);
            comando.Parameters.AddWithValue("@fila", nuevoAsiento.filaAsiento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable MostrarAsientos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_R_asientos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void ActualizarAsiento(Asiento updateAsiento)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_U_Asiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_asiento", updateAsiento.idAsiento);
            comando.Parameters.AddWithValue("@id_sala", updateAsiento.idSala);
            comando.Parameters.AddWithValue("@numero_asiento", updateAsiento.numeroAsiento);
            comando.Parameters.AddWithValue("@fila_asiento", updateAsiento.filaAsiento);
            comando.Parameters.AddWithValue("@ocupado", updateAsiento.ocupado);
            comando.Parameters.AddWithValue("@estado", updateAsiento.estado);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarAsiento(int idPelicula)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_D_Asiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id_asiento", idPelicula));
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
