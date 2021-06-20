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
    public partial class MachSupprimer : Form
    {
        bool b;
        public MachSupprimer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update.frmMachSupprimer.Close();
            update.frmUpdate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = true;
            foreach (Trans_cbale m in Program.ListeMachines)
            {
                if (m.Getcode() == int.Parse(textBox6.Text))
                {
                    Program.ListeMachines.Remove(m);
                    Program.GreenMessage(label8, "Suppression terminée");
                    b = false;
                    break;
                }
            }
            if (b)
                Program.RedMessage(label8, "Non supprimé");
        }
    }
}
