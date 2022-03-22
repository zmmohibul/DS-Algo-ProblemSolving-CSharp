// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Collections;
List<int> AvailableTime(List<List<int>> arr) 
{
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

    var doublePlayerMatches = 0;
    foreach (var (slot, player) in timeSlots)
    {
        if (player.Count >= 4)
        {
            doublePlayerMatches += 1;
            player.RemoveRange(0, 4);
        }
    }



    var singlePlayerMatches = 0;
    foreach (var (slot, player) in timeSlots)
    {
        if (player.Count >= 2)
        {
            singlePlayerMatches += 1;
            player.RemoveRange(0, 2);
        }
    }
    
    var output = new List<int>();
    output.Add(singlePlayerMatches);
    output.Add(doublePlayerMatches);
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
