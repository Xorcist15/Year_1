package Exercice_Comptes;

import java.util.Scanner;

public class Compte_Main {
    public static void main(String[] args) {

        Scanner saisir = new Scanner(System.in);
        Compte compte = new Compte(768973001, "Queffélec" );

        int choix = 0;
        do{

            System.out.print("Choix: ");
            choix = saisir.nextInt();
            saisir.nextLine();

            switch(choix){

                case 1:
                    System.out.println("choix: Créditer");
                    System.out.print("Saisir le montant à créditer: ");
                    compte.crediter(saisir.nextFloat());
                    break;
                case 2:
                    System.out.println("choix: Débiter");
                    System.out.print("Saisir le montant à débiter: ");
                    compte.debiter(saisir.nextFloat());
                    break;
                case 3:
                    System.out.println("choix: Etat du compte");
                    System.out.println(compte);
                    break;
                case 4:
                    System.out.println("choix: Modifier le découvert bancaire");
                    compte.setDecouvert();
                    break;
                case 5:
                    System.out.println("choix: Quitter");
                    break;
            }

        }while (choix != 5);

        saisir.close();
    }

    static void afficherMenu(){
        System.out.println("1. Créditer");
        System.out.println("2. Débiter");
        System.out.println("3. Etat du compte");
        System.out.println("4. Modifier le découvert bancaire");
        System.out.println("5. Quitter");
    }
}
