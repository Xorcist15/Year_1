using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Fichiers_Sequentiels
{
    internal class Etudiant
    {
        private String numero;
        private String nom;
        private String prenom;
        public static List<Etudiant> Etudiants = new List<Etudiant>();

        public Etudiant(string num, string nom, string prenom)
        {
            this.numero = num;
            this.nom = nom;
            this.prenom = prenom;
        }
        public String Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public static void AddEtudiant(string num, string nom, string prenom)
        {
            Etudiants.Add(new Etudiant(num, nom, prenom)) ;
        }

        public override string ToString() 
        {
            return "Numéro: " + this.numero + "\n" +
                    "Nom: " + this.nom + "\n" +
                    "Prénom: " + this.prenom;
        }
    }
}
