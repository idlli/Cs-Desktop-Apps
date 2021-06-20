using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    static class Program
    {
        //static public int i, code;
        //static public bool b;
        //static public decimal prix;
        //static public DateTime date;
        static public List<Conducteur> ListeTechniciens = new List<Conducteur>();
        static public List<Trans_pers> ListeParc = new List<Trans_pers>();
        static public List<Trans_cbale> ListeMachines = new List<Trans_cbale>();
        public static Regex Cin = new Regex(@"^[a-zA-Z]{2}[0-9]{4,6}$");
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new update());
        }
        public static void RedMessage(Label lb, string st)
        {
            lb.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            lb.Text = st;
        }
        public static void GreenMessage(Label lb, string st)
        {
            lb.ForeColor = System.Drawing.Color.FromArgb(99, 110, 114);
            lb.Text = st;
        }
        public static void TextEnable(TextBox[] tb, bool b)
        {
            foreach(TextBox t in tb)
            {
                t.Enabled = b;
            }
        }
        public static void LabelColor(Label[] lb, System.Drawing.Color cl)
        {
            foreach (Label l in lb)
            {
                l.ForeColor = cl;
            }
        }
        public static void TextClear(TextBox[] tb)
        {
            foreach (TextBox t in tb)
            {
                t.Clear();
            }
        }
        public static void PastTech(ComboBox c)
        {
            foreach (Conducteur t in ListeTechniciens)
            {
                c.Items.Add("T : [" + t.GetCIN() + "]");
            }
        }
        public static void ReSearch(ComboBox c)
        {
            c.Items.Clear();
            c.Select(c.Text.Length, 0);
            foreach (Conducteur t in ListeTechniciens)
            {
                if (t.GetCIN().Contains(c.Text))
                {
                    c.Items.Add("T : [" + t.GetCIN() + "]");
                }
            }
        }
    }
}
