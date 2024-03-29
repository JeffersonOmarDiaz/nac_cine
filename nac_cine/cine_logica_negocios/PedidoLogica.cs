﻿using cine_acceso_datos.DAO;
using cine_acceso_datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cine_logica_negocios
{
    public class PedidoLogica
    {
        private PedidoDAO pedidoDAO = new PedidoDAO();
        public Boolean InsertarPedido(Pedidos nuevo)
        {
            pedidoDAO.InsertarPedido(nuevo);
            return true;


        }
        public DataTable Mostrar()
        {
            return pedidoDAO.Mostrar();
        }

        public Boolean EliminarPedido(Pedidos idPedido)
        {
            pedidoDAO.EliminarPedido(idPedido);
            return true;
        }
                public Boolean ActualizarPedido(Pedidos acnuevo)
                {
                    pedidoDAO.ActualizarPedido(acnuevo);
                    return true;

                }
            }
        }


