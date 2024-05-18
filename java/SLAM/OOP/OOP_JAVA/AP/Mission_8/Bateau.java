package AP.Mission_8;

public class Bateau {
    
    private String nom;
    private int nbPassager;
    private int nbVoiture;
    
    //Constructeur
    public Bateau(
        String nom, 
        int nbPassager, 
        int nbVehicules){
            this.nom = nom;
            this.nbPassager = nbPassager;
            this.nbVoiture = nbVehicules;
    }
    
    public String getNom(){
        return this.nom;   
    }

    public int getNBP(){
        return this.nbPassager;
    }
    
    public int getNBV(){
        return this.nbVoiture;      
    }
}
 
