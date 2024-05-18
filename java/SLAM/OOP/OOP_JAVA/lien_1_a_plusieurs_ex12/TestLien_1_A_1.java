import java.time.LocalDate;

public class TestLien_1_A_1{
    public static void main(String[] args) {
        Client c = new Client("c1", "Coltrane", "Colmar");
        c.cumulerCa(200);

        Commande cmd = new Commande("1234", LocalDate.of(2020, 2, 12) , c);

        cmd.ajouterLigne(1, new Article("V1", "VTT", 300, 250, 0));
        cmd.ajouterLigne(2, new Article("V2", "VTC", 250, 200, 0));

        System.out.println(cmd.toString());
    }
}