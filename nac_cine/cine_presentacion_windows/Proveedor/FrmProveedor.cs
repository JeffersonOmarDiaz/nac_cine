using cine_acceso_datos.Entidades;
using cine_logica_negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine_presentacion_windows.Proveedor
{
    public partial class FrmProveedor : Form
    {
        private Proveedores proveedor;
        private ProveedorLogica proveedorLogica;
        private int idproveedorselect = 0;
        public FrmProveedor()
        {
            InitializeComponent();
            proveedor = new Proveedores();
            proveedorLogica = new ProveedorLogica();
        }
        private void InsertarProveedor()
        {
            proveedor.Nombre = txtNombre.Text;
            proveedor.direccion=txtDireccion.Text;
            proveedor.ruc=txtRuc.Text;
            proveedor.email=txtEmail.Text;
            proveedor.estado = chkEstado.Checked ? 1 : 0;

            if (proveedorLogica.InsertarProveedor(proveedor))
            {
                MessageBox.Show("Proveedor guardado correctamente");
                Mostrar();
            }
            else
            {
                MessageBox.Show("ERROR, Proveedor no guardado, Contactese con soporte tecnico");
            }
        }
        private void ActualizarProveedor()
        {
            proveedor.Nombre = txtNombre.Text;
            proveedor.direccion = txtDireccion.Text;
            proveedor.ruc = txtRuc.Text;
            proveedor.email = txtEmail.Text;
            proveedor.estado = chkEstado.Checked ? 1 : 0;
            proveedor.idProveedor = idproveedorselect;

            if (proveedorLogica.ActualizarProveedor(proveedor))
            {
                MessageBox.Show("Proveedor Actualizado correctamente");
                Mostrar();
            }
            else
            {
                MessageBox.Show("ERROR, Proveedor no se actualizo, Contactese con soporte tecnico");
            }


        }

        private void EliminarProveedor()
        {
            if (proveedorLogica.EliminarProveedor(proveedor))
            {
                MessageBox.Show
                ("El Proveedor fue eliminado satisfactoriamente");
                Mostrar();
            }
            else
            {
                MessageBox.Show
                ("ERROR, Proveedor no eliminado, Contactese con soporte tecnico");
            }
        }
        private void Mostrar()
        {
            dgvProveedor.DataSource = proveedorLogica.Mostrar();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarProveedor();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarProveedor();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedor();    
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idproveedorselect = (int)dgvProveedor.Rows[e.RowIndex].Cells[0].Value;
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

            dgvProveedor.DataSource = proveedorLogica.Mostrar();
        }
    }
}
