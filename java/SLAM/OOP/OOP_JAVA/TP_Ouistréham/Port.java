package TP_Ouistréham;

import java.util.ArrayList;

public class Port {
        // Properties
        private String nom;
        ArrayList<ZoneStockage> lesZones;

        // Constructeur
        public Port(String nom){
            this.nom = nom;
            lesZones = new ArrayList<>();
        }
    
        // Accesseurs
        // (lecture)
        public String getNom(){
            return this.nom;
        }

        // Méthodes
        public void ajouterZone(ZoneStockage zone){
            this.lesZones.add(zone);
        }
        public void decharger(Navire navire){
            // decharger le navire
            // getQteFret - getCapaDispo >= 0 
            // foreach zone
            System.out.println("Quantités à décharger par zone:\n");
            // for(ZoneStockage zone : lesZones){
            //     int qte = (navire.getquantiteFret() - zone.getCapaDispo()) < 0 ? navire.getquantiteFret() : zone.getCapaDispo();
            //     System.out.println("\tZone "+zone.getNom()+", qté à décharger: "+qte);
            //     navire.decharger(qte);
            // }
            int i = 0;
            while(!navire.estDecharge() && i < lesZones.size()){
                int qte = (navire.getquantiteFret() - lesZones.get(i).getCapaDispo()) < 0 ? navire.getquantiteFret() : lesZones.get(i).getCapaDispo();
                System.out.println("\tZone "+lesZones.get(i).getNom()+", qté à décharger: "+qte);
                navire.decharger(qte);
                i++;
            }
            System.out.println("\nQuantité Fret restante: "+navire.getquantiteFret());
            if(!navire.estDecharge()){
                System.out.println("Le navire n'est pas entièremenet déchargé, il n'y a plus de zone de stockage.");
            }
        }
}
