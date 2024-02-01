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

namespace cine_presentacion_windows.Asiento
{
    public partial class FrmAsiento : Form
    {

        private cine_acceso_datos.Entidades.Asiento asiento;
        private AsientoLogica asientoLogica;
        private int idAsientoSelec;
        public FrmAsiento()
        {
            InitializeComponent();
            asientoLogica = new AsientoLogica();
            asiento = new cine_acceso_datos.Entidades.Asiento();
            idAsientoSelec = 0;
        }

        private void FrmAsiento_Load(object sender, EventArgs e)
        {
            listarSalas();
            listarAsientos();
        }

        private void listarSalas()
        {
            DataTable dt = new DataTable();
            dt = asientoLogica.Listarsala();

            cmbSala.Items.Add("Seleccione" );

            cmbSala.DataSource = dt;
            cmbSala.DisplayMember = "nombre_sala";
            cmbSala.ValueMember = "id_sala";
        }

        private void listarAsientos()
        {
            dgvAsiento.DataSource = asientoLogica.ListarAsiento();
        }

        private void nuevoAsiento()
        {
            asiento.filaAsiento = txtFilaAsiento.Text;
            asiento.numeroAsiento = txtNumeroAsiento.Text;
            asiento.idSala = (int)cmbSala.SelectedValue;
            asiento.estado = chkEstado.Checked ? 1 : 0;
            asiento.ocupado = chkOcupado.Checked ? 1 : 0;
            asientoLogica.insertarAsiento(asiento);
            listarAsientos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nuevoAsiento();
        }

        private void limpiarCampos()
        {
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = false;

            idAsientoSelec = 0;
            txtFilaAsiento.Text = "";
            txtNumeroAsiento.Text = "";
            chkOcupado.Checked = false;
            chkEstado.Checked = false;
            
        }
        private void actualizarAsiento()
        {
            asiento.filaAsiento = txtFilaAsiento.Text;
            asiento.numeroAsiento = txtNumeroAsiento.Text;
            asiento.idSala = (int)cmbSala.SelectedValue;
            asiento.estado = chkEstado.Checked ? 1 : 0;
            asiento.ocupado = chkOcupado.Checked ? 1 : 0;
            asiento.idAsiento = idAsientoSelec;
            asientoLogica.ActualizarAsientos(asiento);
            limpiarCampos();

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            actualizarAsiento();
            //listarAsientos();
        }
        private void cargarFilaSeleccionada(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar.Visible = false;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            btnCancelar.Visible = true;

            idAsientoSelec = (int)dgvAsiento.Rows[e.RowIndex].Cells[0].Value;
            txtNumeroAsiento.Text = (string)dgvAsiento.Rows[e.RowIndex].Cells[2].Value;
            txtFilaAsiento.Text = (string)dgvAsiento.Rows[e.RowIndex].Cells[3].Value;
            string valLoc = Convert.ToString((Int32)dgvAsiento.Rows[e.RowIndex].Cells[1].Value);

            cmbSala.SelectedValue = valLoc;
            chkOcupado.Checked = ((Boolean)dgvAsiento.Rows[e.RowIndex].Cells[4].Value);
            chkEstado.Checked = ((Boolean)dgvAsiento.Rows[e.RowIndex].Cells[5].Value);
        }

        private void dgvAsiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarFilaSeleccionada(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void eliminarAsiento(int id)
        {
            asientoLogica.eliminarAsiento(id);
            limpiarCampos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarAsiento(idAsientoSelec); 
        }
    }
}
