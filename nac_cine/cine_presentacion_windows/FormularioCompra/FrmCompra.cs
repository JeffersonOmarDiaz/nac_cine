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

namespace cine_presentacion_windows.FormularioCompra
{
    public partial class FrmCompra : Form
    {
        private Compra compra;
        private CompraLogica compraLogica;
        private UsuarioLogica usuarioLogica;
        public FrmCompra()
        {
            InitializeComponent();
            compra = new Compra();
            compraLogica = new CompraLogica();
            usuarioLogica = new UsuarioLogica();
        }
        private void insertarCompra()
        {

            compra.idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            compra.cantidadCompra = Convert.ToInt32(txtCantidad.Text.Trim());
            compra.precioCompra = Convert.ToDecimal(txtPrecio.Text.Trim());
            compra.fechaCompra = dtpFecha.Value;
            compra.estadoCompra= 1;

            if (compraLogica.InsertarCompra(compra))
            {
                MessageBox.Show("Compra registrada correctamente");
                listarCompra();

            }
            else
            {
                MessageBox.Show("Error: Al intentar registrar una compra");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarCompra();
            LimpiarCompra();
        }

        private void LimpiarCompra()
        {
            cmbUsuario.SelectedIndex = -1;
            txtCantidad.Clear();
            txtPrecio.Clear();
            dtpFecha.Value = DateTime.Now;
            chkEstado.Checked = false;

        }

        private void listarCompra()
        {
            dgvCompra.DataSource = compraLogica.ListarCompra();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            DataTable listarNombreCompra = usuarioLogica.ListarUsuario();
            cmbUsuario.DataSource = listarNombreCompra;
            cmbUsuario.DisplayMember = "usuariocompleto";
            cmbUsuario.ValueMember = "ID_USUARIO";
            cmbUsuario.BindingContext = this.BindingContext;
            LimpiarCompra();
            listarCompra();
        }

        private void dgvCompra_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                compra.idCompra = Convert.ToInt32(this.dgvCompra.SelectedRows[0].Cells[0].Value);
                compra.idUsuario = Convert.ToInt32(this.dgvCompra.SelectedRows[0].Cells[1].Value);
                compra.cantidadCompra = Convert.ToInt32(this.dgvCompra.SelectedRows[0].Cells[2].Value);
                compra.precioCompra = Convert.ToDecimal(this.dgvCompra.SelectedRows[0].Cells[3].Value);
                compra.fechaCompra = Convert.ToDateTime(this.dgvCompra.SelectedRows[0].Cells[4].Value);
                compra.estadoCompra = Convert.ToInt32(this.dgvCompra.SelectedRows[0].Cells[5].Value);
                /*MessageBox.Show($"idCompra: {compra.idCompra}\n" +
                    $" idUsuario: {compra.idUsuario}\n " +
                    $"cantidadCompra:{compra.cantidadCompra}\n " +
                    $"precioCompra:{compra.precioCompra}\n " +
                    $"fechaCompra:{compra.fechaCompra}\n " +
                    $"estadoCompra:{compra.estadoCompra}");*/

                cmbUsuario.SelectedValue = compra.idUsuario;
                txtCantidad.Text = Convert.ToString(compra.cantidadCompra);
                txtPrecio.Text = Convert.ToString(compra.precioCompra);
                dtpFecha.Value = compra.fechaCompra;
                chkEstado.Checked = Convert.ToBoolean(compra.estadoCompra);
            }
            catch (Exception error)
            {

                throw new Exception("Error al seleccionar la compra " + error.Message);

            }
        }

        private void ActualizarCompra()
        {

            compra.idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            compra.cantidadCompra = Convert.ToInt32(txtCantidad.Text.Trim());
            compra.precioCompra = Convert.ToDecimal(txtPrecio.Text.Trim());
            compra.fechaCompra = dtpFecha.Value;
            compra.estadoCompra = Convert.ToInt32(chkEstado.Checked);

            if (compraLogica.ActualizarCompra(compra))
            {
                MessageBox.Show("Compra actualizada correctamente");
                listarCompra();

            }
            else
            {
                MessageBox.Show("Error: Al intentar actualizar una compra");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarCompra();
            LimpiarCompra();
        }

        private void EliminarCompra()
        {


            if (compraLogica.EliminarCompra(compra.idCompra))
            {
                MessageBox.Show("Compra eliminada correctamente");
                listarCompra();

            }
            else
            {
                MessageBox.Show("Error: Al intentar eliminar una compra");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCompra();
            LimpiarCompra();
        }
    }
}
