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

namespace cine_presentacion_windows.FormularioUsuario
{
    public partial class FrmUsuario : Form
    {
        private Usuario usuario;
        private UsuarioLogica usuarioLogica;

        public FrmUsuario()
        {
            InitializeComponent();
            usuario = new Usuario();
            usuarioLogica = new UsuarioLogica();    
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ListarUsuario();
        }

        private void InsertarUsuario()
        {


            usuario.nombreUsuario = txtNombre.Text.Trim();
            usuario.apellidoUsuario = txtApellido.Text.Trim();
            usuario.cedulaUsuario = txtCedula.Text.Trim();
            usuario.emailUsuario = txtEmail.Text.Trim();
            usuario.telefonoUsuario = txtTelefono.Text.Trim();
            usuario.edadUsuario = Convert.ToInt32(txtEdad.Text.Trim());
            usuario.usernameUsuario = txtUsername.Text.Trim();
            usuario.passwordUsuario = txtPassword.Text.Trim();
            usuario.estadoUsuario = 1;

            if (usuarioLogica.insertarUsuario(usuario))
            {
                MessageBox.Show("Usuario registrado correctamente");
                ListarUsuario();

            }
            else
            {
                MessageBox.Show("Error: Al intentar registrar el usuario");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarUsuario();
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            chkEstadoUsuario.Checked = false;

        }

        private void ListarUsuario()
        {
            dgvUsuario.DataSource = usuarioLogica.ListarUsuarioSoloDatos();
        }


        private void dgvUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                usuario.idUsuario = Convert.ToInt32(this.dgvUsuario.SelectedRows[0].Cells[0].Value);
                usuario.nombreUsuario = this.dgvUsuario.SelectedRows[0].Cells[1].Value.ToString();
                usuario.apellidoUsuario = this.dgvUsuario.SelectedRows[0].Cells[2].Value.ToString();
                usuario.cedulaUsuario = this.dgvUsuario.SelectedRows[0].Cells[3].Value.ToString();
                usuario.emailUsuario = this.dgvUsuario.SelectedRows[0].Cells[4].Value.ToString();
                usuario.telefonoUsuario = this.dgvUsuario.SelectedRows[0].Cells[5].Value.ToString();
                usuario.edadUsuario = Convert.ToInt32(this.dgvUsuario.SelectedRows[0].Cells[6].Value);
                usuario.usernameUsuario = this.dgvUsuario.SelectedRows[0].Cells[7].Value.ToString();
                usuario.passwordUsuario = this.dgvUsuario.SelectedRows[0].Cells[8].Value.ToString();
                usuario.estadoUsuario = Convert.ToInt32(this.dgvUsuario.SelectedRows[0].Cells[9].Value);
                /*MessageBox.Show($"idUsuario: {usuario.idUsuario}\n " +
                    $"nombreUsuario: {usuario.nombreUsuario}\n " +
                    $"apellidoUsuario:{usuario.apellidoUsuario}\n " +
                    $"cedulaUsuario:{usuario.cedulaUsuario}\n " +
                    $"emailUsuario:{usuario.emailUsuario}\n " +
                    $"telefonoUsuario:{usuario.telefonoUsuario}\n " +
                    $"edadUsuario:{usuario.edadUsuario}\n " +
                    $"usernameUsuario:{usuario.usernameUsuario}\n " +
                    $"passwordUsuario:{usuario.passwordUsuario}\n " +
                    $"estadoUsuario:{usuario.estadoUsuario}");*/


                txtNombre.Text = usuario.nombreUsuario;
                txtApellido.Text = usuario.apellidoUsuario;
                txtCedula.Text = usuario.cedulaUsuario;
                txtEmail.Text = usuario.emailUsuario;
                txtTelefono.Text = usuario.telefonoUsuario;
                txtEdad.Text = usuario.edadUsuario.ToString();
                txtUsername.Text = usuario.usernameUsuario;
                txtPassword.Text = usuario.passwordUsuario;
                chkEstadoUsuario.Checked = Convert.ToBoolean(usuario.estadoUsuario);
            }
            catch (Exception error)
            {

                throw new Exception("Error al seleccionar el usuario " + error.Message);

            }

        }

        private void ActualizarUsuario()
        {


            usuario.nombreUsuario = txtNombre.Text.Trim();
            usuario.apellidoUsuario = txtApellido.Text.Trim();
            usuario.cedulaUsuario = txtCedula.Text.Trim();
            usuario.emailUsuario = txtEmail.Text.Trim();
            usuario.telefonoUsuario = txtTelefono.Text.Trim();
            usuario.edadUsuario = Convert.ToInt32(txtEdad.Text.Trim());
            usuario.usernameUsuario = txtUsername.Text.Trim();
            usuario.passwordUsuario = txtPassword.Text.Trim();
            usuario.estadoUsuario = Convert.ToInt32(chkEstadoUsuario.Checked); ;

            if (usuarioLogica.ActualizarUsuario(usuario))
            {
                MessageBox.Show("Usuario actualizado correctamente");
                ListarUsuario();

            }
            else
            {
                MessageBox.Show("Error: Al intentar actualizar el usuario");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
            Limpiar();
        }

        private void EliminarUsuario()
        {


            if (usuarioLogica.EliminarUsuario(usuario.idUsuario))
            {
                MessageBox.Show("Usuario eliminado correctamente");
                ListarUsuario();

            }
            else
            {
                MessageBox.Show("Error: Al intentar eliminar el usuario");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           EliminarUsuario();
           Limpiar();
        }
    }
}
