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
    public partial class BonCommandeForm : Form
    {
        public BonCommandeForm()
        {
            InitializeComponent();
        }

        public BonCommandeForm(string numCom)
        {
            InitializeComponent();
            BonCommandeR2.SetDataSource(g.dc.BonCommandes.Where(o => o.NumCom == numCom));
        }
    }
}
