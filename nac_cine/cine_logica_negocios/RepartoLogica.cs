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
    public class RepartoLogica
    {
        private RepartoDAO repartoDao = new RepartoDAO();
        public Boolean InsertarReparto(Repartos nuevo)
        {
            repartoDao.InsertarReparto(nuevo);
            return true;


        }
        public DataTable Mostrar()
        {
            return repartoDao.Mostrar();
        }
        public Boolean EliminarReparto (Repartos idReparto)
        {
            repartoDao.EliminarReparto(idReparto);
            return true;
        }
        public Boolean ActualizarReparto(Repartos acnuevo)
        {
            repartoDao.ActualizarReparto(acnuevo);
            return true;

        }
        }
    }