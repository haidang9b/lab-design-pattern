public class ArrayInteger {
    private int arr[];
    private ISort sorting;
    public ArrayInteger(int[] arr){
        this.arr = arr;
    } 

    public void SetSortAlgorithm(ISort sorting){
        this.sorting = sorting;
    }

    public void runSort(){
        sorting.sort(arr);
    }

    public void printArray(){
        for(int i=0; i<arr.length; i++){
            System.out.printf(arr[i] + " ");
        }
        System.out.printf("\n");
    }
}
