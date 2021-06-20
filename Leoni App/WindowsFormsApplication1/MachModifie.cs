﻿using System;
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
    public partial class MachModifie : Form
    {
        int code, i, capacite;
        decimal prix;
        bool b;
        DateTime date;
        public MachModifie()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update.frmMachModifie.Close();
            update.frmUpdate.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = -1;
            foreach (Trans_cbale m in Program.ListeMachines)
            {
                if (int.TryParse(textBox3.Text, out code) && m.Getcode() == code)
                {
                    i = Program.ListeMachines.IndexOf(m);
                    Program.TextEnable(new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5 }, true);
                    button1.Enabled = true;
                    comboBox1.Enabled = true;
                    maskedTextBox1.Enabled = true;
                    Program.LabelColor(new Label[] { label1, label2, label3, label4, label5, label6, label7 }, Color.FromArgb(99, 110, 114));
                    textBox1.Text = m.Gettype();
                    textBox2.Text = code.ToString();
                    textBox3.Text = m.Gettypecablage();
                    textBox4.Text = m.Getprix_d_achat().ToString();
                    textBox5.Text = m.Getcapacite().ToString();
                    Program.PastTech(comboBox1);
                    comboBox1.SelectedItem = "T : [" + m.GetconducteurResponsable().GetCIN() + "]";
                    maskedTextBox1.Text = m.Getdate_d_achat().ToString();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.ReSearch(comboBox1);
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
                                Program.ListeMachines[i].Settype(textBox1.Text);
                                Program.ListeMachines[i].Setcode(code);
                                Program.ListeMachines[i].SetconducteurResponsable(t);
                                Program.ListeMachines[i].Setdate_d_achat(date);
                                Program.ListeMachines[i].Setprix_d_achat(prix);
                                Program.ListeMachines[i].Settypecablage(textBox3.Text);
                                Program.ListeMachines[i].Setcapacite(capacite);
                                Program.GreenMessage(label10, $"Modifiée [{textBox1.Text}]");
                                break;
                            }
                        }
                    }
                    else
                        Program.RedMessage(label10, "Prix où Code où Date invalid");
                }
                else
                    Program.RedMessage(label10, "Type déja existe");
            }
            else
                Program.RedMessage(label10, "Tech invalid");
        }
    }
}
