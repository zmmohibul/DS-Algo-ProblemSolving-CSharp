// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

System.Console.WriteLine(RemoveDuplicates(new int[]{1, 1, 1, 1, 2, 3, 3, 4, 4, 4, 5, 6}));


int RemoveDuplicates(int[] nums) {

    int i = 0;
    int j = 0;

    while (j < nums.Length) {
        if (nums[i] == nums[j]) {
            j += 1;
        } else {
            nums[i + 1] = nums[j];
            i += 1;
        }
    }
        
    return i + 1;
}