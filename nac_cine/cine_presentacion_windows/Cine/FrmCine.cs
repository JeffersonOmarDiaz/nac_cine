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

namespace cine_presentacion_windows.Cine
{
    public partial class FrmCine : Form
    {
        private cine_acceso_datos.Entidades.Cine cine;
        private CineLogica cineLogica;
        private int idCineSelect = 0;
        public FrmCine()
        {
            InitializeComponent();
            cine = new cine_acceso_datos.Entidades.Cine();
            cineLogica = new CineLogica();
        }

        private void ListarCine()
        {
            dgvCine.DataSource = cineLogica.ListarCine();
        }
        private void InsertarCine()
        {
            cine.nombre = txtNombre.Text;
            cine.direccion = txtDireccion.Text;
            cine.horario_apertura = timeHorarioApertura.Text;
            cine.horario_cierre = timeHorarioCierre.Text;
            cine.estado = chkEstado.Checked?  1: 0;
            cineLogica.InsertarcCine(cine);
            this.ListarCine();
        }

        private void EliminarCine()
        {
            cineLogica.EliminarCine(idCineSelect);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarCine();
        }

        private void FrmCine_Load(object sender, EventArgs e)
        {
            ListarCine();
        }

        private void cargarFilaSeleccionada(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar.Visible = false;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            btnCancelar.Visible = true;

            idCineSelect = (int)dgvCine.Rows[e.RowIndex].Cells[0].Value;
            txtNombre.Text = (string)dgvCine.Rows[e.RowIndex].Cells[1].Value;
            txtDireccion.Text = (string)dgvCine.Rows[e.RowIndex].Cells[2].Value;
            timeHorarioApertura.Value = (DateTime)dgvCine.Rows[e.RowIndex].Cells[3].Value;
            timeHorarioCierre.Value = (DateTime)dgvCine.Rows[e.RowIndex].Cells[4].Value;
            chkEstado.Checked = ((Boolean)dgvCine.Rows[e.RowIndex].Cells[5].Value);
        }
        private void dgvCine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarFilaSeleccionada(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCine();
        }

        private void limpiarCampos()
        {
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = false;

            idCineSelect = 0;
            txtDireccion.Text = "";
            txtNombre.Text = "";
            chkEstado.Checked = false;
            timeHorarioApertura.Value = DateTime.Parse("10/16/2018 08:00:00");
            timeHorarioCierre.Value = DateTime.Parse("10/16/2018 22:00:00");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void actualizarCine(int idCine)
        {
            cine.nombre = txtNombre.Text;
            cine.direccion = txtDireccion.Text;
            cine.horario_apertura = timeHorarioApertura.Text;
            cine.horario_cierre = timeHorarioCierre.Text;
            cine.estado = chkEstado.Checked ? 1 : 0;
            cine.idCine = idCine;
            cineLogica.ActualizarCine(cine);
            limpiarCampos();
            ListarCine();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(idCineSelect>0)
            {
                actualizarCine(idCineSelect);
            }else
            {
                MessageBox.Show("Imposible actualizar", "Error");
            }
        }
    }
}
