using cine_presentacion_windows.Asiento;
using cine_presentacion_windows.Cine;
using cine_presentacion_windows.Genero;
using cine_presentacion_windows.Sala;
using cine_presentacion_windows.Pelicula;
using cine_presentacion_windows.Pedido;
using cine_presentacion_windows.Programacion;
using cine_presentacion_windows.Proveedor;
using cine_presentacion_windows.Reparto;
using cine_presentacion_windows.Rol;
using cine_presentacion_windows.Sala;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using cine_presentacion_windows.Taquilla;

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
            Application.Run(new FrmReparto());


        }
    }
}
