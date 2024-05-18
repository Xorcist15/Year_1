using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mission6
{
    internal class Traversee
    {
        private int id;
        private string date;
        private string heureDepart;
        private int duree;
        private int distance;
        private int nombrePassagers;
        private int nombreVehicules;
        private Port lePortDepart;
        private Port lePortArrivee;
        private Bateau leBateau;

        public Traversee(
            int id,
            string date,
            string heureDepart, 
            int duree, 
            int distance, 
            int nombrePassagers, 
            int nombreVehicules, 
            Port lePortDepart, 
            Port lePortArrivee, 
            Bateau leBateau)
        {
                this.id = id;
                this.date = date;
                this.heureDepart = heureDepart;
                this.duree = duree;
                this.distance = distance;
                this.nombrePassagers = nombrePassagers;
                this.nombreVehicules = nombreVehicules;
                this.lePortDepart = lePortDepart;
                this.lePortArrivee = lePortArrivee;
                this.leBateau = leBateau;
        }
        public string GetDate()
        {
            return this.date;
        }
        public int GetID()
        {
            return this.id;
        }
        public string GetHeureDepart()
        {
            return this.heureDepart;
        }
        public Port GetPortDepart()
        {
            return this.lePortDepart;
        }
        public Port GetPortArrivee()
        {
            return this.lePortArrivee;
        }

        private string calculerHeure()
        {
            DateTime dt = new DateTime(2024, 04, 04, 13, 45, 00);
            DateTime arrivee = dt.AddMinutes(30);
            Console.Write(arrivee.ToString());

            // Parse heure de départ
            string[] heure_min = this.heureDepart.Split(':');
            int heures = int.Parse(heure_min[0]);
            int minutes = int.Parse(heure_min[1]);

            // calcul de l'heure d'arrivée
            int total_min = (heures * 60) + minutes + this.duree;
            heures = total_min / 60;
            minutes = total_min % 60;

            // concaténation de heure et minutes
            string strMinutes = "";
            string time = "";

            // logique pour ajuster le format d'affichage de l'heure
            if (minutes < 10)
            {
                strMinutes = minutes.ToString();
                strMinutes = "0" + strMinutes;
                time = heures + ":" + strMinutes;
            } 
            else
            {
                time = heures + ":" + minutes;
            }

            return time;
        }
        public override string ToString()
        {
            string  recap = "Traversée numéro°" + this.id + " \t("+ this.lePortDepart.GetNom() +" --> " + this.lePortArrivee.GetNom() + ")\n";
                    recap += "Date : " + this.date + "\n";
                    recap += "Heure de départ : " + this.heureDepart + "\n";
                    recap += "Arrivée prévue : " + calculerHeure() + " ("+this.duree+" minutes)\n";
                    recap += "Bateau : " + this.leBateau.GetNom() + "\n";
                    recap += "\nPlaces disponibles :" + "\n";
                    recap += "\t" + this.nombrePassagers + " passagers \n";
                    recap += "\t" + this.nombreVehicules + " véhicules \n";

            return recap;
        }
    }
}
