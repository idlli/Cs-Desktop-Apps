using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passage_2012
{
    public partial class Form1 : Form
    {
        int numDossier;
        public Form1()
        {
            InitializeComponent();
        }
        void Afficher(Inscription d)
        {
            textBox1.Text = d.GetnumDossier().ToString();
            textBox2.Text = d.Getcandidat().Getcne().ToString();
            textBox3.Text = d.Getcandidat().Getnom();
            textBox4.Text = d.Getcandidat().Getprenom();
            dateTimePicker1.Value = d.GetdateInscription();
            dateTimePicker2.Value = d.Getcandidat().GetdateNaiss();
            if (d.Getcandidat().Getsexe() == 'M')
                radioButton1.Checked = true;
            else if (d.Getcandidat().Getsexe() == 'F')
                radioButton2.Checked = true;
            comboBox1.SelectedItem = d.Getniveau().GetintitNiv();
            comboBox2.SelectedItem = d.Getcandidat().GetnivScolaire();
            comboBox3.SelectedItem = d.Getfiliers()[0].GetintitFil();
            comboBox4.SelectedItem = d.Getfiliers()[1].GetintitFil();
            comboBox5.SelectedItem = d.Getfiliers()[2].GetintitFil();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedItem = "";
            comboBox2.SelectedItem = "";
            comboBox3.SelectedItem = "";
            comboBox4.SelectedItem = "";
            comboBox5.SelectedItem = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && int.TryParse(textBox1.Text, out numDossier) && Program.Rechercher(numDossier) == -1)
            {
                Program.Dossier.Add(new Inscription(numDossier, dateTimePicker1.Value, new Candidat(int.Parse(textBox2.Text), textBox3.Text, textBox4.Text, comboBox2.SelectedItem.ToString(), radioButton1.Checked == true ? 'M' : radioButton2.Checked == true ? 'F' : 'N', dateTimePicker2.Value), new Niveau(comboBox1.SelectedIndex, comboBox1.SelectedItem.ToString()), new Filière[] { new Filière(comboBox3.SelectedIndex, comboBox3.SelectedItem.ToString()), new Filière(comboBox4.SelectedIndex, comboBox4.SelectedItem.ToString()), new Filière(comboBox5.SelectedIndex, comboBox5.SelectedItem.ToString()) }));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && int.TryParse(textBox1.Text, out numDossier) && Program.Rechercher(numDossier) != -1)
            {
                if (checkBox1.Checked == true)
                    Program.Dossier.RemoveAt(Program.Rechercher(numDossier));
                else if (checkBox2.Checked == true)
                {
                    foreach (Inscription d in Program.Dossier)
                    {
                        if (d.Getcandidat().Getcne() == int.Parse(textBox2.Text))
                        {
                            Program.Dossier.Remove(d);
                            break;
                        }
                    }
                }
                else if (checkBox3.Checked == true)
                {
                    foreach (Inscription d in Program.Dossier)
                    {
                        if (d.Getcandidat().Getnom() == textBox3.Text)
                        {
                            Program.Dossier.Remove(d);
                            break;
                        }
                    }
                }
                else if (checkBox4.Checked == true)
                {
                    foreach (Inscription d in Program.Dossier)
                    {
                        if (d.Getcandidat().Getprenom() == textBox4.Text)
                        {
                            Program.Dossier.Remove(d);
                            break;
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && int.TryParse(textBox1.Text, out numDossier) && Program.Rechercher(numDossier) != -1)
            {
                if (checkBox1.Checked == true)
                    Afficher(Program.Dossier[Program.Rechercher(numDossier)]);
                else if (checkBox2.Checked == true)
                {
                    foreach (Inscription d in Program.Dossier)
                    {
                        if (d.Getcandidat().Getcne() == int.Parse(textBox2.Text))
                        {
                            Afficher(d);
                            break;
                        }
                    }
                }
                else if (checkBox3.Checked == true)
                {
                    foreach (Inscription d in Program.Dossier)
                    {
                        if (d.Getcandidat().Getnom() == textBox3.Text)
                        {
                            Afficher(d);
                            break;
                        }
                    }
                }
                else if (checkBox4.Checked == true)
                {
                    foreach (Inscription d in Program.Dossier)
                    {
                        if (d.Getcandidat().Getprenom() == textBox4.Text)
                        {
                            Afficher(d);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("not found");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                comboBox1.SelectedItem = "";
                comboBox2.SelectedItem = "";
                comboBox3.SelectedItem = "";
                comboBox4.SelectedItem = "";
                comboBox5.SelectedItem = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Afficher(Program.Dossier[0]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Afficher(Program.Dossier[Program.Rechercher(int.Parse(textBox1.Text)) - 1]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Afficher(Program.Dossier[Program.Rechercher(int.Parse(textBox1.Text)) + 1]);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Afficher(Program.Dossier[Program.Dossier.Count - 1]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
