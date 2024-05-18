package lien_1_a_1;

public class TestLien_1_A_1{
    public static void main(String[] args) {

        //Client c1 = new Client("C1", "hello wolrd", "colmar");

        //System.out.println(c1.toString());

        //Commande com1, com2;

        //com1 = new Commande ("Com1", "16/2/2024", c1);
        //com2 = new Commande ("Com2", "16/2/2024", c1);

        //com1.setMontant(1000f);
        //com2.setMontant(500f);

        //System.out.println(com1.toString());
        //System.out.println(com2.toString());

        //c1.setVille("Brest");

        //System.out.println(com1.toString());
        //System.out.println(com2.toString());

        //com2.setMontant(600f);

        //System.out.println(com2.toString());

        //System.out.println(c1.toString());

        Article a1 = new Article("V1", "VTT", 300f, 300f, 10);

        LigneCommande lc1 = new LigneCommande(1, a1);

        System.out.println(lc1.toString());
    }
}