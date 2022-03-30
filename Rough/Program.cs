var nums = new int[] {-2,1,-3,4,-1,2,1,-5,4};
System.Console.WriteLine(MaxSubArray(nums));


// nums = new int[] {5,4,-1,7,8};
// System.Console.WriteLine(MaxSubArray(nums));


// nums = new int[] {5};
// System.Console.WriteLine(MaxSubArray(nums));

int MaxSubArray(int[] nums) {
    // int result = 0;
    var d = new Dictionary<Tuple<int, int>, int>();

    int sum = 0;
    int max = nums[0];
    for (int i = 0; i < nums.Length; i++) {
        // int sum = nums[i];
        // for (int j = i; j < nums.Length; j++) {
        //     var t = new Tuple<int, int>(i, j);
        //     if (i == j) {
        //         d[t] = sum;
        //     } else {
        //         sum += nums[j];
        //         d[t] = sum;
        //     }
        // }
        sum += nums[i];
        var t = new Tuple<int, int>(0, i);
        d[t] = sum;

        t = new Tuple<int, int>(i, i);
        d[t] = nums[i];
        for (int j = 1; j < i; j++) {
            var t1 = new Tuple<int, int>(j, i - 1);
            
            var s = d[t1];
            s += nums[i];
            
            t1 = new Tuple<int, int>(j, i);
            d[t1] = s;

            if (s > max) {
                max = s;
            }



        }

        if (sum > max) {
            max = sum;
        }

    }

    
    // Tuple<int, int> t1 = new Tuple<int, int>(0, 0);
    

    // foreach (var (k, v) in d) {
    //     System.Console.WriteLine($"[{k}: {v}],");
    //     if (v > max) {
    //         // max = v;
    //         // t1 = k;
    //     }
    // }

    // System.Console.WriteLine(max);
    // System.Console.WriteLine(t1);
    // System.Console.WriteLine(d.Count);
    return max;
}
