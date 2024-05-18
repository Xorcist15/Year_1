package TP_Ouistréham;

public class ZoneStockage {
    // props
    private String nom;
    private int capaDispo;
    private int capaMax;
    
    // constructeur
    public ZoneStockage(
        String nom, 
        int capaDispo, 
        int capaMax){
            // valoriser tous les attributs
            this.nom = nom;
            this.capaDispo = capaDispo;
            this.capaMax = capaMax;
    }

    // Accesseurs
    // (lecture)
    public String getNom(){
        return this.nom;
    }
    public int getCapaDispo(){
        return this.capaDispo;
    }


    // méthodes
    public void stocker(int quantite){
        // met à jour capaDispo avec la quantité reçue
        this.capaDispo -= quantite;
    }
    public boolean estRemplie(){
        // indique si la zone est remplie
        return this.capaDispo == 0;
    }
}
