using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passage_2012
{
    class Inscription
    {
        int numDossier;
        DateTime dateInscription;
        Candidat candidat;
        Niveau niveau;
        Filière[] filiers = new Filière[3];
        public Inscription() { }
        public Inscription(int numDossier, DateTime dateInscription, Candidat candidat, Niveau niveau, Filière[] filiers)
        {
            this.numDossier = numDossier;
            this.dateInscription = dateInscription;
            this.candidat = candidat;
            this.niveau = niveau;
            this.filiers = filiers;
        }
        public int GetnumDossier() { return numDossier; }
        public DateTime GetdateInscription() { return dateInscription; }
        public Candidat Getcandidat() { return candidat; }
        public Niveau Getniveau() { return niveau; }
        public Filière[] Getfiliers() { return filiers; }
        public void SetnumDossier(int numDossier) { this.numDossier = numDossier; }
        public void SetdateInscription(DateTime dateInscription) { this.dateInscription = dateInscription; }
        public void Setcandidat(Candidat candidat) { this.candidat = candidat; }
        public void Setniveau(Niveau niveau) { this.niveau = niveau; }
        public void Setfiliers(Filière[] filiers) { this.filiers = filiers; }
        public string toString() { return $"numDossier : {numDossier}, dateInscription : {dateInscription}, candidat : {candidat.toString()}, niveau : {niveau.toString()}, filiers 1 : {filiers[0].toString()}, filiers 2 : {filiers[1].toString()}, filiers 3 : {filiers[2].toString()}"; }
    }
}
