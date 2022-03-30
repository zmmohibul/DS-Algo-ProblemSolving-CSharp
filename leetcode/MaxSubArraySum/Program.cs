// See https://aka.ms/new-console-template for more information
var nums = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
MaxSubArray(nums);

int MaxSubArray(int[] nums) {
    int result = 0;
    var d = new Dictionary<Tuple<int, int>, int>();

    for (int i = 0; i < nums.Length; i++) {
        int sum = nums[i];
        for (int j = i; j < nums.Length; j++) {
            var t = new Tuple<int, int>(i, j);
            if (i == j) {
                d[t] = sum;
            } else {
                sum += nums[j];
                d[t] = sum;
            }
        }
    }

    int max = 0;
    Tuple<int, int> t1 = new Tuple<int, int>(0, 0);
    

    foreach (var (k, v) in d) {
        System.Console.WriteLine($"[{k}: {v}],");
        if (v > max) {
            max = v;
            t1 = k;
        }
    }

    System.Console.WriteLine(max);
    System.Console.WriteLine(t1);

    return result;
}
