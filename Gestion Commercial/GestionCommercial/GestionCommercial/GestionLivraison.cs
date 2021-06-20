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
    public partial class GestionLivraison : Form
    {
        public GestionLivraison()
        {
            InitializeComponent();
        }

        public GestionLivraison(string _nCommande)
        {
            InitializeComponent();
            NCommande.Text = _nCommande;
        }

        private void GestionLivraison_Load(object sender, EventArgs e)
        {
            var _commande = g.dc.Commandes.Where(o => o.NumCom == NCommande.Text).FirstOrDefault();
            if (_commande != null)
            {
                var _details = g.dc.Details.Where(o => o.NumCom == NCommande.Text).Select(o => new { o.CodeArt, o.Article.Desi, o.Article.PU, o.Qte});
                foreach (var item in _details)
                {
                    MyGridView.Rows.Add(new object[] { item.CodeArt, item.Desi, item.PU, item.Qte});
                }
            }
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            var _livraison = g.dc.Livraisons.Where(o => o.NumLiv == NLivraison.Text).FirstOrDefault();
            if (_livraison == null)
            {
                Livraison _liv = new Livraison();
                _liv.NumLiv = NLivraison.Text;
                _liv.DateLiv = DateLivraison.Value;
                _liv.Livreur = Livreur.Text;
                _liv.EtatLiv = false;
                g.dc.Livraisons.InsertOnSubmit(_liv);
                g.dc.SubmitChanges();
                _livraison = g.dc.Livraisons.Where(o => o.NumLiv == NLivraison.Text).FirstOrDefault();
            }
            using (var _tran = new TransactionScope())
            {
                try
                {
                    foreach (DataGridViewRow row in MyGridView.Rows)
                    {
                        int _ql;
                        if (int.TryParse(row.Cells[4].Value == null ? "" : row.Cells[4].Value.ToString(), out _ql) && int.Parse(row.Cells[3].Value.ToString()) >= _ql)
                        {
                            var _getLigne = g.dc.LigneLivraisons.Where(o => o.NumLiv == _livraison.NumLiv && o.CodeArt == row.Cells[0].Value.ToString()).FirstOrDefault();
                            if (_getLigne == null)
                            {
                                LigneLivraison _ligneLivraison = new LigneLivraison();
                                _ligneLivraison.NumLiv = _livraison.NumLiv;
                                _ligneLivraison.CodeArt = row.Cells[0].Value.ToString();
                                _ligneLivraison.QLiv = _ql;
                                g.dc.LigneLivraisons.InsertOnSubmit(_ligneLivraison);
                                var _detail = g.dc.Details.Where(o => o.NumCom == NCommande.Text && o.CodeArt == row.Cells[0].Value.ToString()).FirstOrDefault();
                                _detail.Qte -= _ql;
                            }
                            else
                            {
                                var _detail = g.dc.Details.Where(o => o.NumCom == NCommande.Text && o.CodeArt == row.Cells[0].Value.ToString()).FirstOrDefault();
                                _detail.Qte = (_detail.Qte + _getLigne.QLiv) - _ql;
                                _getLigne.QLiv = _ql;
                            }
                        }
                    }
                    g.dc.SubmitChanges();
                    _tran.Complete();
                }
                catch
                {
                    MessageBox.Show("error dans l'enregistrement des livraisons");
                }
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            var _livraison = g.dc.Livraisons.Where(o => o.NumLiv == NLivraison.Text).FirstOrDefault();
            _livraison.EtatLiv = true;
            g.dc.SubmitChanges();
            Enregistrer.Enabled = false;
            Valider.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GestionCommandes gestionCommandes = new GestionCommandes();
            gestionCommandes.Show();
            this.Close();
        }

        private void NLivraison_TextChanged(object sender, EventArgs e)
        {
            if (NLivraison.Text.Any())
            {
                foreach (DataGridViewRow row in MyGridView.Rows)
                {
                    var _ligneLivraison = g.dc.LigneLivraisons.Where(o => o.NumLiv == NLivraison.Text && o.CodeArt == row.Cells[0].Value.ToString()).FirstOrDefault();
                    if (_ligneLivraison != null)
                    {
                        row.Cells[4].Value = _ligneLivraison.QLiv;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BonLivraisonForm bonLivraison = new BonLivraisonForm(NLivraison.Text);
            bonLivraison.Show();
        }
    }
}
