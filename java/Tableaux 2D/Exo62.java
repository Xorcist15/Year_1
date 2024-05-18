public class Exo62 {
    static float[][] moy = new float[3][30];
    public static void main(String[] args) {

        arrayInit(moy);

        float somme = 0;
        int compteur = 0;
        int compteurTotal = 0;
        float sommeTotal = 0;
        int NUM = 1;

        for(int i=0 ; i<30 ; i++) {
            for (int j=0 ; j<3 ; j++) {
                somme=moy[j][i]+somme;
                compteur++;
                compteurTotal++;
                sommeTotal=moy[j][i]+sommeTotal;
            }
            float moyenne = somme/compteur;
            System.out.printf("%s %d %s %.2f%n", "élève n°", NUM, " moyenne", moyenne);
            compteur = 0;
            somme = 0;
            NUM++;
        }
        //System.out.println("La somme: "+somme+"\nL'agent itérateur: "+compteur);
        float moyenne = sommeTotal/compteurTotal;
        System.out.printf("%s %.2f", "La moyenne du 3éme élève est ", moyenne);
    }
    static void arrayInit(float[][] array) {

        for(int i=0 ; i<3 ; i++) {
            for (int j=0 ; j<30 ; j++) {
                array[i][j] = 3.14f;
            }
        }
    }
}
