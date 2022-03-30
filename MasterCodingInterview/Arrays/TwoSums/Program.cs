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
    for (int i = 0; i < nums.Length; i++) {
        int numberToFind = target - nums[i];
        for (int j = i + 1; j < nums.Length; j++) {
            if (nums[j] == numberToFind) {
                return new int[] {i, j};
            }
        }
    }


    return null;
}
