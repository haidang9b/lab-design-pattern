public class TestSort {
    public static void main(String[] args) {
        int arr[] = {64,25,12,22,11,45, 212, 365, 2543, -15, -2695, 15 ,33, -5};
        ArrayInteger arrayInteger = new ArrayInteger(arr);
        System.out.println("Truoc khi sap xep:");
        arrayInteger.printArray();
        arrayInteger.SetSortAlgorithm(new SelectionSort());
        System.out.println("Sau khi sap xep:");
        arrayInteger.runSort();
        arrayInteger.printArray();
    }
}
