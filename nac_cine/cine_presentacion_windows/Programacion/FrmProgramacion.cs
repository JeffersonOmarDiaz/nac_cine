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

namespace cine_presentacion_windows.Programacion
{
    public partial class FrmProgramacion : Form
    {

        private Programaciones programacion;
        private ProgramacionLogica programacionLogica;
        private int idprogramacionselect = 0;
        public FrmProgramacion()
        {
            InitializeComponent();
            programacion = new Programaciones();
            programacionLogica = new ProgramacionLogica();
        }
        private void InsertarProgramacion()
        {
            programacion.idSala = 2;
            programacion.estreno=txtEstreno.Text;
            programacion.HoraFin=dtpHoraFin.Value;
            programacion.HoraInicio=dtpHoraInicio.Value;
            programacion.estado = chkEstado.Checked ? 1 : 0;

            if (programacionLogica.InsertarProgramacion(programacion))
            {
                MessageBox.Show("Nueva Programacion guardada correctamente");
                Mostrar();
            }
            else
            {
                MessageBox.Show("ERROR, Programacion no guardada, Contactese con soporte tecnico");
            }
        }
        private void ActualizarProgramacion()
        {
            programacion.idSala = 2;
            programacion.estreno = txtEstreno.Text;
            programacion.HoraFin = dtpHoraFin.Value;
            programacion.HoraInicio = dtpHoraInicio.Value;
            programacion.estado = chkEstado.Checked ? 1 : 0;
            programacion.idProgramacion = idprogramacionselect;

            if (programacionLogica.ActualizarProgramacion(programacion))
            {
                MessageBox.Show("Programacion Actualizada correctamente");

            }
            else
            {
                MessageBox.Show("ERROR, Programacion no se actualizo, Contactese con soporte tecnico");
            }


        }

        private void EliminarProgramacion()
        {
            if (programacionLogica.EliminarProgramacion(programacion))
            {
                MessageBox.Show
                ("El Programacion fue eliminada satisfactoriamente");
                Mostrar();
            }
            else
            {
                MessageBox.Show
                ("ERROR, Programacion no eliminada, Contactese con soporte tecnico");
            }
        }
        private void Mostrar()
        {
            dgvprogramacion.DataSource = programacionLogica.Mostrar();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarProgramacion();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarProgramacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProgramacion(); 
        }

        private void dgvprogramacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idprogramacionselect = (int)dgvprogramacion.Rows[e.RowIndex].Cells[0].Value;
        }

        private void FrmProgramacion_Load(object sender, EventArgs e)
        {
            dgvprogramacion.DataSource = programacionLogica.Mostrar();
        }
    }
}
