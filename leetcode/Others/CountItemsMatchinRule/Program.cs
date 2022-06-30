int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) 
{
    var count = 0;

    var ruleKeyIndex = 0;

    if (ruleKey.Equals("type"))
    {
        ruleKeyIndex = 0;
    }
    else if (ruleKey.Equals("color"))
    {
        ruleKeyIndex = 1;
    }
    else if (ruleKey.Equals("name"))
    {
        ruleKeyIndex = 2;
    }

    foreach (var item in items)
    {
        if (item[ruleKeyIndex].Equals(ruleValue))
        {
            count += 1;
        }
    }


    return count;
        
}