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
    public partial class LeChoix : Form
    {
        public LeChoix()
        {
            InitializeComponent();
            sLeChoix = this;
        }
        public static LeChoix sLeChoix;
        private void button1_Click(object sender, EventArgs e)
        {
            OfrmAccueil.frmAccueil = new OfrmAccueil();
            OfrmAccueil.frmAccueil.Show();
            sLeChoix.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NfrmAccueil.sAccueil = new NfrmAccueil();
            NfrmAccueil.sAccueil.Show();
            sLeChoix.Hide();
        }
    }
}
