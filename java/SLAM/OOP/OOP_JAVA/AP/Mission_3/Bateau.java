package AP.Mission_3;

import java.text.DecimalFormat;

public class Bateau {
    
    private String nom;
    private float longueur;
    private float largeur;
    private float vitesse;
    private int nbPassager;
    private int nbVoiture;
    private String dateProchaineVisite;
    
    
    //Constructeur
    public Bateau(String n, float lo, float la, float vi,int nbP, int nbV){
        this.nom = n;
        this.longueur = lo;
        this.largeur = la;
        this.vitesse = vi;
        this.nbPassager = nbP;
        this.nbVoiture = nbV;
        this.dateProchaineVisite = null;
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
    
    public void setDateProchaineVisite(String d){
        this.dateProchaineVisite = d;
    }
    
    @Override
    public String toString(){

        DecimalFormat fKm = new DecimalFormat("#0.0");
        DecimalFormat fNds = new DecimalFormat("#0");

        String date;

        if(this.dateProchaineVisite == null){
             date = "Non encore prévue";
        }else{
             date = this.dateProchaineVisite;
        }
        String ChaineCarac;

            ChaineCarac = "\n"+this.nom; // enlevé le 2éme retour à la ligne  
            ChaineCarac += "\n\tLongueur : "+this.longueur + " m";
            ChaineCarac += "\n\tLargeur : "+this.largeur + " m";
            ChaineCarac += "\n\tCapacité : "+this.nbPassager+" passagers et "+this.nbVoiture+" véhicules";
            ChaineCarac += "\n\tVitesse de croisière : "+fNds.format(this.vitesse) + " noeuds ("+fKm.format(this.vitesse * 1.852)+" km/h)" ;
            ChaineCarac += "\n\tDate de prochaine visite : "+date;

        return ChaineCarac;
    }
    
    // changer le type de retour de cette fonction de String à void (moins d'opérations à faire)
    public boolean estPlusRapide(Bateau bateau){

        if(this.vitesse > bateau.vitesse){
            return true;
        }
        else{
            return false;
        }
    }
}
 
