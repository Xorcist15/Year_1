package TP_Ouistréham;

public class TestClass {
    public static void main(String[] args){

        Port Caen_Ouistreham = new Port("Caen-Ouistreham");
        // merch = fret
        Navire KRISTIN = new Navire("9523938", "KRISTIN C", "soja", 100);

        Caen_Ouistreham.ajouterZone(new ZoneStockage("z1", 0, 100));
        Caen_Ouistreham.ajouterZone(new ZoneStockage("z2", 40, 150));
        Caen_Ouistreham.ajouterZone(new ZoneStockage("z3", 160, 160));
        Caen_Ouistreham.ajouterZone(new ZoneStockage("z4", 45, 100));
        Caen_Ouistreham.ajouterZone(new ZoneStockage("z5", 60, 80));

        Caen_Ouistreham.decharger(KRISTIN);
    }
}
