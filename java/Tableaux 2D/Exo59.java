public class Exo59 {

    static float[][] moy = new float[3][30];

    public static void main(String[] args) {

        arrayInit(moy);

        for(int i=0 ; i<3 ; i++) {
            for (int j=0 ; j<30 ; j++) {
                System.out.print(moy[i][j]+ " ");
            }
            System.out.println();
        }
    }

    static void arrayInit(float[][] array) {
        
        for(int i=0 ; i<3 ; i++) {
            for (int j=0 ; j<30 ; j++) {
                array[i][j] = 3.14f;
            }
        }
    }
}