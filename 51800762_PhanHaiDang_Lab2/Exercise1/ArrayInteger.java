public class ArrayInteger {
    private int arr[];
    private ISorting sorting;
    public ArrayInteger(int[] arr){
        this.arr = arr;
    } 

    public void SetSortAlgorithm(ISorting sorting){
        this.sorting = sorting;
    }

    public void runSort(){
        sorting.sort(arr);
    }
}
