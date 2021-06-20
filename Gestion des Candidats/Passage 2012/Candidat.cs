using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passage_2012
{
    class Candidat
    {

        int cne;
        string nom, prenom, nivScolaire;
        char sexe;
        DateTime dateNaiss;
        public Candidat() { }
        public Candidat(int cne, string nom, string prenom, string nivScolaire, char sexe, DateTime dateNaiss)
        {
            this.cne = cne;
            this.nom = nom;
            this.prenom = prenom;
            this.nivScolaire = nivScolaire;
            this.sexe = sexe;
            this.dateNaiss = dateNaiss;
        }
        public int Getcne() { return cne; }
        public string Getnom() { return nom; }
        public string Getprenom() { return prenom; }
        public string GetnivScolaire() { return nivScolaire; }
        public char Getsexe() { return sexe; }
        public DateTime GetdateNaiss() { return dateNaiss; }
        public void Setcne(int cne) { this.cne = cne; }
        public void Setnom(string nom) { this.nom = nom; }
        public void Setprenom(string prenom) { this.prenom = prenom; }
        public void SetnivScolaire(string nivScolaire) { this.nivScolaire = nivScolaire; }
        public void Setsexe(char sexe) { this.sexe = sexe; }
        public void SetdateNaiss(DateTime dateNaiss) { this.dateNaiss = dateNaiss; }
        public string toString() { return $"cne : {cne}, nom : {nom}, prenom : {prenom}, nivScolaire : {nivScolaire}, sexe : {sexe}, dateNaiss : {dateNaiss}"; }
    }
}
