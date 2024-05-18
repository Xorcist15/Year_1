public class Exo63 {
    public static void main(String[] args) {
        int[][] table = new int[11][11];

        for(int i=0 ; i<11 ; i++) {
            for (int j=0 ; j<11 ; j++) {
                table[i][j]= i*j;
                System.out.printf("%-3d ", table[i][j]);
            }
            System.out.println();
        }
    }
}