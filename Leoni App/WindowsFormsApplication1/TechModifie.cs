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
    public partial class TechModifie : Form
    {
        int i;
        bool b;
        decimal prix;
        public TechModifie()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update.frmTechModifie.Close();
            update.frmUpdate.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            i = -1;
            foreach (Conducteur t in Program.ListeTechniciens)
            {
                if (t.GetCIN() == textBox6.Text)
                {
                    i = Program.ListeTechniciens.IndexOf(t);
                    Program.TextEnable(new TextBox[] { textBox1, textBox2, textBox3, textBox4 }, true);
                    button2.Enabled = true;
                    Program.LabelColor(new Label[] { label1, label2, label3, label4 }, Color.FromArgb(99, 110, 114));
                    textBox1.Text = t.GetCIN();
                    textBox2.Text = t.Getnom();
                    textBox3.Text = t.Getprénom();
                    textBox4.Text = t.Getsalaire().ToString();
                    Program.GreenMessage(label6, "Cet cin existe");
                    break;
                }
            }
            if (i == -1)
            {
                Program.RedMessage(label6, "Cet cin n'existe pas");
                Program.TextEnable(new TextBox[] { textBox1, textBox2, textBox3, textBox4 }, false);
                button2.Enabled = false;
                Program.LabelColor(new Label[] { label1, label2, label3, label4 }, Color.DarkGray);
                Program.TextClear(new TextBox[] { textBox1, textBox2, textBox3, textBox4 });
            }
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
                        Program.ListeTechniciens[i].SetCIN(textBox1.Text);
                        Program.ListeTechniciens[i].Setnom(textBox2.Text);
                        Program.ListeTechniciens[i].Setprénom(textBox3.Text);
                        Program.ListeTechniciens[i].Setsalaire(decimal.Parse(textBox4.Text));
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
