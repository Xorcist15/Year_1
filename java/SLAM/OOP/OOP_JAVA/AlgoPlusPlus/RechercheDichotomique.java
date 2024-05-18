public class RechercheDichotomique {

    public static void main(String[] args) {
        int[] tab = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int num = 7;
        int result = binarySearch(tab, num);
        if (result != -1) {
            System.out.println("Element is present at index " + result);
        } else {
            System.out.println("Element is not present in array");
        }
    }

    public static int binarySearch(int[] array, int num) {

        int d = 0;
        int f = array.length - 1;

        while (d <= f) {
            int m = d + (f - d) / 2;

            // Check if target is present at mid
            if (array[m] == num) {
                return m;
            }

            // If target is greater, ignore left half
            else if (array[m] < num) {
                d = m + 1;
            }

            // If target is smaller, ignore right half
            else {
                f = m - 1;
            }
        }

        // If target is not found in the array
        return -1;
    }
}
