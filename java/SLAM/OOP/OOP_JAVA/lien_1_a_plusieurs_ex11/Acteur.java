package lien_1_a_plusieurs_ex11;

class Acteur{
    public String nom;
    private String prenom;

    public Acteur(String prenom, String nom){
        this.nom = nom;
        this.prenom = prenom;
    }

    public String getNom() {
        return nom;
    }
    public String getPrenom() {
        return prenom;
    }
}