import java.util.Scanner;

public class Compte_Main {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        Compte compte = new Compte(768973001, "Queffélec" );

        int choix = 0;
        while (choix != 5) {

            System.out.print("Choix: ");
            choix = input.nextInt();
            input.nextLine();

            switch(choix){
                case 1:
                    System.out.println("choix: Créditer");
                    compte.crediter();

                    break;
                case 2:
                    System.out.println("choix: Débiter");
                    break;
                case 3:
                    System.out.println("choix: Etat du compte");
                    break;
                case 4:
                    System.out.println("choix: Modifier le découvert bancaire");
                    break;
                case 5:
                    System.out.println("choix: Quitter");
                    break;
            }
        }

    }

    static void afficherMenu(){
        System.out.println("1. Créditer");
        System.out.println("2. Débiter");
        System.out.println("3. Etat du compte");
        System.out.println("4. Modifier le découvert bancaire");
        System.out.println("5. Quitter");
    }
}
