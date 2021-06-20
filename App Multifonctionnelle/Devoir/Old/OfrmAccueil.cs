using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devoir
{
    public partial class OfrmAccueil : Form
    {
        public OfrmAccueil()
        {
            InitializeComponent();
        }
        public static OfrmAccueil frmAccueil;
        OfrmFactoriel frmFactoriel;
        OfrmTableau frmTableau;
        OfrmJeux frmJeux;
        private void BtnFactoriel_Click(object sender, EventArgs e)
        {
            frmFactoriel = new OfrmFactoriel();
            frmFactoriel.Show();
        }

        private void BtnTab_Click(object sender, EventArgs e)
        {
            frmTableau = new OfrmTableau();
            frmTableau.Show();
        }

        private void BtnJouer_Click(object sender, EventArgs e)
        {
            frmJeux = new OfrmJeux();
            frmJeux.Show();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            LeChoix.sLeChoix.Show();
        }
    }
}
