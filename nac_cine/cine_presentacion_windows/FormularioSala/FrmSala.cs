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
    public partial class FrmSala : Form
    {
        private Sala sala;
        private CineLogica cineLogica;
        private SalaLogica salaLogica;

        public FrmSala()
        {
            InitializeComponent();
            sala = new Sala();
            cineLogica = new CineLogica();
            salaLogica = new SalaLogica(); 
        }

        private void insertarSala()
        {

            sala.idCine = Convert.ToInt32(cmbCine.SelectedValue);
            sala.nombreSala = txtNombreSala.Text.Trim();
            sala.estadoSala = 1;

            if (salaLogica.insertarSala(sala))
            {
                MessageBox.Show("Sala registrada correctamente");
                
            }
            else
            {
                MessageBox.Show("Error: Al intentar registrar una sala");
            }

        }

        private void listarSala()
        {
            dgvSala.DataSource = salaLogica.ListarSala();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarSala();
            

        }



        private void FrmSala_Load(object sender, EventArgs e)
        {
            DataTable listarNombreCines = cineLogica.ListarCine();
            cmbCine.DataSource = listarNombreCines;
            cmbCine.DisplayMember = "NOMBRE_CINE";
            cmbCine.ValueMember = "ID_CINE";
            cmbCine.BindingContext = this.BindingContext;
            listarSala();
        }

        private void dgvSala_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sala.idSala = Convert.ToInt32(this.dgvSala.SelectedRows[0].Cells[0].Value);
                sala.idCine = Convert.ToInt32(this.dgvSala.SelectedRows[0].Cells[1].Value);
                sala.nombreSala = this.dgvSala.SelectedRows[0].Cells[2].Value.ToString();
                sala.estadoSala = Convert.ToInt32(this.dgvSala.SelectedRows[0].Cells[3].Value);
                //MessageBox.Show($"idSala: {sala.idSala}\n idCine: {sala.idCine}\n nombreSala:{sala.nombreSala}\n estadoSala:{sala.estadoSala}");

                txtNombreSala.Text = sala.nombreSala;
                cmbCine.SelectedValue = sala.idCine;
                chkEstadoSala.Checked = Convert.ToBoolean(sala.estadoSala);
            }
            catch (Exception error)
            {
                
                throw new Exception("Error al seleccionar la sala " + error.Message);

            }

        }

        private void ActualizarSala()
        {

            sala.idCine = Convert.ToInt32(cmbCine.SelectedValue);
            sala.nombreSala = txtNombreSala.Text.Trim();
            sala.estadoSala = Convert.ToInt32(chkEstadoSala.Checked);

            if (salaLogica.ActualizarSala(sala))
            {
                MessageBox.Show("Sala actualizada correctamente");
                listarSala();

            }
            else
            {
                MessageBox.Show("Error: Al intentar actualizar una sala");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarSala();
        }

        private void EliminarSala()
        {


            if (salaLogica.EliminarSala(sala.idSala))
            {
                MessageBox.Show("Sala eliminada correctamente");
                listarSala();

            }
            else
            {
                MessageBox.Show("Error: Al intentar eliminar una sala");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarSala();
        }
    }
}
