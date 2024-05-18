import java.util.ArrayList;

public class Vol {
    // props
    private String code;
    private String compagnie;
    private String provenance;
    private String heureDepart;
    private String heureArrivee;
    private boolean annule;
    private Avion avion;
    private ArrayList<Retard> lesRetards;

    // constructs
    public Vol(String cd, String comp, String prov, String hD, String hA, Avion av){
        this.code = cd;
        this.compagnie = comp;
        this.provenance = prov;
        this.heureDepart = hD;          // format "HH:MM" 
        this.heureArrivee = hA;         // format "HH:MM"
        this.annule = false;
        this.avion = av;
        lesRetards = new ArrayList<Retard>();
    }

    // ajoute un retard à la collection des retard 
    public void ajoutRetard(Retard r){
        this.lesRetards.add(r);
    }

    // retourne le cumul en minutes du retard
    private int totalRetard(){
        int totalMinutes = 0;
        for(Retard r : lesRetards){
            totalMinutes += r.getDuree();
        }
        return totalMinutes;
    }

    public void annuler(){
        this.annule = true;
    }

    public String toLine(){
        String ligne = "";
        ligne += this.heureDepart + "\t";
        ligne += this.provenance + "\t";
        ligne += this.compagnie + "\t";
        ligne += this.code + "\t";
        ligne += this.heureArrivee + "\t";
        if(annule){
            ligne += "Annulé";
        } else {
            if(totalRetard() > 0){
                ligne += "Retardé de " + totalRetard() + " minutes";
            } else {
                ligne += "A l'heure";
            }
        }
        
        ligne += "\n";
        return ligne;
    }

    // partie n'est pas à traiter
    public String texteSMS(){
        String sms = "";
        sms += this.provenance + " ==> " + "LORIENT   " + "(" + this.compagnie + " " + this.code + ")\n" ;
        sms += this.avion.toString();
        sms += this.heureDepart + " ==> " + this.heureArrivee + "\n";
        if(annule){
            sms += "Annulé";
        } else {
            if(totalRetard() > 0){
                sms += "Retardé de " + totalRetard() + " minutes : \n";
                for(Retard r : lesRetards){
                    sms += "\t==> " + r.toString();
                }
            } else {
                sms += "A l'heure";
            }
        }
        sms += "\n";
        return sms;
    }
}