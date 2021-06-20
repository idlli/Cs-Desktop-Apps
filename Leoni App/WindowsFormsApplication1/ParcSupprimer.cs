using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ParcSupprimer : Form
    {
        bool b;
        public ParcSupprimer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update.frmParcSupprimer.Close();
            update.frmUpdate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = true;
            foreach (Trans_pers p in Program.ListeParc)
            {
                if (p.Getcode() == int.Parse(textBox6.Text))
                {
                    Program.ListeParc.Remove(p);
                    Program.GreenMessage(label1, "Suppression terminée");
                    b = false;
                    break;
                }
            }
            if (b)
                Program.RedMessage(label1, "Non supprimé");
        }
    }
}
