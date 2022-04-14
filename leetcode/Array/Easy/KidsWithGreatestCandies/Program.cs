IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
    var result = new List<bool>();
    var kidWithMaxCandy = 0;

    foreach (var candy in candies)
    {
        if (kidWithMaxCandy < candy)
        {
            kidWithMaxCandy = candy;
        }
    }

    foreach (var candy in candies)
    {
        if (candy + extraCandies >= kidWithMaxCandy)
        {
            result.Add(true);
        }
        else
        {
            result.Add(false);
        }
    }

    return result;
        
}