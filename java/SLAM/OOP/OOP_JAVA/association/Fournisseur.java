package association;

public class Fournisseur {
    private int id;
    private String nom;
    private String mel;

    public Fournisseur(int id, String nom, String mel){
        this.id = id;
        this.nom = nom;
        this.mel = mel;
    }

    public String getNom(){
        return this.nom;
    }
}
