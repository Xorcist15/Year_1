public class Retard {
     // props
     private String motif;
     private int duree;         // en minutes

     // constructs
     public Retard(String motif, int duree){
        this.motif = motif;
        this.duree = duree;
     }

     // méthodes
     public int getDuree(){
        return this.duree;      // en minutes
     }

     @Override
     public String toString(){
        return this.motif + " ("+ String.valueOf(this.duree) +" minutes)\n";
     }
}
