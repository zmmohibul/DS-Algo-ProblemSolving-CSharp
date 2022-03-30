// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var nums = new int[] {1, 3, 7, 9, 2};
var result = TwoSums(nums, 11);
System.Console.WriteLine($"[{result[0]}, {result[1]}]");

nums = new int[] {9, 2};
result = TwoSums(nums, 11);
System.Console.WriteLine($"[{result[0]}, {result[1]}]");

nums = new int[] {9, 3};
result = TwoSums(nums, 11);

if (result == null) {
    System.Console.WriteLine("Null..");
} else {
    System.Console.WriteLine("Uh oh! Didn't work.");
}

nums = new int[] {9};
result = TwoSums(nums, 11);

if (result == null) {
    System.Console.WriteLine("Null..");
} else {
    System.Console.WriteLine("Uh oh! Didn't work.");
}


nums = new int[] {1, 3, 7, 9, 3, 5, 2};
result = TwoSums(nums, 11);
if (result == null) {
    System.Console.WriteLine("Null..");
} else {
    System.Console.WriteLine($"[{result[0]}, {result[1]}]");
}

nums = new int[] {};
result = TwoSums(nums, 11);
if (result == null) {
    System.Console.WriteLine("Null..");
} else {
    System.Console.WriteLine($"[{result[0]}, {result[1]}]");
}

int[] TwoSums(int[] nums, int target) {
    if (nums.Length < 2) {
        return null;
    }

    if (nums.Length == 2) {
        if (nums[0] + nums[1] == target) {
            return new int[] {0, 1};
        } else {
            return null;
        }
    }

    int[] result = new int[2];

    for (int i = 0; i < nums.Length; i++) {
        int numberToFind = target - nums[i];
        for (int j = i + 1; j < nums.Length; j++) {
            if (nums[j] == numberToFind) {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }


    return null;
}
