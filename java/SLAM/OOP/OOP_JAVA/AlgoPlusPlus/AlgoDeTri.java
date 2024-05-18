public class AlgoDeTri{
    public static void main(String[] args){
        int[] tab = {9, 1, 8, 2, 7, 3, 6, 4, 5};

        selectionSort(tab);
        insertionSort(tab);
        bubbleSort(tab);

        for(int i : tab){
            System.out.print(i+" ");
        }
    }

    public static void selectionSort(int[] tab){
        for(int i = 0; i<tab.length-1; i++){
            int min = i;
            for(int j = i+1; j<tab.length; j++){
                if(tab[min]>tab[j]){
                    min = j;
                }
            }
            //swapping
            int temp = tab[i];
            tab[i] = tab[min];
            tab[min] = temp;
        }
    }

    public static void insertionSort(int[] tab){
        for(int i = 1; i<tab.length; i++){
            int temp = tab[i];
            int j = i-1;
            while(j >= 0 && tab[j] > temp){
                tab[j+1] = tab[j];
                j--;
            }
            tab[j+1] = temp;
        }
    }

    public static void bubbleSort(int[] tab){
        for(int i = 0; i<tab.length; i++){
            for(int j = 0; j<tab.length; j++){
                if(tab[i] < tab[j]){
                    int temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;
                }
            }
        }
    }
}
