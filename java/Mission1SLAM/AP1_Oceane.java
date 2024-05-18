import java.util.Scanner;
import java.text.DecimalFormat;

public class AP1_Oceane {

    /**
     * Méthode principale du programme. Initialise les catégories de passagers, les billets,
     * les catégories de véhicules et les billets de véhicules. Ensuite, appelle la méthode
     * afficherRecapitulatif pour afficher un récapitulatif de la réservation.
     *
     */
    public static void main(String[] args) {

        // Initialisation des catégories de passagers
        String[] lesCategoriesP = new String[] {
                "Adulte 26 ans et plus",
                "De 18 à 25 ans inclus",
                "Enfant de 4 à 18 ans",
                "Enfant moins de 4 ans",
                "Titulaire carte invalidité ou son accompagnateur",
                "chien"
        };

        // Initialisation des billets pour les passagers
        String[] lesBilletsP = new String[] {
                "Simple PN",
                "Simple PHF",
                "Abonné F4",
                "Abonné F10",
                "Abonné Illimité"
        };

        // Initialisation des catégories de véhicules
        String[] lesCategoriesV = new String[] {
                "Trottinette électrique",
                "Vélo",
                "Vélo électrique",
                "Deux roues de 49 à 125 cm3",
                "Deux roues plus de 125 cm3",
                "Véhicule C1 moins de 4,00 m",
                "Véhicule C2 de 4,00 à 4,39 m",
                "Véhicule C3 de 4,40 à 4.79 m",
                "Véhicule C4 4,80 m et plus",
                "Véhicule C5 – Camping-car"
        };

        // Initialisation des billets pour les véhicules
        String[] lesBilletsV = new String[] {
                "Simple PN",
                "Simple PHF",
                "Abonné F4",
                "Abonné F10"
        };

        // Création du scanner pour la saisie utilisateur
        Scanner input = new Scanner(System.in);

        // Appel de la méthode afficherRecapitulatif avec les données initiales
        afficherRecapitulatif(
                lesCategoriesP,
                lesCategoriesV,
                lesBilletsP,
                lesBilletsV,
                input);
    }

    /**
     * Cette méthode prend en charge la saisie d'un entier à partir de la console.
     * Elle affiche le message prompt, attend une entrée valide, et retourne l'entier saisi.
     *
     * @param prompt Le message affiché pour demander à l'utilisateur de saisir un entier.
     * @return L'entier saisi par l'utilisateur.
     */
    public static int getIntInput(String prompt) {

        // Création d'un objet Scanner pour lire les entrées utilisateur
        Scanner input = new Scanner(System.in);

        // Initialisation de la variable qui stockera l'entier saisi
        int intValue = 0;

        // Indicateur pour vérifier la validité de l'entrée
        boolean validInput = false;

        // Boucle tant que l'entrée n'est pas valide
        while (!validInput) {
            try {
                // Affichage du message prompt
                System.out.print(prompt);

                // Tentative de lecture de l'entier
                intValue = input.nextInt();

                // Marque l'entrée comme valide et sort de la boucle
                validInput = true;

            } catch (Exception e) {
                // En cas d'erreur (non-entier saisi), affiche un message d'erreur
                System.out.println("Erreur de type de saisie");

                // Consomme l'entrée invalide pour éviter une boucle infinie
                input.nextLine();

                // Affiche une ligne vide pour plus de lisibilité
                System.out.println();
            }
        }
        // Retourne l'entier saisi
        return intValue;
    }

    /**
     * Cette méthode prend en charge la saisie d'une chaîne de caractères non vide à partir de la console.
     * Elle utilise un objet Scanner pour lire l'entrée utilisateur jusqu'à ce qu'une chaîne non vide soit saisie.
     *
     * @param input L'objet Scanner utilisé pour lire l'entrée utilisateur.
     * @return La chaîne de caractères non vide saisie par l'utilisateur.
     */
    static String verificationValeurNonVide(Scanner input) {
        // Variable pour stocker la chaîne de caractères saisie
        String textNonVide;

        // Boucle tant que la chaîne saisie est vide ou composée uniquement d'espaces
        do {
            // Lecture de la ligne de l'entrée utilisateur
            textNonVide = input.nextLine();

            // Vérification si la chaîne est vide ou composée uniquement d'espaces
            if (textNonVide.isEmpty() || textNonVide.isBlank()) {
                // Affichage du message d'erreur
                System.out.print("Saisie vide, réessayez: ");
            }

        } while (textNonVide.isEmpty() || textNonVide.isBlank());

        // Retourne la chaîne de caractères non vide saisie par l'utilisateur
        return textNonVide;
    }

