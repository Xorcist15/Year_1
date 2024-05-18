package heritage_exercice_14;

import java.util.ArrayList;

public class TestClass {
    public static void main(String[] args) {
        Salarie s1 = new Salarie(
            1, 
            "momo", 
            "Web designer", 
            1830);
        
            Representant s2 = new Representant(
                2, 
                "manu", 
                "représentant du secteur Ouest", 
                1450f,
                13000,
                350);
            
            Representant s3 = new Representant(
                3, 
                "mumu", 
                "représentante secteur Est", 
                1450, 
                18000, 
                550);

            ArrayList <Salarie> lesSalaries = new ArrayList<Salarie>();
            lesSalaries.add(s1);
            lesSalaries.add(s2);
            lesSalaries.add(s3);
            for(Salarie s : lesSalaries){
                System.out.println(s);
                
            }
        

            
    }
}
