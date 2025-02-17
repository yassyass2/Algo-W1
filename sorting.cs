public static void Insertion(int [] arr){
    if (arr == null || arr.length <= 1) return;
    for (int j = 1; j < arr.length; j++) {
        var key = arr[j];
        int i = j - 1;
        while (i >= 0 && arr[i] > key){
            arr[i + 1] = arr[i];
            i--;
        }
        arr[i+1] = key;
    }

}

public static void Bubble(int [] arr){
    if (arr == null || arr.Length <= 1) return;
    bool onceMore = true;
    while (onceMore){
        onceMore = false;
        for (int i = 0; i i < arr.Length-1; i++){
            if(arr[i]>arr[i+1]){
                (arr[i+1],arr[i]) = (arr[i], arr[i+1]);
                onceMore=true;
            }
        }
    }
}

public static void Merge(int[] arr){
    if (arr == null || arr.Length <= 1) return;
    
}