package AP.Mission_9;

public class Vehicule {
    // props
    private int numero;
    private String immatriculation;
    private String modele;
    private String categorie;
    private float tarif;

    // constructs
    public Vehicule(
        int numero,
        String immatriculation, 
        String modele, 
        String categorie, 
        float tarif){
            this.numero = numero;
            this.immatriculation = immatriculation;
            this.modele = modele;
            this.categorie = categorie;
            this.tarif = tarif;
    }

    // methods
    public float getTarif(){
        return this.tarif;
    }
    public int getNumero(){
        return this.numero;
    }
    public String getImmatricule(){
        return this.immatriculation;
    }
    public String getModele(){
        return this.modele;
    }
    public String getCategorie(){
        return this.categorie;
    }
    @Override
    public String toString(){
        String recap = String.format(
            "%s %s %s %s %11.2f €\n",
            this.numero,
            this.immatriculation,
            this.modele,
            this.categorie,
            this.tarif
        );
        return recap;
    }
}
