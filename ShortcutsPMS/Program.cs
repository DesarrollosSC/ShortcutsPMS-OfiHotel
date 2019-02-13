using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics; //aixo ho faig servir per comprovar que l'aplicació no estigui executanse 

namespace ShortcutsPMS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool enEjucacion;

            enEjucacion = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (enEjucacion == false)
            {
                Application.Run(new Form1());
            }
        }
    }
}
