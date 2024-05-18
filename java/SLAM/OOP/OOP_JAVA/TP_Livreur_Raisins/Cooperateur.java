package TP_Livreur_Raisins;

public class Cooperateur extends Livreur {
    // props
    private int poucentage;

    // constructs
    public Cooperateur(int num, String nom, int poucentage){
        super(num, nom); // calls constructor of super class, to create object, does not create a super class object
        this.poucentage = poucentage;
    }

    // methods
    public float getProductionTotale(){
        return this.getPoidsTotal() * this.poucentage / 100;
    }

    @Override
    public String toString(){
        String recap = super.toString();
        recap += getProductionTotale() + " %\n";
        return recap;
    }
}
