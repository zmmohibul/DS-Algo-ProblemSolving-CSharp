// See https://aka.ms/new-console-template for more information
var nums = new int[] {-2, 1, -3, 4, -1, 2};
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

    foreach (var (k, v) in d) {
        System.Console.WriteLine($"[{k}: {v}],");
    }

    return result;
}
