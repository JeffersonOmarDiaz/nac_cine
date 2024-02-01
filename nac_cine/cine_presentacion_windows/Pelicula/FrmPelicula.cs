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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cine_presentacion_windows.Pelicula
{
    public partial class FrmPelicula : Form
    {
        private cine_acceso_datos.Entidades.Pelicula pelicula;
        private PeliculaLogica peliculaLogica;
        private GeneroLogica generoLogica;
        private int idPeliculaSelect;
        public FrmPelicula()
        {
            InitializeComponent();
            pelicula = new cine_acceso_datos.Entidades.Pelicula();
            peliculaLogica = new PeliculaLogica();
            generoLogica = new GeneroLogica();
            idPeliculaSelect = 0;
        }

        private void FrmPelicula_Load(object sender, EventArgs e)
        {
            listarAnio();
            listarGeneroPelicula();
            listarPeliculas();
        }

        private void listarAnio()
        {
            cmbAnio.DataSource = Enumerable.Range(1950, DateTime.Now.Year - 1949).ToList();
            cmbAnio.SelectedItem = DateTime.Now.Year;

        }

        private void agregarPelicula()
        {
            pelicula.nombre = txtNombre.Text;
            pelicula.sinopsis = txtSinopsis.Text;
            pelicula.anio = (int)cmbAnio.SelectedItem;
            pelicula.trailer = txtTrailer.Text;
            pelicula.duracion = timeDuracion.Text;
            pelicula.stock = chkStock.Checked ? 1 : 0;
            pelicula.stado = chkEstado.Checked ? 1 : 0;
            pelicula.genero = (int)cmbGenero.SelectedValue;
            peliculaLogica.insertarPelicula(pelicula);
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            btnGuardar.Visible = true;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = false;

            txtNombre.Text = "";
            txtSinopsis.Text = "";
            txtTrailer.Text = "";
            cmbAnio.SelectedItem = DateTime.Now.Year;
            cmbGenero.SelectedIndex = 1;
            timeDuracion.Value = DateTime.Parse("10/16/2018 01:00:00");
            chkStock.Checked = false;
            chkEstado.Checked = false;
            idPeliculaSelect = 0;

        }

        private void listarGeneroPelicula()
        {
            DataTable dt = new DataTable();
            dt = generoLogica.ListarGeneros();


            cmbGenero.DataSource = dt;
            cmbGenero.DisplayMember = "nombre_genero";
            cmbGenero.ValueMember = "id_genero";
        }

        private void listarPeliculas()
        {
            dgvPeliculas.DataSource = peliculaLogica.ListaGeneroPelicula();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregarPelicula();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void dgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarPeliculaSeleccionada(sender,e);
        }

        private void cargarPeliculaSeleccionada(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar.Visible = false;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;
            btnCancelar.Visible = true;

            idPeliculaSelect = (int)dgvPeliculas.Rows[e.RowIndex].Cells[0].Value;
            txtNombre.Text = (string)dgvPeliculas.Rows[e.RowIndex].Cells[1].Value;
            txtSinopsis.Text = (string)dgvPeliculas.Rows[e.RowIndex].Cells[2].Value;
            txtTrailer.Text = (string)dgvPeliculas.Rows[e.RowIndex].Cells[3].Value;
            cmbAnio.SelectedItem = (int)dgvPeliculas.Rows[e.RowIndex].Cells[5].Value;
            timeDuracion.Value = (DateTime)dgvPeliculas.Rows[e.RowIndex].Cells[6].Value;
            chkStock.Checked = ((Boolean)dgvPeliculas.Rows[e.RowIndex].Cells[7].Value);
            chkEstado.Checked = ((Boolean)dgvPeliculas.Rows[e.RowIndex].Cells[8].Value);
            string valLoc = Convert.ToString((Int32)dgvPeliculas.Rows[e.RowIndex].Cells[9].Value);
            cmbGenero.SelectedValue = valLoc;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pelicula.idPelicula = idPeliculaSelect;
            pelicula.nombre = txtNombre.Text;
            pelicula.sinopsis = txtSinopsis.Text;
            pelicula.anio = (int)cmbAnio.SelectedItem;
            pelicula.trailer = txtTrailer.Text;
            pelicula.duracion = timeDuracion.Text;
            pelicula.stock = chkStock.Checked ? 1 : 0;
            pelicula.stado = chkEstado.Checked ? 1 : 0;
            pelicula.genero = (int)cmbGenero.SelectedValue;
            peliculaLogica.ActualizarGeneroPelicula(pelicula);
            limpiarCampos();
            //listarPeliculas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            peliculaLogica.eliminarPelicula(idPeliculaSelect);
            limpiarCampos();
            //listarPeliculas();
        }
    }
}
