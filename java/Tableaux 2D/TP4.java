import java.util.Scanner;

public class TP4 {
    static int[] palier;      // Tableau des paliers de plongée
    static int[] duree;       // Tableau des durées de plongée
    static int[][] attente;    // Tableau des temps d'attente associés aux paliers et durées
    static Scanner input;      // Scanner pour la saisie utilisateur

    public static void main(String[] args) {
        init();  // Initialisation des tableaux et du scanner
        int dureeMinutes = saisirDureePlonge();  // Saisie de la durée de plongée
        afficherPaliers(dureeMinutes);  // Affichage des paliers
    }

    // Méthode pour afficher les paliers et la durée cumulée
    static void afficherPaliers(int dureeMinutes) {
        int indexDuree = trouverIndex(dureeMinutes);
        affichageListePalier(indexDuree);
    }

    // Méthode pour trouver l'index associé à la durée de plongée
    static int trouverIndex(int dureeMinutes) {
        int indexDuree = 0;
        for (int i = 0; i < duree.length; i++) {
            if (dureeMinutes == duree[i]) {
                indexDuree = i;
            }
        }
        return indexDuree;
    }

    // Méthode pour afficher la liste des paliers avec la durée cumulée
    static void affichageListePalier(int indexDuree) {
        int somme = 0;
        for (int i = attente.length - 1; i >= 0; i--) {
            if (attente[i][indexDuree] != 0) {
                System.out.println(attente[i][indexDuree] + " minutes à " + palier[i] + " mètres");
                somme += attente[i][indexDuree];
            }
        }
        int heures = somme / 60;
        int minutes = somme % 60;

        System.out.printf("%s %02d%s%02d", "Soit une durée cumulée de ", heures, ":", minutes);
    }

    // Méthode d'initialisation des tableaux et du scanner
    static void init() {
        input = new Scanner(System.in);
        palier = new int[]{3, 6, 9, 12, 15};
        duree = new int[]{5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55};
        attente = new int[][]{
                {2, 6, 19, 32, 41, 48, 54, 62, 69, 78, 88},
                {0, 2, 4, 8, 15, 22, 28, 30, 35, 37, 40},
                {0, 0, 1, 3, 5, 8, 11, 17, 19, 22, 24},
                {0, 0, 0, 0, 0, 1, 4, 6, 9, 13, 15},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 5}
        };
    }

    // Méthode pour saisir la durée de plongée et l'arrondir à 5 supérieur
    static int saisirDureePlonge() {
        int dureeMinutes;
        boolean dureeValable = false;

        dureeMinutes = getIntInput("Saisir le durée de la plongée: ");
        input.nextLine(); // Consume the newline character
        while (!dureeValable) {
            if (dureeMinutes < 5 || dureeMinutes > 55) {
                dureeMinutes = getIntInput("Durée invalide, veuillez re-saisir: ");
            } else {
                dureeValable = true;
            }
        }

        dureeMinutes = arrondir5Sup(dureeMinutes);

        return dureeMinutes;
    }

    // Méthode pour arrondir à 5 supérieur
    static int arrondir5Sup(double number) {
        return (int) (Math.ceil(number / 5) * 5);
    }

    // Méthode pour obtenir une entrée utilisateur de type entier
    public static int getIntInput(String prompt) {

        int intValue = 0;
        boolean validInput = false;

        while (!validInput) {
            try {
                System.out.print(prompt);
                intValue = input.nextInt();
                validInput = true;
            } catch (Exception e) {
                System.out.println("Erreur");
                input.nextLine(); // Consume the invalid input to avoid an infinite loop
                System.out.println();
            }
        }

        return intValue;
    }
}
