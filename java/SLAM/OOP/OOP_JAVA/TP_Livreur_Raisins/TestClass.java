package TP_Livreur_Raisins;

public class TestClass {
    public static void main(String[] args) {
        Livreur l = new Livreur(1, "Ying");
        Cooperateur c = new Cooperateur(2 , "Yang", 20);

        // livreur
        l.ajouterLot(1, "liv1", 10);
        l.ajouterLot(2, "liv2", 20);
        l.ajouterLot(3, "liv3", 30);

        // cooperator
        c.ajouterLot(4, "coop1", 40);
        c.ajouterLot(5, "coop2", 50);
        c.ajouterLot(6, "coop3", 60);
        c.ajouterLot(7, "coop4", 70);
        c.ajouterLot(8, "coop5", 80);

        System.out.println(l.toString());
        System.out.println(c.toString());
    }
}
