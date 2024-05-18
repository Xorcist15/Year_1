package AP.Mission_3;

import java.time.LocalDate;
import java.time.LocalTime;

public class test {
    public static void main(String[] args){

        Bateau b = new Bateau("Breizh Nevez I", 43.5f,  11.6f, 11.5f, 300, 18);

        Port pD = new Port("Lorient");
        Port pA = new Port("Port Tudy");

        LocalDate dD = LocalDate.of(2024, 2, 2);
        LocalTime hD = LocalTime.of(13, 45);
        
        Traversee t1 = new Traversee(51, dD, hD, 45, 107, 12, b, pD, pA);

        System.out.println(t1.toString());
    }
}
