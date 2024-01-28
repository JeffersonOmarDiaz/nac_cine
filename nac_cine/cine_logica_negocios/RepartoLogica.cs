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
        public Boolean InsertarReparto(Reparto nuevo)
        {
            repartoDao.InsertarReparto(nuevo);
            return true;


        }
        public DataTable Mostrar()
        {
            return repartoDao.Mostrar();
        }
        public Boolean EliminarReparto (Reparto idReparto)
        {
            repartoDao.EliminarReparto(idReparto);
            return true;
        }
        public Boolean ActualizarReparto(Reparto acnuevo)
        {
            repartoDao.ActualizarReparto(acnuevo);
            return true;

        }
        }
    }