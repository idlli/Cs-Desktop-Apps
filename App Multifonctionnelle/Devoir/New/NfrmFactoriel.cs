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
    public partial class NfrmFactoriel : Form
    {
        public NfrmFactoriel()
        {
            InitializeComponent();
        }
        int f;
        public void FactorielCalc(int n)
        {
            f = n;
            for (int i = n - 1; i > 1; i -= 1)
            {
                f *= i;
                
            }
            label1.Text = $"Factoriel ( {n} ) = {f}";
        }

        private void NfrmFactoriel_Load(object sender, EventArgs e)
        {
            this.ActiveControl = panel1;
        }

        private void TextEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private void TextPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (((TextBox)sender).Text.Length == 0 && e.KeyChar == '0')
                    e.Handled = true;
                else
                {
                    e.Handled = false;
                    FactorielCalc(int.Parse(((TextBox)sender).Text + e.KeyChar));
                }
            }
            else if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void BtnRetourClick(object sender, EventArgs e)
        {
            NfrmAccueil.sAccueil.Show();
            NfrmAccueil.sFactoriel.Close();
        }

        private void BtnQuitterClick(object sender, EventArgs e)
        {
            NfrmAccueil.sAccueil.Close();
            NfrmAccueil.sFactoriel.Close();
            LeChoix.sLeChoix.Show();
        }

        private void BtnHover(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.DeepSkyBlue;
        }

        private void BtnLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Gray;
        }
    }
}
