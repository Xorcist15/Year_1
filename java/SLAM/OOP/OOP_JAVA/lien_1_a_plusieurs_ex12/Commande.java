import java.time.LocalDate;
import java.util.ArrayList;
import java.text.DecimalFormat;

public class Commande {

    // propriétés
    private String reference;
    private LocalDate date;
    private float montant;
    private Client leClient;
    private ArrayList<LigneCommande> lesLignes;

    // Constructeur
    public Commande (String reference, LocalDate date, Client leClient){
        this.reference = reference;
        this.date = date;
        this.montant = 0;
        this.leClient = leClient;
        this.lesLignes = new ArrayList<>();
    }

    public LocalDate getDate() {
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

    public void ajouterLigne(int quantite, Article article){
        LigneCommande ligne = new LigneCommande(quantite, article);
        this.lesLignes.add(ligne);
        // incrémentation du chiffre d'affaires du client
        this.leClient.cumulerCa(ligne.MontantLigne());
        this.montant += ligne.MontantLigne();
    }

    // toString
    @Override
    public String toString(){
        DecimalFormat df = new DecimalFormat("#0.00");
        String descrip;
        descrip =         "--------------------------------------------------------";
        descrip +=      "\n                        Commande";
        descrip +=      "\n--------------------------------------------------------";
        descrip +=      "\n\tReference: "      + this.reference;
        descrip +=      "\n\tDate: "           + this.date;
        descrip +=      "\n--------------------------------------------------------";
        descrip +=      "\n\tNom client: "     + leClient.getReference();
        descrip +=      "\n\t\tNom client: "   + leClient.getNom();
        descrip +=      "\n--------------------------------------------------------";
        for(LigneCommande ligne : lesLignes){
            descrip +=  "\n"+ligne.toString();
        }
        descrip +=      "\n--------------------------------------------------------";
        descrip +=      "\n\t\t\t\tTotal: "      + df.format(this.montant)+"€";
        descrip +=      "\n--------------------------------------------------------";
        descrip +=      "\nNouveau chiffre d'affaires du client: " + df.format(this.leClient.getChiffreAffaires())+"€";
        descrip +=      "\n--------------------------------------------------------\n";

        return descrip; 
    }
}
