package Composition;

public class Auteur {
    // props
    private int id;
    private String nom;
    private String prenom;

    // constructs
    public Auteur(int id, String n, String p){
        this.id = id;
        this.nom = n;
        this.prenom = p;
    }
     // Accesseurs
     public String getNom(){
        return this.nom;
     }
     public String getPrenom(){
        return this.prenom;
     }
}
