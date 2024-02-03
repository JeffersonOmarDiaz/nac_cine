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

namespace cine_presentacion_windows.Reparto
{
    public partial class FrmReparto : Form
    {

        private Repartos reparto;
        private RepartoLogica repartoLogica;
        private int idrepartoselect = 0;
        public FrmReparto()
        {
            InitializeComponent();
            reparto = new Repartos();
            repartoLogica = new RepartoLogica();
        }
        private void InsertarReparto()
        {
            reparto.idPelicula = 2;
            reparto.NombreActor = txtNombreActor.Text;
            reparto.Personaje = txtPersonaje.Text;
            reparto.Estado = chkEstado.Checked ?1:0;

            if (repartoLogica.InsertarReparto(reparto))
            {
                MessageBox.Show("Nuevo Reparto guardado correctamente");
                Mostrar();
            }
            else
            {
                MessageBox.Show
               ("ERROR, Reparto no guardado, Contactese con soporte tecnico");
            }
        }
        private void ActualizarReparto()

        {
            reparto.idPelicula = 2;
            reparto.NombreActor = txtNombreActor.Text;
            reparto.Personaje = txtPersonaje.Text;
            reparto.Estado = chkEstado.Checked ? 1 : 0;
            reparto.idReparto = idrepartoselect;
            if (repartoLogica.ActualizarReparto(reparto))
            {
                MessageBox.Show
                ("Reparto Actualizado correctamente");
                Mostrar();
            }
            else
            {
                MessageBox.Show
              ("ERROR, Reparto no se actualizo, Contactese con soporte tecnico");
            }


        }

        private void EliminarReparto()
        {
            
            if (repartoLogica.EliminarReparto(idrepartoselect))
            {
                MessageBox.Show
                ("El Reparto fue eliminado satisfactoriamente");
                Mostrar();
            }
            else
            {
                MessageBox.Show
                ("ERROR, Reparto no eliminado, Contactese con soporte tecnico");
            }
        }
        private void Mostrar()
        {
            dgvReparto.DataSource = repartoLogica.Mostrar();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarReparto();  
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarReparto();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarReparto();  
        }

        private void dgvReparto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvReparto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idrepartoselect = (int)dgvReparto.Rows[e.RowIndex].Cells[0].Value;
        }

        private void FrmReparto_Load(object sender, EventArgs e)
        {
            dgvReparto.DataSource = repartoLogica.Mostrar();
        }
    }
}
