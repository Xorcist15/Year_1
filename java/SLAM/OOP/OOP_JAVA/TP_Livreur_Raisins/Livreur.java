package TP_Livreur_Raisins;

import java.util.ArrayList;

public class Livreur {
    // props
    private int num;
    private String nom;
    ArrayList <Lot> lesLots;

    // constructs
    public Livreur(int num, String nom){
        this.num = num; 
        this.nom = nom;
        lesLots = new ArrayList<Lot>();
    }
    protected float getPoidsTotal(){
        float poids = 0;
        for(Lot l : lesLots){
            poids += l.getPoids();
        }
        return poids;
    }
    public void ajouterLot(int num, String cepage, float poids){
        lesLots.add(new Lot(num, cepage, poids));
    }
    @Override
    public String toString(){
        String recap = this.num + 
        " " +
        this.nom +
        " " +
        this.getPoidsTotal() + 
        " kg\n";
        for(Lot l : lesLots){
            recap += "\t" + l.toString();
        }
        return recap;
    }
}
