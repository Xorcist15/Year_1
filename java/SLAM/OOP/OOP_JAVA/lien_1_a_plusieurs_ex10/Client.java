package lien_1_a_plusieurs_ex10;

import java.text.DecimalFormat;

public class Client {

    private String reference;
    private String nom;
    private String ville;
    private float chiffreAffaires;

    public Client(
            String reference,
            String nom,
            String ville
    ){
        this.reference = reference;
        this.nom = nom;
        this.ville = ville;
        this.chiffreAffaires = 0;
    }

    public Client(String reference){
        this.reference = reference;
        this.nom = "anonyme";
        this.ville = "inconnue";
        this.chiffreAffaires = 0;
    }

    public void cumulerCa(float chiffreAffaires){
        this.chiffreAffaires += chiffreAffaires;
    }


    public String toString(){
        DecimalFormat monnaie = new DecimalFormat("0.00");
        return "----------------------------------------\n" +
                " Référence : " + this.reference + "\n" +
                " Nom : " + this.nom + "\n" +
                " Ville : " + this.ville + "\n" +
                " Chiffre d'affaires : " + monnaie.format(this.chiffreAffaires) + "€\n" +
                "----------------------------------------\n";
    }

    public void setVille(String ville) {
        this.ville = ville;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getReference() {
        return this.reference;
    }

    public String getNom(){
        return this.nom;
    }

    public String getVille(){
        return this.ville;
    }

    public float getChiffreAffaires(){
        return this.chiffreAffaires;
    }



}
