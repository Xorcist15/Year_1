public class Exo60 {
    static float[][] moy = new float[3][30];
    public static void main(String[] args) {

        arrayInit(moy);

        float somme = 0;
        int compteur = 0;

        for(int i=0 ; i<3 ; i++) {
            for (int j=0 ; j<30 ; j++) {
                somme=moy[i][j]+somme;
                compteur++;
            }
        }

        System.out.println("La somme: "+somme+". L'agent itérateur: "+compteur);
        float moyenne = somme/compteur;
        System.out.printf("%s %.2f", "La moyenne de la classe est de", moyenne);
    }
    static void arrayInit(float[][] array) {

        for(int i=0 ; i<3 ; i++) {
            for (int j=0 ; j<30 ; j++) {
                array[i][j] = 3.14f;
            }
        }
    }
}
