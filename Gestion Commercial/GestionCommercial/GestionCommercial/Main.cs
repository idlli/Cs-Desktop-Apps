using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommercial
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void gestionCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            GestionCommandes gestionCommandes = new GestionCommandes();
            gestionCommandes.MdiParent = this;
            gestionCommandes.Dock = DockStyle.Fill;
            gestionCommandes.Show();
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = false;
        }

        private void facturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            FactureForm factureForm = new FactureForm();
            factureForm.MdiParent = this;
            factureForm.Dock = DockStyle.Fill;
            factureForm.Show();
        }
    }
}
