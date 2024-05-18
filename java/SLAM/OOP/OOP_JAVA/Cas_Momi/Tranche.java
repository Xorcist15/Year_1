package Cas_Momi;

import java.util.ArrayList;

public class Tranche {
    private String libelle;     // nom de la tranche
    ArrayList<Offre> lesOffres;

    // constructs
    public Tranche(String libelle){
        this.libelle = libelle;
        this.lesOffres = new ArrayList<Offre>();
    }

    // getters setters
    public String getLibelle(){
        return this.libelle;
    }

    // methods
    public Offre offreLaMoinsChere(){
        
        Offre offre;

        if(lesOffres.size() == 0){
            offre = new Offre("** réservé au client **", 0);
        }
        else{
            // TODO : RETURN SMALLEST OFFER OBJECT
            offre = lesOffres.get(0);
            for(Offre off : lesOffres){
                if(off.getPrix() < offre.getPrix()){
                    offre = off;
                }
            }
        }
        return offre;
    }
    public void ajouterOffre(Offre o){
        this.lesOffres.add(o);
    }
}
