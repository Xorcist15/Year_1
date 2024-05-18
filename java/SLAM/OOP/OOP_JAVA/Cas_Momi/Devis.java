package Cas_Momi;

import java.util.ArrayList;

public class Devis {
    // props
    private String codeDevis;           // Constitué de l'année et d'un n° séquentiel (ex : 2018-07) 
    private String nomClient;
    ArrayList<Tranche> lesTranches;     // Contient les offres de toutes les tranches d'un projet

    // constructs
    public Devis(String codeDevis, String nomClient){
        this.codeDevis = codeDevis;
        this.nomClient = nomClient;
        this.lesTranches = new ArrayList<Tranche>();  
    }
    // methods
    public void ajouterTranche(Tranche t){
        this.lesTranches.add(t);
    }
    private double calculerTotalDevis(){
        double total = 0;
        for(Tranche T : lesTranches){
            total += T.offreLaMoinsChere().getPrix();
        }
        return total;
    }
    private double calculerHonoraires(){
        return calculerTotalDevis() * 0.07;
    }
    private double calculerCoutTotal(){
        return calculerTotalDevis()+calculerHonoraires();
    }
    @Override
    public String toString(){
        String devis = "";
        devis += String.format("%25s %35s\n", "Devis n° " + this.codeDevis, "Client : " + this.nomClient);
        devis += String.format("%-30s %-30s %s\n","Tranches", "Entreprises", "Montants");
        devis += "------------------------------------------------------------------------" + "\n";
        for(Tranche T : lesTranches){
            devis += String.format("%-30s %-30s %10.2f\n",
            T.getLibelle(), 
            T.offreLaMoinsChere().getNomEntreprise(),
            T.offreLaMoinsChere().getPrix());
        }
        devis += "------------------------------------------------------------------------" + "\n";
        devis += "\n";
        devis += String.format("%40s %20.2f\n", "Total des travaux :", calculerTotalDevis());
        devis += String.format("%40s %20.2f\n", "Honoraires MOMI (7%) :", calculerHonoraires());
        devis += "------------------------------------------------------------------------" + "\n";
        devis += String.format("%40s %20.2f\n", "Coût total du projet :", calculerCoutTotal());
        return devis;
    }
}
