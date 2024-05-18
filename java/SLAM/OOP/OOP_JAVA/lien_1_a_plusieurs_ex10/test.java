package lien_1_a_plusieurs_ex10;

import java.util.ArrayList;

public class test {
    public static void main(String[] args) {
        ArrayList<Client> lesClients = new ArrayList<>();
        Client c1 = new Client("c1", "colmar", "colatrane");
        Client c2 = new Client("c1", "colmar", "colatrane");
        Client c3 = new Client("c1", "colmar", "colatrane");
        Client c4 = new Client("c1", "Wanda",  "colatrane");
        Client c5 = new Client("c1", "colmar", "colatrane");

        lesClients.add(c1);
        lesClients.add(c2);
        lesClients.add(c3);
        lesClients.add(c4);
        lesClients.add(c5);

        for(Client c : lesClients){
            System.out.println(c.getNom());
        }
        System.out.println("Nombre de clients: "+lesClients.size());

        for(int i = lesClients.size()-1; i>=0; i--){
            System.out.println(lesClients.get(i).getNom());
        }

        for(int i = lesClients.size()-1; i>=0; i--){
            if(lesClients.get(i).getNom().equals("Wanda")){
                System.out.println("Le client"+i+"s'appelle wanda");
            }
        }

        lesClients.remove(2);
        for(Client c : lesClients){
            System.out.println(c.getNom());
        }

        lesClients.clear();

        for(Client c : lesClients){
            System.out.println(c.getNom()+"jkj");
        }
    }
}
