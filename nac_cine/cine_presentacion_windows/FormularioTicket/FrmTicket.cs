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

namespace cine_presentacion_windows.FormularioTicket
{
    public partial class FrmTicket : Form
    {
        private Ticket ticket;
        private TicketLogica ticketLogica;
        private TaquillaLogica taquillaLogica;
        private ProgramacionLogica programacionLogica;
        private CompraLogica compraLogica;
        public FrmTicket()
        {
            InitializeComponent();
            ticket = new Ticket();
            ticketLogica = new TicketLogica();
            taquillaLogica = new TaquillaLogica();
            programacionLogica = new ProgramacionLogica();
            compraLogica = new CompraLogica();
        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {
            DataTable listarNombreTaquilla = taquillaLogica.ListarTaquilla();
            cmbTaquilla.DataSource = listarNombreTaquilla;
            cmbTaquilla.DisplayMember = "ID_TAQUILLA";
            cmbTaquilla.ValueMember = "ID_TAQUILLA";
            cmbTaquilla.BindingContext = this.BindingContext;

            DataTable listarNombreProgramacion = programacionLogica.ListarProgramacion();
            cmbProgramacion.DataSource = listarNombreProgramacion;
            cmbProgramacion.DisplayMember = "ID_PROGRAMACION";
            cmbProgramacion.ValueMember = "ID_PROGRAMACION";
            cmbProgramacion.BindingContext = this.BindingContext;

            DataTable listarNombreCompra = compraLogica.ListarCompra();
            cmbCompra.DataSource = listarNombreCompra;
            cmbCompra.DisplayMember = "ID_COMPRA";
            cmbCompra.ValueMember = "ID_COMPRA";
            cmbCompra.BindingContext = this.BindingContext;


            ListarTicket();

        }

        private void InsertarTicket()
        {

            ticket.idTaquilla = Convert.ToInt32(cmbTaquilla.SelectedValue);
            ticket.idProgramacion = Convert.ToInt32(cmbProgramacion.SelectedValue);
            ticket.idCompra = Convert.ToInt32(cmbCompra.SelectedValue);
            ticket.codigoTicket = txtCodigo.Text.Trim();
            ticket.estadoTicket = 1;

            if (ticketLogica.InsertarTicket(ticket))
            {
                MessageBox.Show("Ticket registrado correctamente");
                ListarTicket();

            }
            else
            {
                MessageBox.Show("Error: Al intentar registrar su ticket");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarTicket();
            LimpiarTicket();
        }


        private void LimpiarTicket()
        {
            cmbTaquilla.SelectedIndex = 0;
            cmbProgramacion.SelectedIndex = 0;
            cmbCompra.SelectedIndex = 0;
            txtCodigo.Clear();
            chkEstadoTicket.Checked = false;

        }

        private void ListarTicket()
        {
            dgvTicket.DataSource = ticketLogica.ListarTicket();
        }

        private void dgvTicket_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ticket.idTicket = Convert.ToInt32(this.dgvTicket.SelectedRows[0].Cells[0].Value);
                ticket.idTaquilla = Convert.ToInt32(this.dgvTicket.SelectedRows[0].Cells[1].Value);
                ticket.idProgramacion = Convert.ToInt32(this.dgvTicket.SelectedRows[0].Cells[2].Value);
                ticket.idCompra = Convert.ToInt32(this.dgvTicket.SelectedRows[0].Cells[3].Value);
                ticket.codigoTicket = this.dgvTicket.SelectedRows[0].Cells[4].Value.ToString();
                ticket.estadoTicket = Convert.ToInt32(this.dgvTicket.SelectedRows[0].Cells[5].Value);
                //MessageBox.Show($"idSala: {sala.idSala}\n idCine: {sala.idCine}\n nombreSala:{sala.nombreSala}\n estadoSala:{sala.estadoSala}");

                cmbTaquilla.SelectedValue = ticket.idTaquilla;
                cmbProgramacion.SelectedValue = ticket.idProgramacion;
                cmbCompra.SelectedValue = ticket.idCompra;
                txtCodigo.Text = ticket.codigoTicket;
                chkEstadoTicket.Checked = Convert.ToBoolean(ticket.estadoTicket);
            }
            catch (Exception error)
            {

                throw new Exception("Error al seleccionar el ticket " + error.Message);

            }
        }

        private void ActualizarTicket()
        {

            ticket.idTaquilla = Convert.ToInt32(cmbTaquilla.SelectedValue);
            ticket.idProgramacion = Convert.ToInt32(cmbProgramacion.SelectedValue);
            ticket.idCompra = Convert.ToInt32(cmbCompra.SelectedValue);
            ticket.codigoTicket = txtCodigo.Text.Trim();
            ticket.estadoTicket = Convert.ToInt32(chkEstadoTicket.Checked); ;

            if (ticketLogica.ActualizarTicket(ticket))
            {
                MessageBox.Show("Ticket actualizado correctamente");
                ListarTicket();

            }
            else
            {
                MessageBox.Show("Error: Al intentar actualizar su ticket");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarTicket();
            LimpiarTicket();

        }

        private void EliminarTicket()
        {


            if (ticketLogica.EliminarTicket(ticket.idTicket))
            {
                MessageBox.Show("Ticket eliminado correctamente");
                ListarTicket();

            }
            else
            {
                MessageBox.Show("Error: Al intentar eliminar el ticket");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarTicket();
            LimpiarTicket();
        }
    }
}
