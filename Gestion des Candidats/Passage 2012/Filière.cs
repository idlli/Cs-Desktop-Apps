using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passage_2012
{
    class Filière
    {

        int codeFil;
        string intitFil;
        public Filière() { }
        public Filière(int codeFil, string intitFil)
        {
            this.codeFil = codeFil;
            this.intitFil = intitFil;
        }
        public int GetcodeFil() { return codeFil; }
        public string GetintitFil() { return intitFil; }
        public void SetcodeFil(int codeFil) { this.codeFil = codeFil; }
        public void SetintitFil(string intitFil) { this.intitFil = intitFil; }
        public string toString() { return "Le filière : " + intitFil + "est le code : " + codeFil; }
    }
}
