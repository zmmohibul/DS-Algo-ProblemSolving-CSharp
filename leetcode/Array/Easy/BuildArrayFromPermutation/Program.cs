// See https://aka.ms/new-console-template for more information
using System.Linq;

int[] BuildArray(int[] nums) {
    
    var ans = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++) {
        ans[i] = nums[nums[i]];
    }
    
    return ans;
    
}

var nums = new int[] {5,0,1,2,3,4};
var ans = BuildArray(nums);
ans.ToList().ForEach(item => Console.Write($"{item}, "));

