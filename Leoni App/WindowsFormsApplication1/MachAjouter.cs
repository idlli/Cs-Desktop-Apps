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
    public partial class MachAjouter : Form
    {
        int i, code, capacite;
        decimal prix;
        bool b;
        DateTime date;
        public MachAjouter()
        {
            InitializeComponent();
            Program.PastTech(comboBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update.frmMachAjouter.Close();
            update.frmUpdate.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                b = true;
                foreach (Trans_cbale m in Program.ListeMachines)
                {
                    if (int.TryParse(textBox2.Text, out code) && m.Getcode() == code)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    if (decimal.TryParse(textBox4.Text, out prix) && DateTime.TryParse(maskedTextBox1.Text, out date) && int.TryParse(textBox5.Text, out capacite))
                    {
                        foreach (Conducteur t in Program.ListeTechniciens)
                        {
                            if ("T : [" + t.GetCIN() + "]" == comboBox1.SelectedItem.ToString())
                            {
                                Program.ListeMachines.Add(new Trans_cbale(textBox1.Text, code, t, date, prix, textBox3.Text, capacite));
                                Program.GreenMessage(label8, $"Ajoutée [{textBox1.Text}]");
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
