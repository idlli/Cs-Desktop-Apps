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
    public partial class NfrmJeux : Form
    {
        private readonly Random r = new Random();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NfrmJeux));
        int[] l = new int[] { };
        int c, cn, i;
        public void SetLb(Label[] lb, bool bo)
        {
            foreach (Label lbg in lb)
            {
                lbg.Enabled = bo;
            }
        }
        public void SetMBt(Button[] bu, bool[] bo)
        {
            for (i = 0; i < bu.Length; i++)
            {
                bu[i].Enabled = bo[i];
            }
        }
        public void SetTx(TextBox[] te, bool bo)
        {
            foreach (TextBox teg in te)
                teg.Enabled = bo;
        }
        public void SetAtx(Label[] lb)
        {
            foreach (Label l in lb)
            {
                l.Text = "";
            }
        }
        public void SetDtx()
        {
            SetDBCtx(new TextBox[] { Txt1, Txt2, Txt3, Txt4 });
            SetDBCpn(new Panel[] { Pan1, Pan2, Pan3, Pan4 });
            SetCtx(new TextBox[] { Txt1, Txt2, Txt3, Txt4 });
        }
        public void SetDBCtx(TextBox[] tb)
        {
            foreach (TextBox tbg in tb)
            {
                tbg.BackColor = Color.WhiteSmoke;
            }
        }
        public void SetDBCpn(Panel[] pn)
        {
            foreach (Panel pbg in pn)
            {
                pbg.BackColor = Color.WhiteSmoke;
            }
        }
        public void SetCtx(TextBox[] tb)
        {
            foreach (TextBox tbg in tb)
            {
                tbg.Clear();
            }
        }
        public void SetLCt(Label[] lb)
        {
            foreach (Label lbg in lb)
            {
                lbg.ForeColor = Color.DimGray;
                lbg.Image = ((System.Drawing.Image)resources.GetObject(lbg.Name.ToString()+".Image"));
            }
        }
        public void Counter()
        {
            NCounter.Text = c.ToString();
            c -= 1;
        }
        public NfrmJeux()
        {
            InitializeComponent();
            SetAtx(new Label[] { Box1, Box2, Box3, Box4 });
        }
        private void TxtPP(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && ((TextBox)sender).TextLength < 1 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                if (((TextBox)sender).BackColor == Color.FromArgb(252, 219, 59))
                {
                    ((TextBox)sender).BackColor = Color.WhiteSmoke;
                    ((TextBox)sender).Parent.BackColor = Color.WhiteSmoke;
                }
                if (!(e.KeyChar == (char)Keys.Back))
                    SendKeys.Send("{TAB}");
            }
            else
                e.Handled = true;
        }
        private void BtnViewClick(object sender, EventArgs e)
        {
            Label[] lb = new Label[] { Box1, Box2, Box3, Box4 };
            for (i = 0; i< 4; i++)
            {
                if (lb[i].Image != default)
                {
                    lb[i].Image = default;
                    lb[i].Text = l[i].ToString();
                }
            }
            SetMBt(new Button[] { BtnView, BtnHide }, new bool[] { false, true });
        }

        private void BtnHideClick(object sender, EventArgs e)
        {
            SetAtx(new Label[] { Box1, Box2, Box3, Box4 });
            SetLCt(new Label[] { Box1, Box2, Box3, Box4 });
            BtnHide.Enabled = false;
        }

        private void BtnReloadClick(object sender, EventArgs e)
        {
            BtnCheck.Enabled = true;
            Counter();
            if (c >= 0)
            {
                TextBox[] tb = new TextBox[] { Txt1, Txt2, Txt3, Txt4 };
                foreach (TextBox tx in tb)
                {
                    if (!(tx.BackColor == Color.FromArgb(25, 230, 0)))
                        tx.Enabled = true;
                }
                if (c == 0)
                    BtnReload.Enabled = false;
            }
        }

        private void BtnCheckClick(object sender, EventArgs e)
        {
            BtnCheck.Enabled = false;
            TextBox[] tb = new TextBox[] { Txt1, Txt2, Txt3, Txt4 };
            Label[] lb = new Label[] { Box1, Box2, Box3, Box4 };
            for (i = 0; i < 4; i++)
            {
                if (tb[i].BackColor != Color.FromArgb(25, 230, 0))
                {
                    if (tb[i].Text != "" && int.TryParse(tb[i].Text, out cn) && l.Contains(cn))
                    {
                        if (l[i] == cn)
                        {
                            tb[i].BackColor = Color.FromArgb(25, 230, 0);
                            tb[i].Parent.BackColor = Color.FromArgb(25, 230, 0);
                            lb[i].Image = default;
                            lb[i].Text = tb[i].Text;
                            lb[i].ForeColor = Color.FromArgb(25, 230, 0);
                        }
                        else
                        {
                            tb[i].BackColor = Color.FromArgb(252, 219, 59);
                            tb[i].Parent.BackColor = Color.FromArgb(252, 219, 59);
                        }
                    }
                    else
                    {
                        if (tb[i].BackColor == Color.FromArgb(252, 219, 59))
                        {
                            tb[i].BackColor = Color.WhiteSmoke;
                            tb[i].Parent.BackColor = Color.WhiteSmoke;
                        }
                    }
                }
            }
            for (i = 0; i < 4; i++) {
                if (tb[i].BackColor == Color.FromArgb(25, 230, 0))
                    l[i] = -1;
            }
            if (c == 0)
            {
                if (!(Box1.Text != "" && Box2.Text != "" && Box3.Text != "" && Box4.Text != ""))
                    SetMBt(new Button[] { BtnView, BtnNew }, new bool[] { true, true });
                else
                    SetMBt(new Button[] { BtnHide, BtnNew }, new bool[] { true, true });
                Counter();
                NCounter.ForeColor = Color.DarkGray;
            }
            SetTx(new TextBox[] { Txt1, Txt2, Txt3, Txt4 }, false);
        }

        private void BtnRetourClick(object sender, EventArgs e)
        {
            NfrmAccueil.sAccueil.Show();
            NfrmAccueil.sJeux.Close();
        }

        private void BtnQuitterClick(object sender, EventArgs e)
        {
            NfrmAccueil.sAccueil.Close();
            NfrmAccueil.sJeux.Close();
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

        private void BtnNewClick(object sender, EventArgs e)
        {
            l = new int[] { r.Next(10), r.Next(10), r.Next(10), r.Next(10) };
            SetLb(new Label[] { Box1, Box2, Box3, Box4 }, true);
            NCounter.ForeColor = Color.Black;
            c = 3;
            Counter();
            SetMBt(new Button[] { BtnCheck, BtnReload, BtnNew, BtnHide, BtnView }, new bool[] { true, true, false , false , false });
            SetTx(new TextBox[] { Txt1, Txt2, Txt3, Txt4 }, true);
            SetAtx(new Label[] { Box1, Box2, Box3, Box4 });
            SetLCt(new Label[] { Box1, Box2, Box3, Box4 });
            SetDtx();
            Txt1.Focus();
        }
    }
}
