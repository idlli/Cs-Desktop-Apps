using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommercial
{
    internal static class g
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static DataClasses1DataContext dc = new DataClasses1DataContext();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
