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
    public class TicketDAO
    {
        private ConexionBD conexionDB = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarTicket(Ticket nuevoTicket)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "insert into TICKET (ID_TAQUILLA,ID_PROGRAMACION,ID_COMPRA,CODIGO,ESTADO)" +
                                          "values("
                                          + nuevoTicket.idTaquilla + ","
                                          + nuevoTicket.idProgramacion + ","
                                          + nuevoTicket.idCompra + ",'"
                                          + nuevoTicket.codigoTicket + "',"
                                          + nuevoTicket.estadoTicket
                                          + ")";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede insertar el ticket " + error.Message);
            }

        }

        public DataTable ListarTicket()
        {

            try
            {
                DataTable dataTableTicket = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from TICKET";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableTicket.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableTicket;

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede listar los tickets " + error.Message);
            }

        }

        public DataTable BuscarTicketCodigo(string codigoTicket)
        {

            try
            {
                DataTable dataTableTicket = new DataTable();
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Select * from TICKET where CODIGO = '" + codigoTicket + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dataTableTicket.Load(transaccion);
                conexionDB.CerrarConexion();
                return dataTableTicket;



            }
            catch (Exception error)
            {

                throw new Exception("Error al listar el ticket " + error.Message);
            }

        }

        public void ActualizarTicket(Ticket nuevoTicket)
        {

            try
            {
                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "update TICKET set "
                                          + nuevoTicket.idTaquilla + ","
                                          + nuevoTicket.idProgramacion + ","
                                          + nuevoTicket.idCompra + ",'"
                                          + nuevoTicket.codigoTicket + "','"
                                          + nuevoTicket.estadoTicket
                                          + " where ID_TICKET = " + nuevoTicket.idTicket + " ";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();

            }
            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar el ticket " + error.Message);
            }

        }

        public void EliminarTicket(int idTicket)
        {

            try
            {

                ejecutarSql.Connection = conexionDB.AbrirConexion();
                ejecutarSql.CommandText = "Delete from TICKET where ID_TICKET = " + idTicket + " ";
                ejecutarSql.ExecuteNonQuery();
                conexionDB.CerrarConexion();




            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el Ticket " + error.Message);
            }

        }



    }
}
