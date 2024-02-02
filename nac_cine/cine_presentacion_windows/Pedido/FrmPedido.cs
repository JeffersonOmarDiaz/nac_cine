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

namespace cine_presentacion_windows.Pedido
{
    public partial class FrmPedido : Form
    {
        private Pedidos pedido;
        private PedidoLogica pedidoLogica;
        public FrmPedido()
        {
            InitializeComponent();
            pedido = new Pedidos();
            pedidoLogica = new PedidoLogica();
        }
        private void InsertarPedido()
        {
            pedido.fechaPedido = dtpFechaPedido.Value;
            pedido.EstadoPedido = chkEstadoPedido.Checked;
            pedido.PedidoValor = txtPedidoValor.Text;
            pedido.Estado = 1;

            if (pedidoLogica.InsertarPedido(pedido))
            {
                MessageBox.Show("Nuevo Pedido guardado correctamente");
                Mostrar();
            }
            else
            {
                MessageBox.Show
               ("ERROR, Pedido no guardado, Contactese con soporte tecnico");
            }
        }
        private void ActualizarPedido()
        {
            if (pedidoLogica.ActualizarPedido(pedido))
            {
                MessageBox.Show
                ("Pedido Actualizado correctamente");

            }
            else
            {
                MessageBox.Show
              ("ERROR, Pedido no se actualizo, Contactese con soporte tecnico");
            }


        }

        private void EliminarPedido()
        {
            if (pedidoLogica.EliminarPedido(pedido))
            {
                MessageBox.Show
                ("El Pedido fue eliminado satisfactoriamente");

            }
            else
            {
                MessageBox.Show
                ("ERROR, Pedido no eliminado, Contactese con soporte tecnico");
            }
        }
        private void Mostrar()
        {
            dgvpedido. DataSource = pedidoLogica.Mostrar();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarPedido();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarPedido();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPedido();   
        }
    }
}

