using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_logica_negocios
{
    public class TicketLogica
    {
        private TicketDAO ticketDAO = new TicketDAO();

        public Boolean InsertarTicket(Ticket nuevoTicket)
        {
            try
            {
                ticketDAO.InsertarTicket(nuevoTicket);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al insertar el ticket " + error.Message);
            }


        }


        public DataTable ListarTicket()
        {
            try
            {
                return ticketDAO.ListarTicket();

            }
            catch (Exception error)
            {

                throw new Exception("Error al listar los tickets " + error.Message);
            }


        }

        public DataTable BuscarTicket(string codigoTicket)
        {
            try
            {
                return ticketDAO.BuscarTicketCodigo(codigoTicket);

            }
            catch (Exception error)
            {

                throw new Exception("Error al buscar el ticket por codigo " + error.Message);
            }


        }

        public Boolean ActualizarTicket(Ticket nuevoTicket)
        {
            try
            {
                ticketDAO.ActualizarTicket(nuevoTicket);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al Actualizar ticket" + error.Message);
            }


        }

        public Boolean EliminarTicket(int idTicket)
        {
            try
            {
                ticketDAO.EliminarTicket(idTicket);
                return true;

            }
            catch (Exception error)
            {

                throw new Exception("Error al eliminar el ticket " + error.Message);
            }


        }
    }
}
