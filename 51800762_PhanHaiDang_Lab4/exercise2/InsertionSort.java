public class InsertionSort implements ISort{

    @Override
    public void sort(int[] arr) {
        int n = arr.length;
        for (int i = 0; i < n; i++){
            int idx = arr[i];
            int j = i - 1;
            while(j >= 0 && arr[i] > idx){
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j+1] = idx;
        }
        
    }

}