using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace GestionCommercial
{
    public partial class GestionCommandes : Form
    {
        public GestionCommandes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CodeCl.DataSource = g.dc.Clients.Select(o => o.CodeCl);
            CodeA.DataSource = g.dc.Articles.Where(o => o.QDISP > 0).Select(o => o.CodeArt);
        }

        private void CodeCl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _client = g.dc.Clients.Where(o => o.CodeCl == CodeCl.Text).FirstOrDefault();
            if (_client != null)
            {
                NomC.Text = _client.Nom;
                VilleC.Text = _client.Ville;
            }
        }

        private void CodeA_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _article = g.dc.Articles.Where(o => o.CodeArt == CodeA.Text).FirstOrDefault();
            if (_article != null)
            {
                Desi.Text = _article.Desi;
                PU.Text = _article.PU.ToString();
                QD.Text = _article.QDISP.ToString();
            }
        }

        private void NCommande_TextChanged(object sender, EventArgs e)
        {
            MyGridView.Rows.Clear();
            Total.Text = "";
            if (NCommande.Text.Length > 0)
            {
                var _commande = g.dc.Commandes.Where(o => o.NumCom == NCommande.Text).FirstOrDefault();
                if (_commande != null)
                {
                    DateCommande.Value = _commande.DateCom.Value;
                    var _details = g.dc.Details.Where(o => o.NumCom == NCommande.Text).Select(o => new {o.CodeArt, o.Article.Desi, o.Article.PU, o.Qte, montant = o.Article.PU * o.Qte });
                    foreach (var item in _details)
                    {
                        MyGridView.Rows.Add(new object[] { item.CodeArt, item.Desi, item.PU, item.Qte, item.montant });
                    }
                    Total.Text = _details.Sum(o => o.montant).ToString();
                    if (_commande.NE.Value)
                    {
                        Ajouter.Enabled = false;
                        Supprimer.Enabled = false;
                        Enregistrer.Enabled = false;
                    }
                    else
                    {
                        Ajouter.Enabled = true;
                        Supprimer.Enabled = true;
                        Enregistrer.Enabled = true;
                    }
                }
                else
                {
                    Ajouter.Enabled = true;
                    Supprimer.Enabled = true;
                    Enregistrer.Enabled = true;
                }
            }
        }

        private void CodeCl_TextChanged(object sender, EventArgs e)
        {
            Enregistrer.Enabled = CodeCl.Text.Any();
            var _client = g.dc.Clients.Where(o => o.CodeCl == CodeCl.Text).FirstOrDefault();
            if (_client != null)
            {
                NomC.Enabled = false;
                VilleC.Enabled = false;
                CodeCl_SelectedIndexChanged(null, e);
            }
            else
            {
                NomC.Enabled = true;
                VilleC.Enabled = true;
            }
        }

        private void CodeA_TextChanged(object sender, EventArgs e)
        {
            Ajouter.Enabled = CodeA.Text.Any();
            var _article = g.dc.Articles.Where(o => o.CodeArt == CodeA.Text).FirstOrDefault();
            if (_article != null)
            {
                Desi.Enabled = false;
                PU.Enabled = false;
                QD.Enabled = false;
                CodeA_SelectedIndexChanged(null, e);
            }
            else
            {
                Desi.Enabled = true;
                PU.Enabled = true;
                QD.Enabled = true;
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            decimal _pu;
            int _q;
            var _article = g.dc.Articles.Where(o => o.CodeArt == CodeA.Text).FirstOrDefault();
            if (_article == null)
            {
                Article _art = new Article();
                _art.CodeArt = CodeA.Text;
                _art.Desi = Desi.Text;
                _art.PU = decimal.Parse(PU.Text);
                _art.QDISP = int.Parse(QD.Text);
                g.dc.Articles.InsertOnSubmit(_art);
                _article = g.dc.Articles.Where(o => o.CodeArt == CodeA.Text).FirstOrDefault();
            }
            if (decimal.TryParse(PU.Text.Trim(), out _pu) && _pu > 0 && int.TryParse(QC.Text.Trim(), out _q) && _q > 0 && int.Parse(QD.Text) >= _q)
            {
                
                MyGridView.Rows.Add(new object[] { CodeA.Text, Desi.Text, _pu, _q,  _pu * _q});
                _article.QDISP -= _q;
                if (_article.QDISP <= 0)
                {
                    Desi.Text = "";
                    PU.Text = "";
                    QD.Text = "";
                    CodeA.DataSource = g.dc.Articles.Where(o => o.QDISP > 0).Select(o => o.CodeArt);
                }
                else
                {
                    QD.Text = _article.QDISP.ToString();
                }
                Total.Text = ((Total.Text.Any() ? decimal.Parse(Total.Text) : 0) + _pu * _q).ToString();
            }
            else
            {
                MessageBox.Show("Une error dans l'insertion car le pu ou q n'est pas correct");
            }
        }

        private void MyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Supprimer.Enabled = MyGridView.SelectedRows.Count > 0 ? true : false;
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            var _article = g.dc.Articles.Where(o => o.CodeArt == MyGridView.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault();
            _article.QDISP += int.Parse(MyGridView.SelectedRows[0].Cells[3].Value.ToString());
            Total.Text = (decimal.Parse(Total.Text) - decimal.Parse(MyGridView.SelectedRows[0].Cells[4].Value.ToString())).ToString();
            MyGridView.Rows.Remove(MyGridView.SelectedRows[0]);
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            var _client = g.dc.Clients.Where(o => o.CodeCl == CodeCl.Text).FirstOrDefault();
            if (_client == null)
            {
                Client _cli = new Client();
                _cli.CodeCl = CodeCl.Text;
                _cli.Nom = NomC.Text;
                _cli.Ville = VilleC.Text;
                g.dc.Clients.InsertOnSubmit(_cli);
                _client = g.dc.Clients.Where(o => o.CodeCl == CodeCl.Text).FirstOrDefault();
            }
            using (var _tran = new TransactionScope())
            {
                try
                {
                    g.dc.SubmitChanges();
                    var _comm = g.dc.Commandes.Where(o => o.NumCom == NCommande.Text).FirstOrDefault();
                    if (_comm == null)
                    {
                        Commande _commande = new Commande();
                        _commande.NumCom = NCommande.Text;
                        _commande.DateCom = DateCommande.Value;
                        _commande.CodeCl = _client.CodeCl;
                        g.dc.Commandes.InsertOnSubmit(_commande);
                        g.dc.SubmitChanges();
                    }
                    foreach (DataGridViewRow row in MyGridView.Rows)
                    {
                        var _getDet = g.dc.Details.Where(o => o.NumCom == NCommande.Text && o.CodeArt == row.Cells[0].Value.ToString()).FirstOrDefault();
                        if (_getDet == null)
                        {
                            var _detail = new Detail();
                            _detail.NumCom = NCommande.Text;
                            _detail.CodeArt = row.Cells[0].Value.ToString();
                            _detail.Qte = int.Parse(row.Cells[3].Value.ToString());
                            g.dc.Details.InsertOnSubmit(_detail);
                        }
                    }
                    g.dc.SubmitChanges();
                    _tran.Complete();
                }
                catch
                {
                    MessageBox.Show("Error dans l'enregistrement de commande");
                }
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            var _comm = g.dc.Commandes.Where(o => o.NumCom == NCommande.Text).FirstOrDefault();
            _comm.NE = true;
            g.dc.SubmitChanges();
            Ajouter.Enabled = false;
            Supprimer.Enabled = false;
            Enregistrer.Enabled = false;
        }

        private void Saisir_Click(object sender, EventArgs e)
        {
            var _commande = g.dc.Commandes.Where(o => o.NumCom == NCommande.Text).FirstOrDefault();
            if (_commande != null && _commande.NE.Value)
            {
                GestionLivraison gestionLivraison = new GestionLivraison(NCommande.Text);
                gestionLivraison.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BonCommandeForm bonCommandeForm = new BonCommandeForm(NCommande.Text);
            bonCommandeForm.Show();
        }
    }
}
