// See https://aka.ms/new-console-template for more information
var nums = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
System.Console.WriteLine(MaxSubArray(nums));


// nums = new int[] {5,4,-1,7,8};
// System.Console.WriteLine(MaxSubArray(nums));


// nums = new int[] {5};
// System.Console.WriteLine(MaxSubArray(nums));

int MaxSubArray(int[] nums) {
    // int result = 0;
    var d = new Dictionary<Tuple<int, int>, int>();
    var sum = 0;
    for (int i = 0; i < nums.Length; i++) {
        sum += nums[i];

        var t1 = new Tuple<int, int>(0, i);
        d[t1] = sum;

        if (i + 1 < nums.Length) {
            var s2 = nums[i] + nums[i + 1];
            t1 = new Tuple<int, int>(i, i + 1);
            d[t1] = s2;
        }

        t1 = new Tuple<int, int>(i, i);
        d[t1] = nums[i];

        if (i - 1 > 0) {
            var s1 = nums[i - 1] + nums[i];
            t1 = new Tuple<int, int>(i - 1, i);
            d[t1] = s1;
        }


        if (i - 1 > 0 && i + 1 < nums.Length) {
            var s = nums[i - 1] + nums[i] + nums[i + 1];
            t1 = new Tuple<int, int>(i - 1, i + 1);
            d[t1] = s;
        }

        
        

        
        








        // for (int j = i; j < nums.Length; j++) {
        //     var t = new Tuple<int, int>(i, j);
        //     if (i == j) {
        //         d[t] = sum;
        //     } else {
        //         sum += nums[j];
        //         d[t] = sum;
        //     }
        // }
    }

    int max = nums[0];
    // Tuple<int, int> t1 = new Tuple<int, int>(0, 0);
    

    foreach (var (k, v) in d) {
        System.Console.WriteLine($"[{k}: {v}],");
        if (v > max) {
            max = v;
            // t1 = k;
        }
    }

    // System.Console.WriteLine(max);
    // System.Console.WriteLine(t1);
    System.Console.WriteLine(d.Count);
    return max;
}
