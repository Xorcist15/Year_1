package lien_1_a_1;

public class Commande {

    // propriétés
    private String reference;
    private String date;
    private float montant;
    private Client leClient;

    // Constructeur
    public Commande (String reference, String date, Client leClient){
        this.reference = reference;
        this.date = date;
        this.montant = 0;
        this.leClient = leClient;
    }

    public String getDate() {
        return date;
    }

    public Client getLeClient() {
        return leClient;
    }

    public float getMontant() {
        return montant;
    }

    public String getReference() {
        return reference;
    }

    public void setMontant(float montant) {
        this.montant = montant;
        this.leClient.cumulerCa(montant);
    }

    // toString
    @Override
    public String toString(){
        return 
                "\nReference: "    + this.reference      +
                "\nDate: "         + this.date           + 
                "\nMontant: "      + this.montant        + 
                "\nNom client: "   + leClient.getNom()   + 
                "\nVille client: " + leClient.getVille();
    }

}
