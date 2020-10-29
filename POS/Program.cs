// using POS.Management;
using POS.Example;
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
            //Application.Run(new FrmProducts());
            //Application.Run(new FrmGroups());
            //Application.Run(new FrmProgressBar());
            //Application.Run(new FrmCheckedListBox()); 
            //Application.Run(new FrmComboBox());
            //Application.Run(new FrmDataGridView());
            //Application.Run(new FrmDomainUpDown());
            //Application.Run(new FrmListBox());
            //Application.Run(new FrmPictureBox());
            //Application.Run(new FrmImageList()); 
            //Application.Run(new FrmListView());
            //Application.Run(new FrmColorDialog());
            //Application.Run(new FrmDateTime());
            //Application.Run(new FrmErrorProvider());
            //Application.Run(new FrmTableLayoutPanel());
            //Application.Run(new FrmHelpProvider());
            //Application.Run(new FrmMonthCalendar());
            Application.Run(new FrmFileDialog());
            //Application.Run(new ());
            //Application.Run(new ());
            //Application.Run(new ());
            //Application.Run(new ());
            //Application.Run(new ());
            //Application.Run(new ());
            //Application.Run(new ());

        }
    }
}
