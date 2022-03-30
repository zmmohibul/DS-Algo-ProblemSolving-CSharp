// See https://aka.ms/new-console-template for more information
var nums = new int[] {-2, 1, -3, 4, -1, 2};
MaxSubArray(nums);

int MaxSubArray(int[] nums) {
    int result = 0;
    var d = new Dictionary<int, Tuple<int, int>>();

    for (int i = 0; i < nums.Length; i++) {
        int sum = nums[i];
        for (int j = i; j < nums.Length; j++) {
            var t = new Tuple<int, int>(i, j);
            if (i == j) {
                d[sum] = t;
            } else {
                sum += nums[j];
                d[sum] = t;
            }
        }
    }

    foreach (var (k, v) in d) {
        System.Console.WriteLine($"[{v}: {k}],");
    }

    return result;
}
