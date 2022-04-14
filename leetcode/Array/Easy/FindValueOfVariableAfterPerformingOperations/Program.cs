int FinalValueAfterOperations(string[] operations) 
{
    int value = 0;

    foreach (var operation in operations) 
    {
        if (operation.Equals("X++"))
        {
            value++;
        }
        else if (operation.Equals("++X"))
        {
            ++value;
        }
        else if (operation.Equals("--X"))
        {
            --value;
        }
        else if (operation.Equals("X--"))
        {
            value--;
        }
    }


    return value;
}

var operations = new string[] {"--X","X++","X++"};
System.Console.WriteLine(FinalValueAfterOperations(operations));

operations = new string[] {"++X","++X","X++"};
System.Console.WriteLine(FinalValueAfterOperations(operations));