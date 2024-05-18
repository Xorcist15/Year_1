import java.util.ArrayList;

public class Journee {
    // props
    private String jourSemaine;
    private String date;                // format "DD/MM/YYYY"  
    private ArrayList<Vol> lesArrivees; 
    
    // constructs
    public Journee(String jourSemaine, String date){
        this.jourSemaine = jourSemaine;
        this.date = date;
        this.lesArrivees = new ArrayList<Vol>();
    }

    // ajouter vols dans cette journée
    public void ajoutVol(Vol v){
        this.lesArrivees.add(v);
    }

    @Override
    public String toString(){
        String recap = "";
        recap += "Arrivées du " + this.jourSemaine + " " + this.date + "\n";
        if(lesArrivees.size() > 0){
            for(Vol v : lesArrivees){
                recap += v.toLine();
            }
        } else {
            recap += "Aucun vol n'est encore prévu pour la journée\n";
        }
        return recap;
    }
}
