
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cine_logica_negocios;
using cine_acceso_datos.Entidades;
using System.Diagnostics.Eventing.Reader;


namespace cine_presentacion_windows.Rol
{
    public partial class FrmRol : Form

    {
        private Role rol;
        private RolLogica rolLogica;
        public FrmRol()
        {
            InitializeComponent();
            rol = new Role();
            rolLogica = new RolLogica();



        }
        private void InsertarRol()
        {
            rol.Nombre = txtNombre.Text;
            rol.Estado = 1;
            if (rolLogica.InsertarRol(rol))
            {
                MessageBox.Show("Rol insertado correctamente");
                Mostrar();  
            }
            else
            {
                MessageBox.Show("ERROR, Rol no insertado, Contactese con soporte tecnico");
            }
            
            
            }
        private void ActualizarRol ()
        { 
        if (rolLogica.ActualizarRol(rol))
            {
                MessageBox.Show("Rol editado correctamente");
                 
            }
            else
            {
                MessageBox.Show("ERROR, Rol se edito, Contactese con soporte tecnico");
            }
       

            }

        private void EliminarRol()
        {
            if (rolLogica.EliminarRol(rol))
            {
                MessageBox.Show("El rol fue eliminado satisfactoriamente");

            }
            else
            {
                MessageBox.Show("ERROR, Rol no eliminado, Contactese con soporte tecnico");
            }
        }
            private void Mostrar ()
        {
            dgvRol.DataSource = rolLogica.Mostrar();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarRol();  

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarRol();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           EliminarRol();
        }
    }
}


