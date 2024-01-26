using cine_acceso_datos.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_logica_negocios
{
    public class RepartoLogica
    {
        private RepartoDAO repartoDao = new RepartoDAO();
        public Boolean InsertarReparto(Reparto nuevoReparto)
        {
            RepartoDAO.InsertarReparto(nuevoReparto);
            return true;


        }
        public DataTable Mostrar()
        {
            return repartoDao.Mostrar();
        }


    
    }
}