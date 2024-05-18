using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TP_Serialization
{
    [Serializable]
    internal class Classe
    {
        // props
        private string nom;
        List<Etudiant> _lesEtudiants;
        public static List<Classe> lesClasses = new List<Classe>();

        // constructs
        public Classe(string nom)
        {
            this.nom = nom;
            _lesEtudiants = new List<Etudiant>();
            lesClasses.Add(this);
        }
        public static void addClasse(Classe c)
        {
            lesClasses.Add(c);
        }
        public String Nom
        {
            get => nom;
        }
        public void addEtudiant(Etudiant e)
        {
            _lesEtudiants.Add(e);
        }

        public static List<Classe> LesClasses
        {
            get => lesClasses;
        }


        // methods
        public List<Etudiant> LesEtudiants
        {
            get => _lesEtudiants;
        }

        public override string ToString()
        {
            return nom;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
