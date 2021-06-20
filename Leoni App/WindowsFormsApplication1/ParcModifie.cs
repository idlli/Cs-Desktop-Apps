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
    public partial class ParcModifie : Form
    {
        int i, code, places, reserve;
        bool b;
        decimal prix;
        DateTime date;
        public ParcModifie()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update.frmParcModifie.Close();
            update.frmUpdate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = -1;
            foreach (Trans_pers p in Program.ListeParc)
            {
                if (p.Getcode() == int.Parse(textBox6.Text))
                {
                    i = Program.ListeParc.IndexOf(p);
                    Program.TextEnable(new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5 }, true);
                    button1.Enabled = true;
                    comboBox1.Enabled = true;
                    maskedTextBox1.Enabled = true;
                    Program.LabelColor(new Label[] { label1, label2, label3, label4, label5, label6, label7 }, Color.FromArgb(99, 110, 114));
                    textBox1.Text = p.Gettype();
                    textBox2.Text = p.Getcode().ToString();
                    textBox3.Text = p.Getplacess().ToString();
                    textBox4.Text = p.Getprix_d_achat().ToString();
                    textBox5.Text = p.Getreserve().ToString();
                    Program.PastTech(comboBox1);
                    comboBox1.SelectedItem = "T : [" + p.GetconducteurResponsable().GetCIN() + "]";
                    maskedTextBox1.Text = p.Getdate_d_achat().ToString();
                    Program.GreenMessage(label9, "Cet type existe");
                    break;
                }
            }
            if (i == -1)
            {
                Program.RedMessage(label9, "Cet type n'existe pas");
                Program.TextEnable(new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5 }, false);
                button1.Enabled = false;
                comboBox1.Enabled = false;
                maskedTextBox1.Enabled = false;
                Program.LabelColor(new Label[] { label1, label2, label3, label4, label5, label6, label7 }, Color.DarkGray);
                Program.TextClear(new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5 });
                comboBox1.Items.Clear();
                maskedTextBox1.Clear();
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            Program.ReSearch(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                b = true;
                foreach (Trans_pers p in Program.ListeParc)
                {
                    if (p.Getcode() == int.Parse(textBox2.Text))
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    if (decimal.TryParse(textBox4.Text, out prix) && int.TryParse(textBox3.Text, out places) && int.TryParse(textBox5.Text, out reserve) && int.TryParse(textBox2.Text, out code) && DateTime.TryParse(maskedTextBox1.Text, out date))
                    {
                        foreach (Conducteur t in Program.ListeTechniciens)
                        {
                            if ("T : [" + t.GetCIN() + "]" == comboBox1.SelectedItem.ToString())
                            {
                                Program.ListeParc[i].Settype(textBox1.Text);
                                Program.ListeParc[i].Setcode(code);
                                Program.ListeParc[i].SetconducteurResponsable(t);
                                Program.ListeParc[i].Setdate_d_achat(date);
                                Program.ListeParc[i].Setprix_d_achat(prix);
                                Program.ListeParc[i].Setplacess(places);
                                Program.ListeParc[i].Setreserve(reserve);
                                Program.GreenMessage(label10, $"Modifiée [{textBox1.Text}]");
                                break;
                            }
                        }
                    }
                    else
                        Program.RedMessage(label10, "Prix où Code où Date où Places où Réservè invalid");
                }
                else
                    Program.RedMessage(label10, "Type déja existe");
            }
            else
                Program.RedMessage(label10,"Tech invalid");
        }
    }
}
