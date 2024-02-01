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

namespace cine_presentacion_windows.Genero
{
    public partial class FrmGenero : Form
    {
        private cine_acceso_datos.Entidades.Genero genero; 
        private GeneroLogica generoLogica;
        private int idGeneroSelected = 0;
        public FrmGenero()
        {
            InitializeComponent();
            generoLogica = new GeneroLogica();
            genero = new cine_acceso_datos.Entidades.Genero();
        }

        private void insertarGenero()
        {
            genero.nombreGenero = txtNombre.Text;
            genero.estado = chkEstado.Checked ? 1 : 0;
            generoLogica.insertarGenero(genero);
            listarGenero();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertarGenero();
            limpiarCampos();
            listarGenero();
        }

        private void listarGenero()
        {
            dgvGenero.DataSource = generoLogica.ListarGeneros();
        }
        private void FrmGenero_Load(object sender, EventArgs e)
        {
            listarGenero();
        }

        private void dgvGenero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar.Visible = false;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            btnCancelar.Visible = true;
            idGeneroSelected = (int)dgvGenero.Rows[e.RowIndex].Cells[0].Value;
            txtNombre.Text = (string)dgvGenero.Rows[e.RowIndex].Cells[1].Value;
            chkEstado.Checked = (Boolean)dgvGenero.Rows[e.RowIndex].Cells[2].Value;
        }

        private void limpiarCampos()
        {
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = false;

            idGeneroSelected = 0;
            txtNombre.Text = "";
            chkEstado.Checked = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void editarGenero()
        {
            genero.idGenero = idGeneroSelected;
            genero.nombreGenero = txtNombre.Text;
            genero.estado = chkEstado.Checked ? 1 : 0;
            generoLogica.ActualizarGenero(genero);
        }

        private void eliminarGenero()
        {
            generoLogica.Eliminargenero(idGeneroSelected);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarGenero();
            limpiarCampos();
            listarGenero();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarGenero();
            limpiarCampos();
            listarGenero();
        }
    }
}
