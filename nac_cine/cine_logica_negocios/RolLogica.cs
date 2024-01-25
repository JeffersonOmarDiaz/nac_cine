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
        public Boolean InsertarRol(Rol nuevoRol)
        {
            rolDao.InsertarRol(nuevoRol);
            return true;


        }
        public DataTable Mostrar()
        {
            return rolDao.Mostrar();
        }



    }
}