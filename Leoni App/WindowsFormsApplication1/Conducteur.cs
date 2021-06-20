using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Conducteur
    {
        string CIN, nom, prénom;
        decimal salaire;
        public Conducteur() { }
        public Conducteur(string CIN, string nom, string prénom, decimal salaire)
        {
            this.CIN = CIN;
            this.nom = nom;
            this.prénom = prénom;
            this.salaire = salaire;
        }
        public string GetCIN() { return CIN; }
        public string Getnom() { return nom; }
        public string Getprénom() { return prénom; }
        public decimal Getsalaire() { return salaire; }
        public void SetCIN(string CIN) { this.CIN = CIN; }
        public void Setnom(string nom) { this.nom = nom; }
        public void Setprénom(string prénom) { this.prénom = prénom; }
        public void Setsalaire(decimal salaire) { this.salaire = salaire; }
    }
}
