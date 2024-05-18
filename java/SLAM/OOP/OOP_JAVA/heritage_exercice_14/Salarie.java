package heritage_exercice_14;

import java.text.DecimalFormat;

public class Salarie {
    // props priv
    private int num;
    private String nom;
    private String fonction;

    // props prot
    protected float salaire;

    // constructs
    public Salarie(int n, String nom, String f, float s){
        this.num = n;
        this.nom = nom;
        this.fonction = f;
        this.salaire = s;
    }

    public String getNom(){
        return nom;
    }

    // methods public
    public float getSalaire(){
        return this.salaire;
    }

    @Override
    public String toString(){
        DecimalFormat df = new DecimalFormat("#0.00");
        String recap = "";
        // TODO, add the method
        recap += "Numéro : " + this.num + "\n";
        recap += "Nom : " + this.nom + "\n";
        recap += "Fonction : " + this.fonction + "\n";
        recap += "Salaire de base : " + df.format(getSalaire()) + " €\n";
        return recap;
    }
}
