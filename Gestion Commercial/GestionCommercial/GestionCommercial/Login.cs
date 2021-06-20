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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Any() && textBox2.Text.Any())
            {
                if (g.dc.Utilisateurs.Where(o => o.Identity == textBox1.Text && o.Password == textBox2.Text).Any())
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
            }
        }
    }
}
