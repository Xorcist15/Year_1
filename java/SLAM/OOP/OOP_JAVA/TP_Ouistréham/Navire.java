package TP_Ouistréham;

public class Navire {
    private String noLoyds;
    private String nom;
    private String libelleFret;
    private int quantiteFret;

    public Navire(
        String noLoyds, 
        String nom, 
        String libelleFret, 
        int quantiteFret){
            // valoriser tous les attributs
            this.noLoyds = noLoyds;
            this.nom = nom;
            this.libelleFret = libelleFret;
            this.quantiteFret = quantiteFret;
    }

    // Accesseurs
    // (en lecture)
    public String getNom(){
        return this.nom;
    }
    public String getlibelleFret(){
        return this.libelleFret;
    }
    public int getquantiteFret(){
        return this.quantiteFret;
    }

    public void decharger(int quantite){
        // diminue la quantité du Fret
        this.quantiteFret -= quantite;
    }
    public boolean estDecharge(){
        // indique si la quantité est égal à 0
        return this.quantiteFret == 0;
    }
}
