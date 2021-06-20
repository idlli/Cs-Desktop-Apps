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
    public partial class NfrmAccueil : Form
    {
        public NfrmAccueil()
        {
            InitializeComponent();
            sAccueil = this;
        }
        public static NfrmAccueil sAccueil;
        public static NfrmFactoriel sFactoriel;
        public static NfrmJeux sJeux;
        public static NfrmTableau sTableau;
        private void BtnHover(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.DeepSkyBlue;
        }

        private void BtnLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Gray;
        }

        private void BtnFactorielClick(object sender, EventArgs e)
        {
            sFactoriel = new NfrmFactoriel();
            sFactoriel.Show();
            sAccueil.Hide();
        }

        private void BtnNotesClick(object sender, EventArgs e)
        {
            sTableau = new NfrmTableau();
            sTableau.Show();
            sAccueil.Hide();
        }

        private void BtnJouerClick(object sender, EventArgs e)
        {
            sJeux = new NfrmJeux();
            sJeux.Show();
            sAccueil.Hide();
        }

        private void BtnQuitterClick(object sender, EventArgs e)
        {
            sAccueil.Close();
            LeChoix.sLeChoix.Show();
        }
    }
}
