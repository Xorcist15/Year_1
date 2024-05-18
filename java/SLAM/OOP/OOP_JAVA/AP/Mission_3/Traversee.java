package AP.Mission_3;

import java.text.DecimalFormat;
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;

public class Traversee{
    // Declarations
    private int numero;
    private LocalDate dateDepart;
    private LocalTime heureDepart;
    private int duree;
    private int nbPassager;
    private int nbVehicules;
    private Bateau bateau;
    private Port lePortDepart;
    private Port lePortArrivee;

    public Traversee(int n, LocalDate dD, LocalTime hD, int d, int nbP, int nbV, Bateau b, Port pD, Port pA){
        this.numero = n;
        this.dateDepart = dD;
        this.heureDepart = hD;
        this.duree = d;
        this.nbPassager = nbP;
        this.nbVehicules = nbV;
        this.bateau = b;
        this.lePortDepart = pD;
        this.lePortArrivee = pA;
    }

    @Override
    public String toString(){

        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        DecimalFormat df = new DecimalFormat("#0.0");

        float pourcentP = (float) this.nbPassager/this.bateau.getNBP()*100;
        float pourcentV = (float) this.nbVehicules/this.bateau.getNBV()*100;

        return  "Traversée n°"+this.numero+" ("+this.lePortDepart.getNom()+" --> "+this.lePortArrivee.getNom()+")\n" +
                "Date : "+dtf.format(this.dateDepart)+"\n" +
                "Départ : "+this.heureDepart+"\n" +
                "Arrivée prévue : "+this.heureDepart.plusMinutes(this.duree)+" ("+this.duree+" minutes)\r\n" +
                "Bateau : "+this.bateau.getNom()+"\n" +
                "\n" +
                "Nombre de passagers : "+this.nbPassager+" (rempli à "+df.format(pourcentP)+" %)\n" +
                "Nombre de véhicules : "+this.nbVehicules+" (rempli à "+df.format(pourcentV)+" %)" +
                "\n";
    }
}