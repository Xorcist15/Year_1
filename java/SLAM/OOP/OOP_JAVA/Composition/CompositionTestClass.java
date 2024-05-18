package Composition;

public class CompositionTestClass {
    public static void main(String[] args) {
        Livre livre = new Livre(
            "123", 
            "Méthode Merise", 
            "Tome 1");

        livre.ajouterAuteur(new Auteur(1, "Hubert", "Tardieu"));
        livre.ajouterAuteur(new Auteur(2, "Arnold", "Rochfeld"));
        livre.ajouterAuteur(new Auteur(3, "René", "Coletti"));

        livre.ajouterChapitre(1, "Intro", 11);
        livre.ajouterChapitre(2, "Présentation MERISE", 17);
        livre.ajouterChapitre(3, "SI, approche fonc", 51);
        livre.ajouterChapitre(4, "SI, approche formelle", 89);
        livre.ajouterChapitre(5, "Règles de construc", 165);
        livre.ajouterChapitre(14, "Conclusion", 322);

        System.out.println(livre.toString());
    }
}
