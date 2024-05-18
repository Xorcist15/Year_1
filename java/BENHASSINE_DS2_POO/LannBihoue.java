public class LannBihoue {
    public static void main(String[] args) {
        // jour 
        Journee jour = new Journee("vendredi", "12/04/2024");
        
        // les avions
        Avion a1 = new Avion("F-HOPX", "ATR", "72");
        Avion a2 = new Avion("F-HMLA", "Bombardier", "CRJ");
        Avion a3 = new Avion("F-GUMA", "Embraer", "ERJ-145");

        // afficher l'ensemble des arrivés de la journée
        System.out.println(jour.toString());

        // les vols
        Vol v1 = new Vol("AF747", "HOP!", "PARIS", "15:05", "16:10", a1);
        Vol v2 = new Vol("AF683", "HOP!", "LYON", "16:30", "17:45", a2);
        Vol v3 = new Vol("KL192", "KLM", "LILLE", "16:45", "18:15", a3);

        jour.ajoutVol(v1);
        jour.ajoutVol(v2);
        jour.ajoutVol(v3);

        // les retards
        v2.ajoutRetard(new Retard("trafic chargé", 30));
        v3.ajoutRetard(new Retard("panne avion", 60));
        v2.ajoutRetard(new Retard("orage", 15));

        // afficher l'ensemble des arrivés de la journée
        System.out.println(jour.toString());
        
        // affichage en sms
        System.out.println(v2.texteSMS());
        System.out.println(v3.texteSMS());

    }
}
