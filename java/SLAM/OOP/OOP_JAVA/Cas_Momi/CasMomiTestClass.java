package Cas_Momi;

public class CasMomiTestClass {
    public static void main(String[] args) {
        Devis devis = new Devis("2014-07", "Laurent De Wilde");
        
        Tranche terrasement = new Tranche("Terrassement – viabilisation");
        terrasement.ajouterOffre(new Offre("SARL Balourd", 426.06));

        Tranche maconnerie = new Tranche("Maçonnerie");
        maconnerie.ajouterOffre(new Offre("SARL Elletru", 17920.09));

        Tranche charpente = new Tranche("Charpente");
        charpente.ajouterOffre(new Offre("Ets Duclou", 5352.87));

        Tranche couverture = new Tranche("Couverture – zinguerie");
        couverture.ajouterOffre(new Offre("SARL Lagouttière", 8848.72));

        Tranche menuiserie = new Tranche("Menuiserie");
        menuiserie.ajouterOffre(new Offre("Desplanches et Cies", 4179.53));

        Tranche platerie = new Tranche("Plâtrerie – Faïences");
        platerie.ajouterOffre(new Offre("SARL Lachaud", 5834.00));

        Tranche isolation = new Tranche("Isolation");

        Tranche carrelage = new Tranche("Carrelage");

        Tranche plomberie = new Tranche("Plomberie");
        plomberie.ajouterOffre(new Offre("Ets Cacouleplus", 2426.45));

        Tranche chauffage = new Tranche("Chauffage");
        chauffage.ajouterOffre(new Offre("SARL Vitochau", 3558.19));

        Tranche electricite = new Tranche("Electricité");
        electricite.ajouterOffre(new Offre("Ets Ducourant", 1824.97));

        Tranche peintures = new Tranche("Peintures – sols");
        peintures.ajouterOffre(new Offre("SARL Lachaud", 5640.61));

        devis.ajouterTranche(terrasement);
        devis.ajouterTranche(maconnerie);
        devis.ajouterTranche(charpente);
        devis.ajouterTranche(couverture);
        devis.ajouterTranche(menuiserie);
        devis.ajouterTranche(platerie);
        devis.ajouterTranche(isolation);
        devis.ajouterTranche(carrelage);
        devis.ajouterTranche(plomberie);
        devis.ajouterTranche(chauffage);
        devis.ajouterTranche(electricite);
        devis.ajouterTranche(peintures);
        
        System.out.println(devis.toString());
    }
}
