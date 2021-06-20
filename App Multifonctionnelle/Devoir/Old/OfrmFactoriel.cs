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
    public partial class OfrmFactoriel : Form
    {
        public OfrmFactoriel()
        {
            InitializeComponent();
        }

        private void TxtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '0')
                e.Handled = false;
            else
                e.Handled = true;
        }
        int f;
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            f = int.Parse(TxtN.Text);
            if (TxtN.Text != "")
            {
                for (int i = int.Parse(TxtN.Text)-1; i > 0; i -= 1)
                {
                    f *= i;
                }
                LblRes.Text = $"Factoriel ( {int.Parse(TxtN.Text)} ) = {f}";
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            OfrmAccueil.frmAccueil.Close();
            LeChoix.sLeChoix.Show();
        }
    }
}
