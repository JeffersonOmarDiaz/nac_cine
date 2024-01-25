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
        public Boolean InsertarProgramacion(Programacion nuevoProgramacion)
        {
            programacionDAO.InsertarProgramacion(nuevoProgramacion);
            return true;


        }
        public DataTable Mostrar()
        {
            return programacionDAO.Mostrar();
        }





    }
}