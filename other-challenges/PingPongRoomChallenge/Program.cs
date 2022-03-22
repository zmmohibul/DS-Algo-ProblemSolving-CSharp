using System.Collections.Generic;

List<int> AvailableTime(List<List<int>> arr) 
{
    const int SINGLE_MATCH_PLAYER_COUNT = 2;
    const int DOUBLE_MATCH_PLAYER_COUNT = 4;

    var timeSlots = new Dictionary<Tuple<int, int>, List<int>>();
    var playerNumber = 1;
    foreach(var item in arr) 
    {
        var startTime = item[0];
        var endTime = item[1];


        for (int i = startTime; i < endTime; i++) 
        {
            var timeSlot = new Tuple<int, int> (i, i + 1);
            if (!timeSlots.ContainsKey(timeSlot))
            {
                timeSlots[timeSlot] = new List<int>();
                timeSlots[timeSlot].Add(playerNumber);
            }
            else
            {
                timeSlots[timeSlot].Add(playerNumber);
            }

        }

        playerNumber += 1;
    }

    var doublePlayerMatchHours = 0;
    foreach (var (slot, player) in timeSlots)
    {
        if (player.Count >= DOUBLE_MATCH_PLAYER_COUNT)
        {
            doublePlayerMatchHours += 1;
            player.RemoveRange(0, 4);
        }
    }



    var singlePlayerMatchHours = 0;
    foreach (var (slot, player) in timeSlots)
    {
        if (player.Count >= SINGLE_MATCH_PLAYER_COUNT)
        {
            singlePlayerMatchHours += 1;
            player.RemoveRange(0, 2);
        }
    }
    
    var output = new List<int>();
    output.Add(singlePlayerMatchHours);
    output.Add(doublePlayerMatchHours);
    return output;
}


var inp = new List<List<int>>()
{
    new List<int> {9, 12},
    new List<int> {9, 12},
    new List<int> {9, 12},
    new List<int> {10, 13},
};

var result = AvailableTime(inp);
System.Console.WriteLine($"[{result[0]}, {result[1]}]");



var inp2 = new List<List<int>>()
{
    new List<int> {9, 14},
    new List<int> {15, 17},
    new List<int> {12, 13},
    new List<int> {16, 18},
    new List<int> {10, 15},
    new List<int> {14, 16},
    new List<int> {9, 13},
    new List<int> {9, 15},

};


result = AvailableTime(inp2);
System.Console.WriteLine($"[{result[0]}, {result[1]}]");



var inp3 = new List<List<int>>()
{
    new List<int> {9,10},
    new List<int> {9,12},
    new List<int> {14,15},
    new List<int> {16,18},
    new List<int> {14,18},
    new List<int> {10,13},
    new List<int> {15,18},
    new List<int> {10,14},
    new List<int> {9,13},
};


result = AvailableTime(inp3);
System.Console.WriteLine($"[{result[0]}, {result[1]}]");

var inp4 = new List<List<int>>()
{
    new List<int> {9,10},
    new List<int> {9,12},
    new List<int> {13,15},
    new List<int> {10,18}
};


result = AvailableTime(inp4);
System.Console.WriteLine($"[{result[0]}, {result[1]}]");