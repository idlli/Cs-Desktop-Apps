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
    public partial class ParcAjouter : Form
    {
        int i, code, places, reserve;
        bool b;
        decimal prix;
        DateTime date;
        public ParcAjouter()
        {
            InitializeComponent();
            Program.PastTech(comboBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update.frmParcAjouter.Close();
            update.frmUpdate.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                b = true;
                foreach (Trans_pers p in Program.ListeParc)
                {
                    if (p.Getcode() == int.Parse(codeText.Text))
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    if (decimal.TryParse(prixText.Text, out prix) && int.TryParse(typeText.Text, out places) && int.TryParse(directionText.Text, out reserve) && int.TryParse(codeText.Text, out code) && DateTime.TryParse(maskedTextBox1.Text, out date))
                    {
                        foreach (Conducteur t in Program.ListeTechniciens)
                        {
                            if ("T : [" + t.GetCIN() + "]" == comboBox1.SelectedItem.ToString())
                            {
                                Program.ListeParc.Add(new Trans_pers(nomText.Text, code, t, date, prix, places, reserve));
                                Program.GreenMessage(label8, $"Ajoutée [{nomText.Text}]");
                                break;
                            }
                        }
                    }
                    else
                        Program.RedMessage(label8, "Prix où Code où Date invalid");
                }
                else
                    Program.RedMessage(label8, "Type déja existe");
            }
            else
                Program.RedMessage(label8, "Tech invalid");
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            Program.ReSearch(comboBox1);
        }
    }
}
