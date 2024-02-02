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

namespace cine_presentacion_windows.Taquilla
{
    public partial class FrmTaquilla : Form
    {
        private cine_acceso_datos.Entidades.Taquilla taquilla;
        private TaquillaLogica taquillaLogica;
        private int idTaquillaSelect;
        public FrmTaquilla()
        {
            InitializeComponent();
            taquilla = new cine_acceso_datos.Entidades.Taquilla();
            taquillaLogica = new TaquillaLogica();
            idTaquillaSelect = 0;
        }

        private void FrmTaquilla_Load(object sender, EventArgs e)
        {
            listarTaquilla();
            listarCine();
            listarUsuario();

        }

        private void listarUsuario()
        {
            DataTable dt = new DataTable();
            dt = taquillaLogica.ListarUsuario();
            cmbUsuario.DataSource = dt;
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.ValueMember = "id_usuario";
        }
        private void listarCine()
        {
            DataTable dt = new DataTable();
            dt = taquillaLogica.ListarCine();


            cmbCine.DataSource = dt;
            cmbCine.DisplayMember = "nombre_cine";
            cmbCine.ValueMember = "id_cine";
        }
        private void listarTaquilla()
        {
            dgvTaquilla.DataSource = taquillaLogica.LstarTaquilla();
        }

        private void insertarTaquilla()
        {
            taquilla.idNumeroTaquilla = Convert.ToInt32(txtNumTaquilla.Text);
            taquilla.idCine = Convert.ToInt32(cmbCine.SelectedValue);
            taquilla.idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            taquilla.estado = chkEstado.Checked ? 1 : 0;
            taquillaLogica.insertarTaquilla(taquilla);
            listarTaquilla();
            limpiarCampos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarTaquilla();
        }

        private void limpiarCampos()
        {
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = false;

            idTaquillaSelect = 0;
            txtNumTaquilla.Text = "";
            cmbCine.SelectedIndex = 0;
            cmbUsuario.SelectedIndex = 0;
            chkEstado.Checked = false;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cargarFilaSelect(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar.Visible = false;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            btnCancelar.Visible = true;

            idTaquillaSelect = (int)dgvTaquilla.Rows[e.RowIndex].Cells[0].Value;
            string valLocCine = Convert.ToString((Int32)dgvTaquilla.Rows[e.RowIndex].Cells[1].Value);
            string valLocUser = Convert.ToString((Int32)dgvTaquilla.Rows[e.RowIndex].Cells[2].Value);

            cmbCine.SelectedValue = valLocCine;
            cmbUsuario.SelectedValue = valLocUser;
            chkEstado.Checked = ((Boolean)dgvTaquilla.Rows[e.RowIndex].Cells[4].Value);
            txtNumTaquilla.Text = Convert.ToString((Int32)dgvTaquilla.Rows[e.RowIndex].Cells[3].Value);
        }
        private void dgvTaquilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarFilaSelect(sender, e);
        }

        private void actualizarTaquilla(object sender, EventArgs e)
        {
            taquilla.idTaquilla = idTaquillaSelect;
            taquilla.idNumeroTaquilla = Convert.ToInt32(txtNumTaquilla.Text);
            taquilla.idCine = Convert.ToInt32(cmbCine.SelectedValue);
            taquilla.idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            taquilla.estado = chkEstado.Checked ? 1 : 0;
            taquillaLogica.ActualizarTaquilla(taquilla);
            listarTaquilla();
            limpiarCampos();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            actualizarTaquilla(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            taquillaLogica.eliminarTaquilla(idTaquillaSelect);
            listarTaquilla();
            limpiarCampos();
        }
    }
}
