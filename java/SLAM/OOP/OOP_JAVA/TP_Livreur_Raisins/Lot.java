package TP_Livreur_Raisins;

public class Lot {
    // props
    private int num;
    private String cepage;
    private float poids;

    // constructs
    public Lot(int num, String cepage, float poids){
        this.num = num;
        this.cepage = cepage;
        this.poids = poids;
    }

    // methods
    public float getPoids() {
        return poids;
    }

    @Override
    public String toString(){
        String recap;

        recap = 
            String.valueOf(this.num) + 
            " " + 
            this.cepage + 
            " " + 
            this.poids + 
            " kg\n";

        return recap;
    }
}
