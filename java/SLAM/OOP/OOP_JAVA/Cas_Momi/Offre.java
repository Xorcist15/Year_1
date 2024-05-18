package Cas_Momi;

public class Offre{
    private String nomEntreprise;   // nom entreprise
    private double prix;            // prix proposé

    // construct
    public Offre(String nomEnt, double prix){
        this.nomEntreprise = nomEnt;
        this.prix = prix;
    }
    // accessors
    public String getNomEntreprise(){
        return this.nomEntreprise;
    }
    public double getPrix(){
        return this.prix;
    }
    // methods
    @Override
    public String toString(){
        return this.nomEntreprise + " " + this.prix;
    }
}