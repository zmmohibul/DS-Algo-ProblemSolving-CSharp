System.Console.WriteLine(LargestAltitude(new int[] {-5,1,5,0,-7}));
System.Console.WriteLine(LargestAltitude(new int[] {-4,-3,-2,-1,4,3,2}));


int LargestAltitude(int[] gain) 
{
    int highestAltitude = 0;

    var currentAltitude = 0;
    for (int i = 0; i < gain.Length; i++)
    {
        currentAltitude += gain[i];
        if (currentAltitude > highestAltitude)
        {
            highestAltitude = currentAltitude;
        }
    }


    return highestAltitude;
}