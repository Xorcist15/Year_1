package clientexercice;

public class Client_Main {
    public static void main(String[] args) {
        // Client client1 = new Client("CLI51", "Coltrane", "Lyon", 14627);
        Client client1 = new Client("CLI51", "Coltrane", "Lyon");
        Client client2 = new Client("SPG12");

        System.out.println(client1);
        System.out.println(client2);

        client1.cumulerCa(100);

        client2.cumulerCa(260);
        client2.setNom("Spongebob");
        client2.setVille("Brest");

        System.out.println(client1);
        System.out.println(client2);
    }
}
