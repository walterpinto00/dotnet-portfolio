using ClienteApp.Datos;
using ClienteApp.Negocio;

namespace ClienteApp.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmClientes());
        }
    }
}
