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
    public class ProveedorLogica
    {
        private ProveedorDAO proveedorDAO = new ProveedorDAO();
        public Boolean InsertarProveedor(Proveedor nuevoProveedor)
        {
            proveedorDAO.InsertarProveedor(nuevoProveedor);
            return true;


        }
        public DataTable Mostrar()
        {
            return proveedorDAO.Mostrar();
        }



    }
}