using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Transport
    {
        string type;
        int code;
        Conducteur conducteurResponsable;
        DateTime date_d_achat;
        decimal prix_d_achat;
        public Transport() { }
        public Transport(string type, int code, Conducteur conducteurResponsable, DateTime date_d_achat, decimal prix_d_achat)
        {
            this.type = type;
            this.code = code;
            this.conducteurResponsable = conducteurResponsable;
            this.date_d_achat = date_d_achat;
            this.prix_d_achat = prix_d_achat;
        }
        public string Gettype() { return type; }
        public int Getcode() { return code; }
        public Conducteur GetconducteurResponsable() { return conducteurResponsable; }
        public DateTime Getdate_d_achat() { return date_d_achat; }
        public decimal Getprix_d_achat() { return prix_d_achat; }
        public void Settype(string type) { this.type = type; }
        public void Setcode(int code) { this.code = code; }
        public void SetconducteurResponsable(Conducteur conducteurResponsable) { this.conducteurResponsable = conducteurResponsable; }
        public void Setdate_d_achat(DateTime date_d_achat) { this.date_d_achat = date_d_achat; }
        public void Setprix_d_achat(decimal prix_d_achat) { this.prix_d_achat = prix_d_achat; }
    }
}
