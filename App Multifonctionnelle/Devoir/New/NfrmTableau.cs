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
    public partial class NfrmTableau : Form
    {
        List<double> d = new List<double>();
        int c = 1;
        public NfrmTableau()
        {
            InitializeComponent();
            SetDT();
        }
        double Mdc, Ecart, n;
        int inf, sup;
        public void SetDT()
        {
            LabelN.Text = "Entrez la note de l'élève N°: " + c;
        }
        private void TextPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(((e.KeyChar == '.' || e.KeyChar == ',') && !((TextBox)sender).Text.Contains('.') && !((TextBox)sender).Text.Contains(',')) ? '0' : e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == ',')
                    e.KeyChar = '.';
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Enter && ((TextBox)sender).Text != "")
            {
                ClickSave();
            }
            else
                e.Handled = true;
        }
        public void ClickSave()
        {
            if (textBox1.Text != "")
            {
                n = double.Parse(textBox1.Text);
                if (LabelL.Text == "") LabelL.Text += textBox1.Text;
                else LabelL.Text += "-" + textBox1.Text;
                d.Add(n);
                c += 1;
                if (c == 6)
                {
                    c -= 1;
                    SetMBE(new Button[] { button4, button2 }, new bool[] { true, false });
                    textBox1.Enabled = false;
                    LabelN.ForeColor = Color.DarkGray;
                    button4.Focus();
                }
                SetDT();
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClickSave();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sup = 0;
            inf = 0;
            Mdc = 0;
            Ecart = 0;
            foreach (double g in d)
            {
                if (g >= 10) sup += 1;
                else inf += 1;
                Mdc += g;
            }
            Mdc /= d.Count;
            foreach (double g in d)
            {
                Ecart += Math.Pow(g - Mdc, 2);
            }
            Ecart = Math.Sqrt(Ecart / d.Count);
            SetMT(new Label[] { LabelN1, LabelN2, LabelN3, LebelN4 }, new object[] { Mdc, Ecart, inf, sup });
            SetLCG(new Label[] { LabelT1, LabelT2, LabelT3, LabelT4, LabelN1, LabelN2 });
            SetMLC(new Label[] { LabelN3, LebelN4 }, new Color[] { Color.FromArgb(252, 87, 59), Color.FromArgb(25, 230, 0) });
            SetMBE(new Button[] { button4, button2 }, new bool[] { false, true });
            c = 1;
            textBox1.Enabled = true;
            SetDT();
            LabelL.Text = "";
            d.Clear();
            textBox1.Focus();
        }

        private void BtnRetourClick(object sender, EventArgs e)
        {
            NfrmAccueil.sAccueil.Show();
            NfrmAccueil.sTableau.Close();
        }

        private void BtnQuitterClick(object sender, EventArgs e)
        {
            NfrmAccueil.sAccueil.Close();
            NfrmAccueil.sTableau.Close();
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

        public void SetMT(Label[] lb, object[] s)
        {
            for (int i = 0; i < lb.Length; i++)
            {
                lb[i].Text = s[i].ToString();
            }
        }
        public void SetLCG(Label[] lb)
        {
            foreach (Label l in lb)
            {
                l.ForeColor = Color.Gray;
            }
        }
        public void SetMLC(Label[] lb, Color[] c)
        {
            for (int i = 0; i < lb.Length; i++)
            {
                lb[i].ForeColor = c[i];
            }
        }
        public void SetMBE(Button[] bt, bool[] bo)
        {
            for (int i = 0; i < bt.Length; i++)
            {
                bt[i].Enabled = bo[i];

            }
        }
    }
}
