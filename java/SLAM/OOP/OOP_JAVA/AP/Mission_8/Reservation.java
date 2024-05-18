package AP.Mission_8;

import java.util.ArrayList;

public class Reservation {
    // props
    private int numero;                         // unused
    private String typeCarte;
    private ArrayList<Personne> lesPersonnes;
    private ArrayList<Vehicule> lesVehicules;
    private Vehicule leVehicule;
    private Traversee traversee;

    // constructs
    public Reservation(int numero, String typeCarte, Traversee traversee){
        this.numero = numero;
        this.typeCarte = typeCarte;
        this.traversee = traversee;
        lesPersonnes = new ArrayList<Personne>();
        lesVehicules = new ArrayList<Vehicule>();
    }
    // methods
    public void ajouterPersonne(
        int numero, 
        String nom, 
        String prenom, 
        String type,
        boolean referent, 
        float tarif
    ){
        if(this.traversee.getNbPassagers() > lesPersonnes.size()){
            lesPersonnes.add(
                new Personne(
                    numero, 
                    nom, 
                    prenom,
                    type, 
                    referent, 
                    tarif
                )
            );
        }
    }
    public void ajouterVehicules(
        String immatriculation,
        String modele,
        String categorie,
        float tarif){
            lesVehicules.add(
                new Vehicule(
                    immatriculation,
                    modele,
                    categorie,
                    tarif
                )
            );
    }
    public void setLeVehicule(
        String immatricule, 
        String modele, 
        String categorie, 
        float tarif
    ){
        this.leVehicule = new Vehicule(
            immatricule, 
            modele, 
            categorie, 
            tarif
        );
    }
    private float calculTotal(){
        float total = 0;
        for(Personne p : lesPersonnes){
            total += p.getTarif();
        }
        total += leVehicule.getTarif();
        return total;
    }    
    @Override
    public String toString(){
        String recap = "";
        recap += traversee.toString();
        recap += "Type de tarif : " + this.typeCarte + "\n\n";
        recap += "Les personnes\n";
        for (Personne p : lesPersonnes) {
            recap += p.toString();
        }
        recap += "\n";
        recap += "Les véhicules\n";
        recap += this.leVehicule.toString();

        float total = calculTotal();
        recap += String.format("\n%45s %11.2f €", "Total", total);

        return recap;
    }
}
