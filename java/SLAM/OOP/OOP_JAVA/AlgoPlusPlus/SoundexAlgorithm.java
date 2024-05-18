import java.util.ArrayList;

public class SoundexAlgorithm {
    public static void main(String[] args) {
        final String NOM = "Soundex";
        System.out.println("Fr: " + soundX(NOM, "fr"));
        System.out.println("En: " + soundX(NOM, "en"));
    }

    public static String soundX(String nom, String language){
        // remove spaces
        nom = nom.replace(" ","");
        // set to uppercase
        nom = nom.toUpperCase();

        // creates char tab
        ArrayList<Character> tabNom = initTabNom(nom);
        // supprime les voyelles
        tabNom = supprVoyelles(tabNom);

        String resultat;
        
        switch (language) {
            case "fr":
                resultat = switchFr(tabNom, nom.charAt(0));
                break;
            case "en":
                resultat = switchEn(tabNom, nom.charAt(0));
                break;
            default:
                resultat = "?????";
                break;
        }
        // mettre à jour le contenu de tabNom à carrespondre au resultat
        tabNom.clear();
        for(int i = 0; i<resultat.length(); i++){
            tabNom.add(resultat.charAt(i));
        }
        // remove duplicants
        for(int i = 0; i<tabNom.size()-1; i++){
            if(tabNom.get(i+1) == tabNom.get(i)){
                tabNom.remove(i);
            }
        }
        // mettre à jour resultat
        resultat = "";
        for(int i = 0; i<tabNom.size(); i++){
            resultat += tabNom.get(i);
        }
        // garder seuelement 4 caractères de gauche
        
        if(resultat.length() < 4){
            resultat = resultat.substring(0, resultat.length());
        }
        else{
            resultat = resultat.substring(0, 4);
        }
        return resultat;
    }

    public static ArrayList<Character> initTabNom(String nom){
        ArrayList<Character> tabNom = new ArrayList<Character>();
        // create list with each individual character of name
        for(int i = 0; i<nom.length(); i++){
            tabNom.add(nom.charAt(i));
        }
        return tabNom;
    }

    public static ArrayList<Character> supprVoyelles(ArrayList<Character> tabNom){
        // supprimer caractères voyelles
        for(int i = tabNom.size()-1; i>=0; i--){
            if(
                tabNom.get(i) == 'A' ||
                tabNom.get(i) == 'E' ||
                tabNom.get(i) == 'I' ||
                tabNom.get(i) == 'O' ||
                tabNom.get(i) == 'U' ||
                tabNom.get(i) == 'Y' ||
                tabNom.get(i) == 'H' ||
                tabNom.get(i) == 'W' ||
                tabNom.get(i) == 'Y'){
                    tabNom.remove(i);
            }
        }
        return tabNom;
    }

    public static String switchFr(ArrayList<Character> tabNom, char lettre1){
        // remplacement des lettres par chiffres correspondants
        String resultat = String.valueOf(lettre1);
        for(int i = 1; i<tabNom.size(); i++){
            char c = tabNom.get(i);
            switch (c) {
                case 'B':
                case 'P':
                    resultat += "1";
                    break;
                case 'C':
                case 'K':
                case 'Q':
                    resultat += "2";
                    break;
                case 'D':
                case 'T':
                    resultat += "3";
                    break;
                case 'L':
                    resultat += "4";
                    break;
                case 'M':
                case 'N':
                    resultat += "5";
                    break;
                case 'R':
                    resultat += "6";
                    break;
                case 'G':
                case 'J':
                    resultat += "7";
                    break;
                case 'S':
                case 'X':
                case 'Z':
                    resultat += "8";
                    break;
                case 'F':
                case 'V':
                    resultat += "9";
                    break;
            }
        }
        return resultat;
    }

    public static String switchEn(ArrayList<Character> tabNom, char lettre1){
        // remplacement des lettres par chiffres correspondants
        String resultat = String.valueOf(lettre1);
        for(int i = 1; i<tabNom.size(); i++){
            char c = tabNom.get(i);
            switch (c) {
                case 'B':
                case 'F':
                case 'P':
                case 'V':
                    resultat += "1";
                    break;
                case 'C':
                case 'G':
                case 'J':
                case 'K':
                case 'Q':
                case 'S':
                case 'X':
                case 'Z':
                    resultat += "2";
                    break;
                case 'D':
                case 'T':
                    resultat += "3";
                    break;
                case 'L':
                    resultat += "4";
                    break;
                case 'M':
                case 'N':
                    resultat += "5";
                    break;
                case 'R':
                    resultat += "6";
                    break;
            }
        }
        return resultat;
    }
}
