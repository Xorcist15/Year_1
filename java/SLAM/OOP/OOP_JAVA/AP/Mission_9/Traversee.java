package AP.Mission_9;

import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;

public class Traversee{
    // props
    private int numero;
    private LocalDate dateDepart;
    private LocalTime heureDepart;
    private int nbPassager;
    private int nbVehicules;
    private Bateau bateau;
    private Port lePortDepart;
    private Port lePortArrivee;

    public Traversee(
        int numero, 
        LocalDate dateDepart, 
        LocalTime heureDepart,
        int nbPassager,
        int nbVehicules,
        Bateau bateau, 
        Port lePortDepart, 
        Port lePortArrivee){
            this.numero = numero;
            this.dateDepart = dateDepart;
            this.heureDepart = heureDepart;
            this.nbPassager = nbPassager;
            this.nbVehicules = nbVehicules;
            this.bateau = bateau;
            this.lePortDepart = lePortDepart;
            this.lePortArrivee = lePortArrivee;
    }
    public int getNbPassagers(){
        return this.nbPassager;
    }
    public Port getPortDepart(){
        return this.lePortDepart;
    }
    public Port getPortArrivee(){
        return this.lePortArrivee;
    }
    public LocalDate getDateDepart(){
        return this.dateDepart;
    }
    public LocalTime getHeureDepart(){
        return this.heureDepart;
    }
    @Override
    public String toString(){
        // Define the desired date format
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        
        // Format the LocalDate object using the formatter
        String date = this.dateDepart.format(formatter);

        return  "\nRéservation n°: " + this.numero + "\n" +
                "Ile : Groix" + "\n" +
                "Liaison : " + this.lePortDepart.getNom() + " ==> " + this.lePortArrivee.getNom() + "\n" +
                // change date format to DD:MM/YYYY
                "Date : " + date + "\n" + 
                "Heure : " + this.heureDepart + "\n\n";
    }
}