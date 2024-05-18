package lien_1_a_plusieurs_ex11;

public class testClass {
    public static void main(String[] args) {
        Film film = new Film("AMERICAN BEAUTY", 1999, "Sam Mendez");

        film.ajouterActeur(new Acteur("Kevin", "Spacey"));
        film.ajouterActeur(new Acteur("Annette", "Bening"));
        film.ajouterActeur(new Acteur("Thora", "Birch"));
        film.ajouterActeur(new Acteur("Wes", "Bentley"));

        System.out.println(film);

    }
}
