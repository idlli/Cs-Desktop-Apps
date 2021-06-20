using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Trans_cbale : Transport
    {
        string typecablage;
        int capacite;
        public Trans_cbale() : base() { }
        public Trans_cbale(string Nom, int code, Conducteur technicienResponsable, DateTime date_d_achat, decimal prix_d_achat, string typecablage, int capacite) : base(Nom, code, technicienResponsable, date_d_achat, prix_d_achat)
        {
            this.typecablage = typecablage;
            this.capacite = capacite;
        }
        public string Gettypecablage() { return typecablage; }
        public int Getcapacite() { return capacite; }
        public void Settypecablage(string typecablage) { this.typecablage = typecablage; }
        public void Setcapacite(int capacite) { this.capacite = capacite; }
    }
}
