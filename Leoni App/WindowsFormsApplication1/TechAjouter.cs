using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TechAjouter : Form
    {
        bool b;
        decimal prix;
        public TechAjouter()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            update.frmUpdate.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Program.Cin.IsMatch(textBox1.Text))
            {
                b = true;
                foreach (Conducteur t in Program.ListeTechniciens)
                {
                    if (t.GetCIN() == textBox1.Text)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    if (decimal.TryParse(textBox4.Text, out prix))
                    {
                        Program.ListeTechniciens.Add(new Conducteur(textBox1.Text, textBox2.Text, textBox3.Text, prix));
                        Program.GreenMessage(label5, $"Ajoutée [{textBox1.Text}]");
                    }
                    else
                        Program.RedMessage(label5, "Salarie invalid");
                }
                else
                    Program.RedMessage(label5, "Cin déja existe");
            }
            else
                Program.RedMessage(label5, "Cin invalid");
        }
    }
}
