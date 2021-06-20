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
    public partial class OfrmJeux : Form
    {
        private readonly Random r = new Random();
        int[] l = new int[] { };
        int c = 3;
        public void SetBt(Button[] bu, bool bo)
        {
            foreach (Button bug in bu)
            {
                bug.Enabled = bo;
            }
        }
        public void SetMBt(Button[] bu, bool[] bo)
        {
            for (int i = 0; i < bu.Length; i++)
            {
                bu[i].Enabled = bo[i];
            }
        }
        public void SetTx(TextBox[] te, bool bo)
        {
            foreach (TextBox teg in te)
                teg.Enabled = bo;
        }
        public void SetAtx(string st)
        {
            Txt1.Text = st;
            Txt2.Text = st;
            Txt3.Text = st;
            Txt4.Text = st;
        }
        public void SetDtx()
        {
            SetDBCtx(new TextBox[] { TxtP1, TxtP2, TxtP3, TxtP4 });
            SetCtx(new TextBox[] { TxtP1, TxtP2, TxtP3, TxtP4 });
        }
        public void SetDBCtx(TextBox[] tb)
        {
            foreach (TextBox tbg in tb)
            {
                tbg.BackColor = SystemColors.Window;
            }
        }
        public void SetCtx(TextBox[] tb)
        {
            foreach (TextBox tbg in tb)
            {
                tbg.Clear();
            }
        }
        public void SetLt(Label[] lb)
        {
            for (int i = 0; i < lb.Length; i++)
            {
                lb[i].Text = l[i].ToString();
            }
        }
        public void SetLCt(Label[] lb)
        {
            foreach (Label lbg in lb)
            {
                lbg.ForeColor = SystemColors.ControlText;
            }
        }
        public void Counter()
        {
            LblNbJeux.Text = c.ToString();
            c -= 1;
        }
        public OfrmJeux()
        {
            InitializeComponent();
            SetBt(new Button[] { BtnA, BtnC, BtnR, BtnV }, false);
            SetTx(new TextBox[] { TxtP1, TxtP2, TxtP3, TxtP4 }, false);
            SetAtx("");
            LblNbJeux.Text = "0";
            LblNbJeux.ForeColor = Color.DarkGray;
        }
        private void BtnN_Click(object sender, EventArgs e)
        {
            l = new int[] { r.Next(10), r.Next(10), r.Next(10), r.Next(10) };
            SetAtx("?");
            LblNbJeux.ForeColor = Color.Black;
            c = 3;
            Counter();
            SetMBt(new Button[] { BtnV, BtnR, BtnN }, new bool[] { true, true, false });
            SetTx(new TextBox[] { TxtP1, TxtP2, TxtP3, TxtP4 }, true);
            SetDtx();
            TxtP1.Focus();
        }
        private void TxtPP(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && ((TextBox)sender).TextLength < 1 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                if (((TextBox)sender).BackColor == Color.Yellow)
                    ((TextBox)sender).BackColor = SystemColors.Window;
            }
            else
                e.Handled = true;
        }
        public void Check(int n, TextBox t, Label b)
        {
            if (t.Text != "" && l.Contains(int.Parse(t.Text)))
            {
                if (n == int.Parse(t.Text))
                {
                    t.BackColor = Color.Lime;
                    b.Text = t.Text;
                    b.ForeColor = Color.LimeGreen;
                }
                else
                    t.BackColor = Color.Yellow;
            }
        }
        private void BtnV_Click(object sender, EventArgs e)
        {
            BtnV.Enabled = false;
            TextBox[] tb = new TextBox[] { TxtP1, TxtP2, TxtP3, TxtP4 };
            Label[] lb = new Label[] { Txt1, Txt2, Txt3, Txt4 };
            for (int i = 0; i < 4; i++)
            {
                if (tb[i].BackColor != Color.Lime)
                    Check(l[i], tb[i], lb[i]);
            }
            if (c == 0)
            {
                if (!(Txt1.Text != "?" && Txt2.Text != "?" && Txt3.Text != "?" && Txt4.Text != "?"))
                    SetMBt(new Button[] { BtnA, BtnN }, new bool[] { true, true });
                else
                    SetMBt(new Button[] { BtnC, BtnN }, new bool[] { true, true });
                Counter();
                LblNbJeux.ForeColor = Color.DarkGray;
            }
            SetTx(new TextBox[] { TxtP1, TxtP2, TxtP3, TxtP4 }, false);

        }
        private void BtnR_Click(object sender, EventArgs e)
        {
            BtnV.Enabled = true;
            Counter();
            if (c >= 0)
            {
                TextBox[] tb = new TextBox[] { TxtP1, TxtP2, TxtP3, TxtP4 };
                foreach (TextBox tx in tb)
                {
                    if (!(tx.BackColor == Color.Lime))
                        tx.Enabled = true;
                }
                if (c == 0)
                    BtnR.Enabled = false;
            }
        }
        private void BtnA_Click(object sender, EventArgs e)
        {
            SetLt(new Label[] { Txt1, Txt2, Txt3, Txt4 });
            SetMBt(new Button[] { BtnA, BtnC }, new bool[] { false, true });
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            SetAtx("?");
            SetLCt(new Label[] { Txt1, Txt2, Txt3, Txt4 });
            BtnC.Enabled = false;
        }
        private void BtnQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
