using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Serialization
{
    [Serializable]
    internal class Etudiant
    {
        // props
        private string nom;
        private string prenom;

        // constructs
        public Etudiant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        // methods
        public override string ToString()
        {
            return this.nom + " " + this.prenom;
        }
    }
}
