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
    public partial class TechSupprimer : Form
    {
        bool b;
        public TechSupprimer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update.frmTechSupprimer.Close();
            update.frmUpdate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = true;
            foreach (Conducteur t in Program.ListeTechniciens)
            {
                if (t.GetCIN() == textBox6.Text)
                {
                    Program.ListeTechniciens.Remove(t);
                    Program.GreenMessage(label7, "Suppression terminée");
                    b = false;
                    break;
                }
            }
            if (b)
                Program.RedMessage(label7, "Non supprimé");
        }
    }
}
