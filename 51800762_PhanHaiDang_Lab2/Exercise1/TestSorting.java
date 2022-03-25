public class TestSorting {
    public static void main(String[] args) {
        int arr[] = {64,25,12,22,11,45, 212, 365, 2543, -15, -2695, 15 ,33, -5};

        ArrayInteger arrayInteger = new ArrayInteger(arr);
        System.out.println("Truoc khi sap xep:");
        printerArray(arr);
        // ISorting sorting = new BubbleSortStrategy();
        // ISorting sorting = new QuickSortStrategy();
        arrayInteger.SetSortAlgorithm(new BubbleSortStrategy());
        arrayInteger.runSort();
        System.out.println("Sau khi sap xep:");
        printerArray(arr);

    }

    private static void printerArray(int arr[]){
        int n = arr.length;
        for (int i=0; i<n; ++i)
            System.out.print(arr[i]+" ");
        System.out.println();
    }
    
}
