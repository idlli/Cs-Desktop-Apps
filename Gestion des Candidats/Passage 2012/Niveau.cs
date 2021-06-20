using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passage_2012
{
    class Niveau
    {
        int numNiv;
        string intitNiv;
        public Niveau() { }
        public Niveau(int numNiv, string intitNiv)
        {
            this.numNiv = numNiv;
            this.intitNiv = intitNiv;
        }
        public int GetnumNiv() { return numNiv; }
        public string GetintitNiv() { return intitNiv; }
        public void SetnumNiv(int numNiv) { this.numNiv = numNiv; }
        public void SetintitNiv(string intitNiv) { this.intitNiv = intitNiv; }
        public string toString() { return "Le filière : " + intitNiv + "est le niveau : " + numNiv + "année"; }
    }
}
