using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_acceso_datos
{
    public class ConexionDB
    {
        private SqlConnection connection = new SqlConnection();

        public SqlConnection AbrirConexion()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;

        }

        public SqlConnection CerrarConexion()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;

        }
    }
}
