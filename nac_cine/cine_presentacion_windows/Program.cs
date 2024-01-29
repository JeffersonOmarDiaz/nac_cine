﻿using cine_presentacion_windows.FormularioCompra;
using cine_presentacion_windows.FormularioSala;
using cine_presentacion_windows.FormularioTicket;
using cine_presentacion_windows.FormularioUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cine_presentacion_windows
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmTipoSala());
        }
    }
}
