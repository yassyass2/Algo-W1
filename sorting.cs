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

public static void Split (int l, int h){
    if (l>=h) return;
    int m = (l+h)/2;
    Split(l, m);
    Split(m+1, h)
}

public static int[] Merge(int[] arr1, int[] arr2){
    if (arr1 == null || arr2 == null) return;
    int finalsize = arr1.Length + arr2.Length;
    int[] result = new int[finalsize];

    int x = 0;
    int y = 0;
    for(int i = 0; i < finalsize; i++){
        if (x < arr1.Length && y < arr2.Length){
            if(arr1[x] < arr2[y]){
            result[i] = arr1[x];
            x++
            }
            else{
                result[i] = arr2[y];
                y++
            }
        }
        
    }
}