    static String dateVerif() {

        DecimalFormat df = new DecimalFormat("00");
        DecimalFormat af = new DecimalFormat("0000");

        int annee, mois, jour;

        boolean bissextile = false;
        do
        {
            //saisir les éléments composants la date choisie
            annee = getIntInput("Année : ");

            //vérifie que l'année est logique

            if (annee < 1  || annee > 2106){

                System.out.println("Année invalide : ");
                continue;
            }

            //vérifie que l'année est bissextile (29 février)

            if ((annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0)
            {
                bissextile = true;
            }

            //définie les bornes inférieures et supérieurs de l'année
        }while (annee < 1  || annee > 2106);


        do
        {
            //saisir les éléments composants la date choisie
            mois = getIntInput("Mois : ");

            //vérifie que le mois est logique

            if (mois < 1  || mois > 12)
                System.out.println("Mois invalide : ");

            //définie les bornes inférieures et supérieures des mois possibles
        }while (mois < 1  || mois > 12);

        //la variable valide sert à contrôler si e jour entré correspond aux attentes logiques du calendrier, la boucle do while loop arrête de se boucler
        boolean valide;

        do{
            valide = true;

            //saisir les éléments composants la date choisie
            jour = getIntInput("Jour : ");

            //vérifie que le jour est logique (correspond au mois en fonction du calendrier
            //système de filtrage des jours, définie les jours possibles par catégorie

            switch (mois){

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (jour < 1 || jour > 31){
                        valide = false;
                    }
                    break;

                case 2:
                    if (bissextile){
                        if (jour < 1 || jour > 29)
                            valide = false;
                    }

                    if (!bissextile){
                        if (jour < 1 || jour > 28)
                            valide = false;
                    }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (jour < 1 || jour > 30){
                        valide = false;
                    }
                    break;
            }

            if (!valide)
                System.out.println("Jour invalide : ");

            //vérifie que si tous les tests sont false, la boucle se re-exécute
        }while (!valide);
        System.out.println();

        // à la fin de tous les tests et vérifications, on affiche la date au format
        return df.format(jour) + "/" + df.format(mois) + "/" + af.format(annee);
    }

    // Méthode pour calculer le jour de la semaine selon la congruence de Zeller
    public static int calculerJourSemaine(int jour, int mois, int annee) {
        // Si le mois est janvier ou février, on les traite comme les mois 13 et 14 de l'année précédente
        if (mois < 3) {
            mois += 12;
            annee--;
        }

        // k représente les deux derniers chiffres de l'année
        int k = annee % 100;
        // j = le siècle de l'année
        int j = annee / 100;

        // la Congruence de Zeller pour calculer le jour de la semaine
        return (jour + ((13 * (mois + 1)) / 5) + k + (k / 4) + (j / 4) - (2 * j)) % 7 + 1;
    }

    // Méthode pour obtenir le nom du jour
    public static String obtenirNomJour(int jourSemaine) {
        String[] nomsJours = {"Samedi", "Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi"};
        return nomsJours[jourSemaine - 1];
    }

    /**
     * Cette méthode détermine la période (PN : Période Normale, PHF : Période Haute Fréquentation, ou Période Indéfinie)
     * en fonction de la date fournie en argument, selon un calendrier spécifié.
     *
     * @param date La date au format jour/mois/année sous forme de chaîne de caractères.
     * @return La période correspondante à la date (PN, PHF, ou Période Indéfinie).
     */
    static String periode(String date) {
        // Séparation de la date en jour, mois et année
        String[] tab = date.split("/");

        // Conversion des composants de la date en entiers
        int jour = Integer.parseInt(tab[0]);
        int mois = Integer.parseInt(tab[1]);
        int annee = Integer.parseInt(tab[2]);

        // Obtention du nom du jour de la semaine
        String nomJour = obtenirNomJour(calculerJourSemaine(jour, mois, annee));

        // Logique de détermination de la période en fonction du mois et du jour
        switch (mois) {
            case 1:
                if (jour == 1) {
                    return "PHF";
                } else {
                    return "PN";
                }
            case 5:
                if (nomJour.equals("Vendredi") || nomJour.equals("Samedi") || nomJour.equals("Dimanche") || jour == 1 || jour == 8) {
                    return "PHF";
                } else {
                    return "PN";
                }
            case 11:
                if (jour == 1 || jour == 11) {
                    return "PHF";
                } else {
                    return "PN";
                }
            case 12:
                if (jour == 25) {
                    return "PHF";
                } else {
                    return "PN";
                }
            case 10:
            case 2:
            case 3:
                return "PN";
            case 4:
            case 6:
            case 9:
                if (nomJour.equals("Vendredi") || nomJour.equals("Samedi") || nomJour.equals("Dimanche")) {
                    return "PHF";
                } else {
                    return "PN";
                }
            case 7:
            case 8:
                return "PHF";
            default:
                return "Période indéfinie";
        }
    }

    /**
     * Cette méthode permet de saisir les informations des passagers, y compris leur nom, prénom
     * et catégorie, en utilisant les menus spécifiés et en assurant que les valeurs ne sont pas vides.
     *
     * @param lesCategoriesP Les catégories de passagers possibles.
     * @param input          Scanner utilisé pour la saisie utilisateur.
     * @return Un tableau de chaînes de caractères représentant les informations des passagers.
     */
    static String[] saisirInfosPassagers(String[] lesCategoriesP, Scanner input) {

        // Déclaration des variables
        String[] passagers;
        String semiColon = ";";

        // Saisie du nombre de personnes
        int nbPersonnes = getIntInput("Saisir le nombre de personnes: ");
        System.out.println();

        // Initialisation du tableau de passagers
        passagers = new String[nbPersonnes];

        // Saisie des informations pour chaque passager
        for (int i = 0; i < passagers.length; i++) {

            // Saisie du nom de la personne
            System.out.print("Saisir le nom de la personne N°" + (i + 1) + ": ");
            String nom = verificationValeurNonVide(input);

            // Saisie du prénom de la personne
            System.out.print("Saisir le prénom de la personne N°" + (i + 1) + ": ");
            String prenom = verificationValeurNonVide(input);

            System.out.println();

            // Saisie de la catégorie de la personne en utilisant les menus spécifiés
            String cat = saisirCategorieP(afficherMenuCategorieP(lesCategoriesP, "Saisir catégorie de la personne N°" + (i + 1) + ": "), lesCategoriesP);

            // Construction de la chaîne d'informations du passager
            passagers[i] = cat + semiColon + nom + semiColon + prenom;

            // Affichage d'une ligne vide sauf pour le dernier passager
            if (i != passagers.length - 1) {
                System.out.println();
            }
        }

        System.out.println();
        return passagers;
    }

    /**
     * Cette méthode prend en paramètre le choix de catégorie de passager et retourne une chaîne
     * représentant la catégorie sélectionnée, en suivant un format spécifié.
     *
     * @param choix           Le choix de catégorie saisi par l'utilisateur.
     * @param lesCategoriesP  Les catégories de passagers possibles.
     * @return Une chaîne représentant la catégorie sélectionnée avec un format spécifique.
     * Si la catégorie est inexistante, retourne "catégorie inexistante".
     */
    static String saisirCategorieP(int choix, String[] lesCategoriesP) {
        // Déclaration du séparateur de colonne
        String semiColon = ";";

        // Utilisation d'une instruction switch pour déterminer la catégorie en fonction du choix
        return switch (choix) {
            case 1 -> 0 + semiColon + lesCategoriesP[0];
            case 2 -> 1 + semiColon + lesCategoriesP[1];
            case 3 -> 2 + semiColon + lesCategoriesP[2];
            case 4 -> 3 + semiColon + lesCategoriesP[3];
            case 5 -> 4 + semiColon + lesCategoriesP[4];
            case 6 -> 5 + semiColon + lesCategoriesP[5];
            default -> "catégorie inexistante";

                // Retourne une chaîne indiquant que la catégorie est inexistante si le choix n'est pas reconnu

        };

    }

    /**
     * Cette méthode affiche le menu des catégories de personnes, permet à l'utilisateur de faire un choix,
     * et retourne ce choix après s'assurer qu'il est valide.
     *
     * @param lesCategoriesP  Les catégories de personnes à afficher dans le menu.
     * @param prompt          Le message demandant à l'utilisateur de saisir son choix.
     * @return Le choix de l'utilisateur après validation.
     */
    static int afficherMenuCategorieP(String[] lesCategoriesP, String prompt) {
        int choix;

        // Affiche le menu des catégories de personnes
        System.out.println("+--------------Menu Catégories Personnes--------------+");
        for (int i = 0; i < lesCategoriesP.length; i++) {
            System.out.printf("| %d.%-50s|%n", (i + 1), lesCategoriesP[i]);
        }
        System.out.println("+-----------------------------------------------------+");

        // Obtient le choix de l'utilisateur et s'assure qu'il est valide
        choix = getIntInput(prompt);
        do {
            if (choix < 1 || choix > lesCategoriesP.length) {
                choix = getIntInput("Choix impossible, réessayez: ");
            }
        } while (choix < 1 || choix > lesCategoriesP.length);

        return choix;
    }

    /**
     * Cette méthode permet de saisir le type de billet pour un passager en fonction du choix de l'utilisateur
     * et de la période spécifiée.
     *
     * @param choix      Le choix de l'utilisateur parmi les types de billets.
     * @param lesBilletsP Les différents types de billets disponibles.
     * @param period     La période pour laquelle le billet est demandé ("(période normale)" ou autre).
     * @return Le type de billet choisi pour le passager.
     */
    static String saisirTypeBilletPassager(int choix, String[] lesBilletsP, String period) {
        switch (choix) {
            case 1:
                if (period.equals("(période normale)")) {
                    return lesBilletsP[0];
                } else {
                    return lesBilletsP[1];
                }
            case 2:
                return lesBilletsP[2];
            case 3:
                return lesBilletsP[3];
            case 4:
                return lesBilletsP[4];
        }
        return "Type de billet inexistant";
    }

    /**
     * Affiche le menu des catégories de billets pour les personnes et permet à l'utilisateur de faire un choix.
     *
     * @param lesBilletsP Les différentes catégories de billets pour les personnes.
     * @return Le choix de l'utilisateur parmi les catégories de billets pour les personnes.
     */
    static int afficherMenuBilletsP(String[] lesBilletsP) {
        System.out.println("+----------Menu Catégories Billets Personnes----------+");

        System.out.printf("| %d.%-50s|%n", 1, "Billet simple");
        System.out.printf("| %d.%-50s|%n", 2, "Abonné F4");
        System.out.printf("| %d.%-50s|%n", 3, "Abonné F10");
        System.out.printf("| %d.%-50s|%n", 4, "Abonné Illimité");

        System.out.println("+-----------------------------------------------------+");

        int choix = getIntInput("Saisir la catégorie de billets [Personnes]: ");
        do {
            if (choix < 1 || choix > lesBilletsP.length) {
                choix = getIntInput("Choix impossible, réessayez : ");
            }
        } while (choix < 1 || choix > lesBilletsP.length);

        return choix;
    }

    /**
     * Saisit les informations des véhicules, y compris l'immatriculation et la catégorie, en demandant à l'utilisateur de fournir
     * le nombre de véhicules et les détails pour chaque véhicule.
     *
     * @param lesCategoriesV Les différentes catégories de véhicules.
     * @param input          Scanner pour lire l'entrée utilisateur.
     * @return Un tableau contenant les informations des véhicules sous la forme "catégorie;immatricule".
     */
    static String[] saisirInfosVehicules(String[] lesCategoriesV, Scanner input) {
        String[] vehicules;
        String semiColon = ";";
        int nbVehicules = getIntInput("Saisir le nombre de véhicules : ");
        System.out.println();

        vehicules = new String[nbVehicules];
        for (int i = 0; i < vehicules.length; i++) {

            System.out.print("Saisir l'immatriculation du véhicule N°" + (i + 1) + ": ");
            String immatricule = verificationValeurNonVide(input);
            System.out.println();

            String categorie = saisirCategorieVehicules(afficherMenuCategorieVehicule(lesCategoriesV,
                    "Saisir catégorie du véhicule N°" + (i + 1) + ": "), lesCategoriesV);

            vehicules[i] = categorie + semiColon + immatricule;
            System.out.println();
        }
        return vehicules;
    }

    /**
     * Saisit la catégorie d'un véhicule en fonction du choix de l'utilisateur.
     *
     * @param choix          Le choix de l'utilisateur pour la catégorie du véhicule.
     * @param lesCategoriesV Les différentes catégories de véhicules.
     * @return Une chaîne représentant la catégorie du véhicule sous la forme "indice;catégorie".
     *         Retourne "catégorie inexistante" si le choix n'est pas valide.
     */
    static String saisirCategorieVehicules(int choix, String[] lesCategoriesV) {
        String semiColon = ";";
        return switch (choix) {
            case 1 -> 0 + semiColon + lesCategoriesV[0];
            case 2 -> 1 + semiColon + lesCategoriesV[1];
            case 3 -> 2 + semiColon + lesCategoriesV[2];
            case 4 -> 3 + semiColon + lesCategoriesV[3];
            case 5 -> 4 + semiColon + lesCategoriesV[4];
            case 6 -> 5 + semiColon + lesCategoriesV[5];
            case 7 -> 6 + semiColon + lesCategoriesV[6];
            case 8 -> 7 + semiColon + lesCategoriesV[7];
            case 9 -> 8 + semiColon + lesCategoriesV[8];
            case 10 -> 9 + semiColon + lesCategoriesV[9];
            default -> "catégorie inexistante";
        };
    }

    /**
     * Affiche le menu des catégories de véhicules et saisit le choix de l'utilisateur.
     *
     * @param lesCategoriesV Les différentes catégories de véhicules.
     * @param prompt         Le message à afficher pour demander le choix de l'utilisateur.
     * @return Le choix de l'utilisateur pour la catégorie de véhicule.
     *         Assure que le choix est valide avant de le retourner.
     */
    static int afficherMenuCategorieVehicule(String[] lesCategoriesV, String prompt) {
        System.out.println("+---------------Menu Catégories Véhicules---------------+");
        for (int i = 0; i < lesCategoriesV.length; i++) {
            System.out.printf("| %-2d . %-49s|%n", (i + 1), lesCategoriesV[i]);
        }
        System.out.println("+-------------------------------------------------------+");

        int choix = getIntInput(prompt);
        do {
            if (choix < 1 || choix > lesCategoriesV.length) {
                choix = getIntInput("Choix impossible, réessayez : ");
            }
        } while (choix < 1 || choix > lesCategoriesV.length);

        return choix;
    }

    /**
     * Saisit le type de billet pour un véhicule en fonction du choix de l'utilisateur.
     *
     * @param choix      Le choix de l'utilisateur.
     * @param lesBilletsV Les différentes catégories de billets pour véhicules.
     * @param periode     La période spécifiée (normale ou autre).
     * @return Le type de billet correspondant au choix de l'utilisateur.
     *         Retourne "catégorie inexistante" si le choix n'est pas valide.
     */
    static String saisirTypeBilletV(int choix, String[] lesBilletsV, String periode) {
        switch (choix) {
            case 1:
                if (periode.equals("(période normale)")) {
                    return lesBilletsV[0];
                } else {
                    return lesBilletsV[1];
                }
            case 2:
                return lesBilletsV[2];
            case 3:
                return lesBilletsV[3];
        }
        return "catégorie inexistante";
    }

    /**
     * Affiche le menu des catégories de billets pour les véhicules et saisit le choix de l'utilisateur.
     *
     * @param lesBilletsV Les différentes catégories de billets pour les véhicules.
     * @return Le choix de l'utilisateur.
     *         S'il n'est pas valide, la méthode redemande le choix jusqu'à ce qu'il soit correct.
     */
    static int afficherMenuBilletsVehicules(String[] lesBilletsV) {
        System.out.println("+----------Menu Catégories Billets Véhicules----------+");
        System.out.printf("| %d.%-50s|%n", 1, "Billet simple");
        System.out.printf("| %d.%-50s|%n", 2, "Abonné F4");
        System.out.printf("| %d.%-50s|%n", 3, "Abonné F10");
        System.out.println("+-----------------------------------------------------+");

        int choix = getIntInput("Saisir la catégorie de billets [Véhicules]: ");
        do {
            if (choix < 1 || choix > lesBilletsV.length) {
                choix = getIntInput("Choix impossible, réessayer: ");
            }
        } while (choix < 1 || choix > lesBilletsV.length);

        return choix;
    }

    /**
     * Affiche un récapitulatif de la réservation, y compris la date, les types de billets, les passagers,
     * les véhicules et le coût total de la réservation.
     *
     * @param lesCategoriesP   Les différentes catégories de passagers.
     * @param lesCategoriesV   Les différentes catégories de véhicules.
     * @param lesBilletsP      Les différentes catégories de billets pour les passagers.
     * @param lesBilletsV      Les différentes catégories de billets pour les véhicules.
     * @param input            Le scanner pour la saisie utilisateur.
     */
    static void afficherRecapitulatif(String[] lesCategoriesP,
                              String[] lesCategoriesV,
                              String[] lesBilletsP,
                              String[] lesBilletsV,
                              Scanner input) {

        float[][] lesTarifsP = new float[][] {
                {17.50f, 19.00f, 15.45f, 8.45f, 6.20f},
                {13.50f, 13.50f, 12.85f, 6.70f, 6.20f},
                {11.00f, 11.00f, 7.70f,  4.25f, 3.70f},
                {0.00f,  0.00f,  0.00f,  0.00f, 0.00f},
                {6.20f,  6.20f,  6.20f,  6.20f, 6.20f},
                {3.10f,  3.10f,  3.10f,  3.10f, 3.10f}
        };

        float[][] lesTarifsV = new float[][] {
                {4.40f,   5.20f,   4.40f,   4.40f},
                {7.70f,   9.00f,   7.70f,   6.20f},
                {10.30f,  11.90f,  10.30f,  8.25f},
                {21.60f,  25.20f,  21.60f,  17.30f},
                {61.80f,  72.10f,  61.80f,  49.45f},
                {89.90f,  101.20f, 64.60f,  49.10f},
                {107.40f, 118.80f, 77.50f,  56.30f},
                {163.30f, 180.80f, 120.10f, 86.80f},
                {197.30f, 225.20f, 144.65f, 106.95f},
                {308.90f, 308.90f, 308.90f, 308.90f}
        };

        DecimalFormat df = new DecimalFormat("#0.00");
        String semiColon = ";";

        String periode = "Période indéfinie";

        String date = dateVerif();
        if(periode(date).equals("PN")) {
            periode = "(période normale)";
        } else if (periode(date).equals("PHF")) {
            periode = "(période haute fréquentations)";
        }

        String[] passagers = saisirInfosPassagers(lesCategoriesP, input);
        String[] vehicules = saisirInfosVehicules(lesCategoriesV, input);

        int indexPrixBilletPassagers = afficherMenuBilletsP(lesBilletsP);
        System.out.println();

        int indexPrixBilletVehicules = afficherMenuBilletsVehicules(lesBilletsV);
        System.out.println();

        String typeBilletP = saisirTypeBilletPassager(indexPrixBilletPassagers, lesBilletsP, periode);
        String typeBilletV = saisirTypeBilletV(indexPrixBilletVehicules, lesBilletsV, periode);

        int indexTarif;
        float prixTotalReservation = 0;

        System.out.println("+-----------------------------------------------------------------------------------+");
        System.out.printf("| %-81s %s%n", "Date de réservation :     " + date + " " + periode, "|");
        System.out.println("|                                                                                   |");
        System.out.printf("| %-81s %s%n", "Type de billet passager :     " + typeBilletP, "|");
        System.out.printf("| %-81s %s%n", "Les Passagers", "|");

        for (String s : passagers) {

            String[] tab = s.split(semiColon);
            indexTarif = Integer.parseInt(tab[0]);
            if (lesTarifsP[indexTarif][indexPrixBilletPassagers] == 0) {
                System.out.printf("|      %-65s %-10s %s%n", tab[2] + " " + tab[3] + " - " + tab[1], "gratuit", "|");
            } else {
                System.out.printf("|      %-65s %-10s %s%n", tab[2] + " " + tab[3] + " - " + tab[1], df.format(lesTarifsP[indexTarif][indexPrixBilletPassagers])+"€", "|");
            }
            prixTotalReservation = prixTotalReservation + lesTarifsP[indexTarif][indexPrixBilletPassagers];
        }
        System.out.println("|                                                                                   |");

        System.out.printf("| %-81s %s%n", "Type de billet véhicule :     "+ typeBilletV, "|");
        System.out.printf("| %-81s %s%n", "Les Véhicules", "|");

        for (String s : vehicules) {
            String[] tab = s.split(semiColon);
            indexTarif = Integer.parseInt(tab[0]);
            System.out.printf("|      %-65s %-10s %s%n", tab[2] + " - " + tab[1], df.format(lesTarifsV[indexTarif][indexPrixBilletVehicules])+"€", "|");
            prixTotalReservation = prixTotalReservation + lesTarifsV[indexTarif][indexPrixBilletVehicules];
        }
        System.out.println("|                                                                                   |");

        System.out.printf("|                            %-54s %s%n", "Total                                       " + df.format(prixTotalReservation)+"€", "|");
        System.out.println("+-----------------------------------------------------------------------------------+");
    }
}