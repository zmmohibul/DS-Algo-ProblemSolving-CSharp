int[] CreateTargetArray(int[] nums, int[] index) {
    // traverse through index array and create a 
    // Dictionary that counts how many times each index appear
    int[] target = new int[index.Length];

    var indexCountDict = new Dictionary<int, int>();
    for (int i = 0; i < index.Length; i++)
    {
        if (!indexCountDict.ContainsKey(index[i]))
        {
            indexCountDict[index[i]] = 1;
        }
        else 
        {
            indexCountDict[index[i]] += 1;
        }
    }

    var whereToStartIndex = new Dictionary<int, int>();
    foreach (var item in index)
    {
        var startPos = 0;
        for (int i = 0; i <= item; i++)
        {
            if (indexCountDict.ContainsKey(i))
            {
                startPos += indexCountDict[i];
            }
        }
        whereToStartIndex[item] = startPos;
    }

    for (int i = 0; i < nums.Length; i++)  
    {
        var placeToInsertInTarget = whereToStartIndex[index[i]];
        target[placeToInsertInTarget - 1] = nums[i];
        whereToStartIndex[index[i]] -= 1;
    }

    return target;     
}

// CreateTargetArray(new int[]{0,1,2,3,4,5,6,7,8}, new int[]{0,1,2,2,1,3,1,3,2});
CreateTargetArray(new int[]{0,1,2,3,4}, new int[]{0,1,2,2,1});
