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

namespace cine_presentacion_windows.FormularioSala
{
    public partial class FrmTipoSala : Form
    {
        private TipoSala tipoSala;
        private TipoSalaLogica tipoSalaLogica;
        private SalaLogica salaLogica;
       
        public FrmTipoSala()
        {
            InitializeComponent();
            tipoSala = new TipoSala();
            tipoSalaLogica = new TipoSalaLogica();
            salaLogica = new SalaLogica();
        }

        private void FrmTipoSala_Load(object sender, EventArgs e)
        {
            DataTable listarNombreTipoSala = salaLogica.ListarSala();
            cmbSala.DataSource = listarNombreTipoSala;
            cmbSala.DisplayMember = "NOMBRE_SALA";
            cmbSala.ValueMember = "ID_SALA";
            cmbSala.BindingContext = this.BindingContext;
            LimpiarTipoSala();
            ListarTipoSala();
        }

        private void InsertarTipoSala()
        {

            tipoSala.idSala = Convert.ToInt32(cmbSala.SelectedValue);
            tipoSala.nombreTipoSala = txtNombreTipoSala.Text.Trim();
            tipoSala.estadoTipoSala = 1;

            if (tipoSalaLogica.InsertarTipoSala(tipoSala))
            {
                MessageBox.Show("Tipo de Sala registrado correctamente");
                ListarTipoSala();

            }
            else
            {
                MessageBox.Show("Error: Al intentar registrar un tipo de sala");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarTipoSala();
            LimpiarTipoSala();
        }

        private void LimpiarTipoSala()
        {
            cmbSala.SelectedIndex = -1;
            txtNombreTipoSala.Clear();
            chkEstadoTipoSala.Checked = false;

        }

        private void ListarTipoSala()
        {
            dgvTipoSala.DataSource = tipoSalaLogica.ListarTipoSala();
        }

        private void dgvTipoSala_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tipoSala.idTipoSala = Convert.ToInt32(this.dgvTipoSala.SelectedRows[0].Cells[0].Value);
                tipoSala.idSala = Convert.ToInt32(this.dgvTipoSala.SelectedRows[0].Cells[1].Value);
                tipoSala.nombreTipoSala = this.dgvTipoSala.SelectedRows[0].Cells[2].Value.ToString();
                tipoSala.estadoTipoSala = Convert.ToInt32(this.dgvTipoSala.SelectedRows[0].Cells[3].Value);
                //MessageBox.Show($"idSala: {sala.idSala}\n idCine: {sala.idCine}\n nombreSala:{sala.nombreSala}\n estadoSala:{sala.estadoSala}");

                cmbSala.SelectedValue = tipoSala.idSala;
                txtNombreTipoSala.Text = tipoSala.nombreTipoSala;
                chkEstadoTipoSala.Checked = Convert.ToBoolean(tipoSala.estadoTipoSala);
            }
            catch (Exception error)
            {

                throw new Exception("Error al seleccionar el tipo de sala " + error.Message);

            }
        }

        private void ActualizarTipoSala()
        {

            tipoSala.idSala = Convert.ToInt32(cmbSala.SelectedValue);
            tipoSala.nombreTipoSala = txtNombreTipoSala.Text.Trim();
            tipoSala.estadoTipoSala = Convert.ToInt32(chkEstadoTipoSala.Checked);

            if (tipoSalaLogica.ActualizarTipoSala(tipoSala))
            {
                MessageBox.Show("Tipo de Sala actualizado correctamente");
                ListarTipoSala();

            }
            else
            {
                MessageBox.Show("Error: Al intentar actualizar el tipo de sala");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarTipoSala();
            LimpiarTipoSala();
        }

        private void EliminarTipoSala()
        {


            if (tipoSalaLogica.EliminarTipoSala(tipoSala.idTipoSala))
            {
                MessageBox.Show("Tipo de Sala eliminado correctamente");
                ListarTipoSala();

            }
            else
            {
                MessageBox.Show("Error: Al intentar eliminar el tipo de sala");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarTipoSala();
            LimpiarTipoSala();
        }
    }
}
