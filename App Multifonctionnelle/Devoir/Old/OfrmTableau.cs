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
    public partial class OfrmTableau : Form
    {
        List<double> d = new List<double>();
        int c = 1;
        public OfrmTableau()
        {
            InitializeComponent();
            BtnCalc.Enabled = false;
            LblRes.Text = "Entrez la note de l'élève N°: " + c;
        }

        private void TxtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(((e.KeyChar == '.' || e.KeyChar == ',') && !((TextBox)sender).Text.Contains('.') && !((TextBox)sender).Text.Contains(',')) ? '0' : e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == ',')
                    e.KeyChar = '.';
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void BtnEnreg_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TxtN.Text);
            if (TxtN.Text != "")
                d.Add(a);
            if (c == 1)
                LblT.Text += "|";
            c += 1;
            LblT.Text += TxtN.Text + "|";
            if (c == 6)
            {
                c -= 1;
                BtnCalc.Enabled = true;
                BtnEnreg.Enabled = false;
                TxtN.Enabled = false;
            }
            LblRes.Text = "Entrez la note de l'élève N°: " + c;
            TxtN.Clear();
        }
        double Mdc, Ecart;
        int inf, sup;

        private void BtnQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (d.Count > 0)
            {
                foreach (double g in d)
                {
                    if (g >= 10)
                        sup += 1;
                    else
                        inf += 1;
                    Mdc += g;
                }
                foreach (double g in d)
                {
                    Ecart += Math.Pow((g - Mdc), 2);
                }
                Mdc /= d.Count;
                Math.Sqrt(Ecart / d.Count);
                LblMoy.Text = Mdc.ToString();
                LblEcart.Text = Ecart.ToString("0.00000");
                LblInf.Text = inf.ToString();
                LblSup.Text = sup.ToString();
            }
            else
                MessageBox.Show("Aucune numéro n'a été trouvé");

        }
    }
}
