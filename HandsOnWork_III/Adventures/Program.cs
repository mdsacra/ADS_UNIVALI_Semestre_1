using Adventures.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventures
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CadastroColaborador());
            Application.Run(new CadastroCliente());
            //Application.Run(new CadastroEmpTrans());
            //Application.Run(new CadastroPacote());
            //Application.Run(new ListaPacotes());

        }
    }
}
