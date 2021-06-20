using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passage_2012
{
    static class Program
    {
        public static List<Inscription> Dossier = new List<Inscription>();
        public static int Rechercher(int numDossier)
        {
            foreach (Inscription d in Dossier)
            {
                if (d.GetnumDossier() == numDossier)
                    return Dossier.IndexOf(d);
            }
            return -1;
        }
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
