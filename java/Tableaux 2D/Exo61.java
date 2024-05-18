public class Exo61 {
    static float[][] moy = new float[3][30];
    public static void main(String[] args) {

        arrayInit(moy);

        float somme = 0;
        int compteur = 0;

        for(int i=0 ; i<3 ; i++) {
            for (int j=0 ; j<30 ; j++) {
                if(j == 2) {
                    somme=moy[i][j]+somme;
                    compteur++;
                }
            }
        }
        System.out.println("La somme: "+somme+"\nL'agent itérateur: "+compteur);
        float moyenne = somme/compteur;
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
