int CountUniqueValues(List<int> list)
{
    var count = 0;
    if (list.Count > 0)
    {
        count += 1;
    }
    
    // [1, 1, 2, 2, 2, 3, 4, 4, 4, 4, 4, 5, 5]
    //        i         i  i              i  j
    var i = 0;
    for (var j = 1; j < list.Count; j++)
    {
        if (list[i] != list[j])
        {
            count += 1;
            i = j;
        }
    }


    return count;
}



Console.WriteLine("Hello, World!");
Console.WriteLine(CountUniqueValues(new List<int>() {1, 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 8}));