using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission6
{
    internal class Bateau
    {
        private string nom;
        private float longueur;
        private float largeur;
        private float vitesse;
        private int nbPassager;
        private int nbVoiture;
        private string dateProchaineVisite;

        //Constructeur
        public Bateau(string n, 
            float lo, 
            float la, 
            float vi, 
            int nbP, 
            int nbV){

                this.nom = n;
                this.longueur = lo;
                this.largeur = la;
                this.vitesse = vi;
                this.nbPassager = nbP;
                this.nbVoiture = nbV;
                this.dateProchaineVisite = null;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public int GetNBP()
        {
            return this.nbPassager;
        }
        public int GetNBV()
        {
            return this.nbVoiture;
        }
        public void SetDateProchaineVisite(string value)
        {
            this.dateProchaineVisite = value;
        }
        public bool estPlusRapide(Bateau bateau)
        {
            return this.vitesse > bateau.vitesse;
        }
    }
}
