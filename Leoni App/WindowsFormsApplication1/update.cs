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
    public partial class update : Form
    {
        decimal prix;
        int i;
        Panel[] MenuPanels;
        Button[] MenuButtons;
        Color[] Colors = new Color[] { Color.FromArgb(255, 118, 117),Color.FromArgb(85, 239, 196), Color.FromArgb(116, 185, 255), Color.FromArgb(162, 155, 254),Color.FromArgb(253, 121, 168)};
        public update()
        {
            InitializeComponent();
            frmUpdate = this;
            MenuButtons = new Button[] { MenuT, MenuP, MenuM, MenuPD, MenuR };
            MenuPanels = new Panel[] { MenuTPanel, MenuPPanel, MenuMPanel, MenuPDPanel, MenuRPanel };
            MenuPPanel.Visible = false;
            MenuMPanel.Visible = false;
            MenuPDPanel.Visible = false;
            MenuRPanel.Visible = false;
        }
        public static update frmUpdate;
        public TechAjouter frmTechAjouter;
        public static TechModifie frmTechModifie;
        public static TechSupprimer frmTechSupprimer;
        public static ParcAjouter frmParcAjouter;
        public static ParcModifie frmParcModifie;
        public static ParcSupprimer frmParcSupprimer;
        public static MachAjouter frmMachAjouter;
        public static MachModifie frmMachModifie;
        public static MachSupprimer frmMachSupprimer;
        private void MenuCick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < MenuButtons.Length; i++)
            {
                if (MenuButtons[i] != (Button)sender)
                {
                    MenuButtons[i].BackColor = Color.FromArgb(223, 230, 233);
                    MenuPanels[i].Visible = false;
                    MenuButtons[i].FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 190, 195);
                    MenuButtons[i].ForeColor = Color.FromArgb(99, 110, 114);
                }
                else
                {
                    MenuButtons[i].BackColor = Color.White;
                    MenuPanels[i].Visible = true;
                    MenuButtons[i].FlatAppearance.MouseOverBackColor = Color.White;
                    MenuButtons[i].ForeColor = Colors[i];
                }
            }
        }

        private void MenuTButton1_Click(object sender, EventArgs e)
        {
            frmTechAjouter = new TechAjouter();
            frmTechAjouter.Show();
            frmUpdate.Hide();

        }

        private void MenuTButton2_Click(object sender, EventArgs e)
        {
            frmTechModifie = new TechModifie();
            frmTechModifie.Show();
            frmUpdate.Hide();
        }

        private void MenuTButton3_Click(object sender, EventArgs e)
        {
            frmTechSupprimer = new TechSupprimer();
            frmTechSupprimer.Show();
            frmUpdate.Hide();
        }

        private void MenuPButton1_Click(object sender, EventArgs e)
        {
            frmParcAjouter = new ParcAjouter();
            frmParcAjouter.Show();
            frmUpdate.Hide();
        }

        private void MenuPButton2_Click(object sender, EventArgs e)
        {
            frmParcModifie = new ParcModifie();
            frmParcModifie.Show();
            frmUpdate.Hide();
        }

        private void MenuPButton3_Click(object sender, EventArgs e)
        {
            frmParcSupprimer = new ParcSupprimer();
            frmParcSupprimer.Show();
            frmUpdate.Hide();
        }

        private void MenuMButton1_Click(object sender, EventArgs e)
        {
            frmMachAjouter = new MachAjouter();
            frmMachAjouter.Show();
            frmUpdate.Hide();
        }

        private void MenuMButton2_Click(object sender, EventArgs e)
        {
            frmMachModifie = new MachModifie();
            frmMachModifie.Show();
            frmUpdate.Hide();
        }

        private void MenuMButton3_Click(object sender, EventArgs e)
        {
            frmMachSupprimer = new MachSupprimer();
            frmMachSupprimer.Show();
            frmUpdate.Hide();
        }

        private void update_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = $"N° : {Program.ListeTechniciens.Count}";
            label2.Text = $"N° : {Program.ListeParc.Count}";
            label3.Text = $"N° : {Program.ListeMachines.Count}";
        }

        private void MenuPDbutton1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(MenuPDtextBox1.Text, out prix))
            {
                if (radioButton1.Checked)
                {
                    foreach (Conducteur t in Program.ListeTechniciens)
                    {
                        for (i = 0; i < Math.Max(Program.ListeParc.Count,Program.ListeMachines.Count); i++)
                        {
                            if (Program.ListeParc.Count > i && t.GetCIN() == Program.ListeParc[i].GetconducteurResponsable().GetCIN())
                            {
                                t.Setsalaire(t.Getsalaire() + prix);
                                break;
                            }
                            else if (Program.ListeMachines.Count > i && t.GetCIN() == Program.ListeMachines[i].GetconducteurResponsable().GetCIN())
                            {
                                t.Setsalaire(t.Getsalaire() + prix);
                                break;
                            }
                        }
                    }
                }
                else if (radioButton2.Checked)
                {
                    foreach (Conducteur t in Program.ListeTechniciens)
                    {
                        for (i = 0; i < Math.Max(Program.ListeParc.Count, Program.ListeMachines.Count); i++)
                        {
                            if (Program.ListeParc.Count > i && t.GetCIN() == Program.ListeParc[i].GetconducteurResponsable().GetCIN())
                            {
                                t.Setsalaire(t.Getsalaire() - prix);
                                break;
                            }
                            else if (Program.ListeMachines.Count > i && t.GetCIN() == Program.ListeMachines[i].GetconducteurResponsable().GetCIN())
                            {
                                t.Setsalaire(t.Getsalaire() - prix);
                                break;
                            }
                        }
                    }
                }
                MenuPDlabel2.Text = "Fait";
            }
            else
                MenuPDlabel2.Text = "Prix invalid";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (Program.Cin.IsMatch(textBox2.Text))
            {
                for (i = 0; i < Math.Max(Program.ListeParc.Count, Program.ListeMachines.Count); i++)
                {
                    if (Program.ListeParc.Count > i && Program.ListeParc[i].GetconducteurResponsable().GetCIN() == textBox2.Text)
                        comboBox1.Items.Add($"M : [{Program.ListeParc[i].Getplacess()}]");
                    else if (Program.ListeMachines.Count > i && Program.ListeMachines[i].GetconducteurResponsable().GetCIN() == textBox2.Text)
                        comboBox1.Items.Add($"M : [{Program.ListeMachines[i].Gettypecablage()}]");
                }
                label7.Text = "Fait";
            }
            else
                label7.Text = "Cin invalid";
        }
    }
}
