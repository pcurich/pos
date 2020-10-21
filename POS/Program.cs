// using POS.Management;
using POS.Modules.Login;
using POS.Modules.Product;
using POS.Modules.Sale;
using System; 
using System.Windows.Forms;

namespace POS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmProducts());
            //Application.Run(new FrmGroups());
        }
    }
}
