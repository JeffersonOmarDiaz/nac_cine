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
        public FrmReparto()
        {
            InitializeComponent();
            reparto = new Repartos();
            repartoLogica = new RepartoLogica();
        }
        private void InsertarReparto()
        {
            reparto.NombreActor = txtNombreActor.Text;
            reparto.Personaje = txtPersonaje.Text;
            reparto.Estado = 1;

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
            if (repartoLogica.ActualizarReparto(reparto))
            {
                MessageBox.Show
                ("Reparto Actualizado correctamente");

            }
            else
            {
                MessageBox.Show
              ("ERROR, Reparto no se actualizo, Contactese con soporte tecnico");
            }


        }

        private void EliminarReparto()
        {
            if (repartoLogica.EliminarReparto(reparto))
            {
                MessageBox.Show
                ("El Reparto fue eliminado satisfactoriamente");

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
    }
}
