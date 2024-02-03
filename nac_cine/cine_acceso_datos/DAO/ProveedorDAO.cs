using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cine_acceso_datos.Entidades;

namespace cine_acceso_datos.DAO
{

    public class ProveedorDAO
    {


        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            try
            {
                DataTable dataTableproveedor = new DataTable();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select id_proveedor, nombre,direccion,email,ruc,estado from proveedor";
                leer = comando.ExecuteReader();
                dataTableproveedor.Load(leer);
                conexion.CerrarConexion();
                return dataTableproveedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede listar el proveedor " + ex.Message);
            }

        }
        public void InsertarProveedor(Proveedores nuevo)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "insert into proveedor (nombre,direccion,email,ruc,id_proveedor,estado)" +
                                    "Values( '" + nuevo.Nombre + "', '" + nuevo.direccion + "'´,'" + nuevo.email + "','" + nuevo.ruc + "', " + nuevo.idProveedor + "," + nuevo.estado + ")";

                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se puede insertar proveedor" + ex.Message);
            }

        }

        public void EliminarProveedor(Proveedores idProveedor)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "delete from proveedor where id_proveedor= " + idProveedor;


                comando.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se  eliminar proveedor " + ex.Message);
            }
        }
        public void ActualizarProveedor(Proveedores acnuevo)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE Proveedor set " +
                      "Nombre='" + acnuevo.Nombre + "'," +
                      "direccion='" + acnuevo.direccion + "'," +
                      "email='" + acnuevo.email + "'," +
                      "ruc='" + acnuevo.ruc+ "'," +
                      "estado=" + acnuevo.estado + "," +
                      "id_proveedor=" + acnuevo.idProveedor +
                    
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();


            }

            catch (Exception error)
            {

                throw new Exception("Error no se puede actualizar el proveedor " + error.Message);



            }

        }
    }
}

