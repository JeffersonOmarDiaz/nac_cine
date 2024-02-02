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
    public class RolLogica
    {
        private RolDao rolDao = new RolDao();
        public Boolean InsertarRol(Role nuevo)
        {
            rolDao.InsertarRol(nuevo);
            return true;


        }
        public DataTable Mostrar()
        {
            return rolDao.Mostrar ();
        }

        public Boolean EliminarRol(Role idRol)
        {
            rolDao.EliminarRol(idRol);
            return true;
        }
        public Boolean ActualizarRol(Role acnuevo)
        {
            rolDao.ActualizarRol (acnuevo);
            return true;

        }
    }
}


   