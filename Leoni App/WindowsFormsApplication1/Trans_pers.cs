using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Trans_pers : Transport
    {
        int placess, reserve;
        public Trans_pers() : base() { }
        public Trans_pers(string Nom, int code, Conducteur technicienResponsable, DateTime date_d_achat, decimal prix_d_achat, int placess, int reserve) : base(Nom, code, technicienResponsable, date_d_achat, prix_d_achat)
        {
            this.placess = placess;
            this.reserve = reserve;
        }
        public int Getplacess() { return placess; }
        public int Getreserve() { return reserve; }
        public void Setplacess(int places) { this.placess = places; }
        public void Setreserve(int reserve) { this.reserve = reserve; }
    }
}
