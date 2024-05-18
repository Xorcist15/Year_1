package AP.Mission_8;

import java.time.LocalDate;
import java.time.LocalTime;

public class Mission_8 {
    public static void main(String[] args) {
        Bateau bateau = new Bateau(
            "Ile de Groix", 
            450,
            32);

        Port portDepart = new Port("Lorient");
        Port portArrivee = new Port("Port Tudy");

        LocalDate dateDepart = LocalDate.of(2016, 3, 1);
        LocalTime heureDepart = LocalTime.of(13, 45);
        
        Traversee traversee = new Traversee(
            35464134, 
            dateDepart, 
            heureDepart,
            4,
            1,
            bateau, 
            portDepart, 
            portArrivee);

        Reservation reservation = new Reservation(
            1, 
            "Carte fréquence", 
            traversee
        );

        reservation.ajouterPersonne(
            1, 
            "Dupont", 
            "Arnaud", 
            "Adulte", 
            true, 
            7.5f
        );

        reservation.ajouterPersonne(
            2, 
            "Dupont", 
            "Sophie", 
            "Adulte", 
            false, 
            7.5f
        );
        
        reservation.ajouterPersonne(
            3, 
            "Dupont", 
            "Clément", 
            "Enfant", 
            false, 
            3.75f
        );

        reservation.ajouterPersonne(
            4, 
            "Dupont", 
            "Corentin", 
            "Bébé", 
            false, 
            0
        );

        reservation.ajouterPersonne(
            5, 
            "chien", 
            "chien", 
            "chien", 
            false, 
            30
        );

        reservation.setLeVehicule(
            "1 8279 ZZ 29", 
            "Opel Zafira", 
            "Véhicule catégorie 2", 
            48.5f
        );

        System.out.println(reservation.toString());
    }
}
