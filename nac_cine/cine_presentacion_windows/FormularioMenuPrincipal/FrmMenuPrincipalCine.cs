using cine_presentacion_windows.FormularioCompra;
using cine_presentacion_windows.FormularioSala;
using cine_presentacion_windows.FormularioTicket;
using cine_presentacion_windows.FormularioUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine_presentacion_windows.FormularioMenuPrincipal
{
    public partial class FrmMenuPrincipalCine : Form
    {
        public FrmMenuPrincipalCine()
        {
            InitializeComponent();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioCompra = new FrmCompra();
            formularioCompra.Show();
        }

        private void salaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formularioSala = new FrmSala();
            formularioSala.Show();
        }

        private void tipoSalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formularioTipoSala = new FrmTipoSala();
            formularioTipoSala.Show();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioTicket = new FrmTicket();
            formularioTicket.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioUsuario = new FrmUsuario();
            formularioUsuario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
