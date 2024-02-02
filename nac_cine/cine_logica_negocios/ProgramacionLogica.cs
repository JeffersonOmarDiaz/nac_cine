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
    public class ProgramacionLogica
    {
        private ProgramacionDAO programacionDAO = new ProgramacionDAO();
        public Boolean InsertarProgramacion(Programaciones nuevo)
        {
            programacionDAO.InsertarProgramacion(nuevo);
            return true;


        }
        public DataTable Mostrar()
        {
            return programacionDAO.Mostrar();
        }
        public Boolean EliminarProgramacion(Programaciones idPedido)
        {
            programacionDAO.EliminarProgramacion(idPedido);
            return true;
        }
        public Boolean ActualizarProgramacion(Programaciones acnuevo)
        {
            programacionDAO.ActualizarProgramacion(acnuevo);
            return true;

        }
    }
}

