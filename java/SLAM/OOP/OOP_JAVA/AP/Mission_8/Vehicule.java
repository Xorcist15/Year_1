package AP.Mission_8;

public class Vehicule {
    // props
    private String immatriculation;
    private String modele;
    private String categorie;
    private float tarif;

    // constructs
    public Vehicule(
        String immatriculation, 
        String modele, 
        String categorie, 
        float tarif){
            this.immatriculation = immatriculation;
            this.modele = modele;
            this.categorie = categorie;
            this.tarif = tarif;
    }

    // methods
    public float getTarif(){
        return this.tarif;
    }

    @Override
    public String toString(){
        String recap = String.format(
            "%s %s %s %11.2f €\n",    
            this.immatriculation,
            this.modele,
            this.categorie,
            this.tarif
        );

        return recap;
    }
}
