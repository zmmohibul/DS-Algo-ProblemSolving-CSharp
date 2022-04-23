System.Console.WriteLine(MinOperations(new int[]{1,5,2,4,1}));

int MinOperations(int[] nums)
 {
        int operationCount = 0;
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i + 1] <= nums[i]) {
                int iplus1Increment = nums[i] - nums[i + 1] + 1;
                operationCount += iplus1Increment;
                nums[i + 1] += iplus1Increment;
                    
            }
        }
        
        return operationCount;
}