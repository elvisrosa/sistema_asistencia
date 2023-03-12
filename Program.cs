using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Asistencia_Personal
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vistas.TomarAsistencia());
            //Application.Run(new Vistas.MenuPrincipal());

            //Vistas.TomarAsistencia form = new Vistas.TomarAsistencia();
            //form.FormClosed += Form_FormClosed;

            //form.ShowDialog();
            //Application.Run();
        }

        /*private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.ExitThread();
            //Application.Exit();
        }
        */
    }
}
