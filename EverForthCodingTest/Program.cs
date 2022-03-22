// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Collections;
void AvailableTime(List<List<int>> arr) 
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

    // foreach (var (slot, players) in timeSlots)
    // {
    //     System.Console.Write(slot.ToString() + ": ");
    //     foreach (var player in players)
    //     {
    //         System.Console.Write(player + ", ");
    //     }

    //     System.Console.WriteLine();
    // }

    var doublePlayerMatches = 0;
    foreach (var (slot, player) in timeSlots)
    {
        if (player.Count >= 4)
        {
            doublePlayerMatches += 1;
            player.RemoveRange(0, 4);
        }
    }

    System.Console.WriteLine("Number of double matches: " + doublePlayerMatches);
    foreach (var (slot, players) in timeSlots)
    {
        System.Console.Write(slot.ToString() + ": ");
        foreach (var player in players)
        {
            System.Console.Write(player + ", ");
        }

        System.Console.WriteLine();
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
    System.Console.WriteLine("Number of single matches: " + singlePlayerMatches);
    foreach (var (slot, players) in timeSlots)
    {
        System.Console.Write(slot.ToString() + ": ");
        foreach (var player in players)
        {
            System.Console.Write(player + ", ");
        }

        System.Console.WriteLine();
    }

    System.Console.WriteLine("hello");
}


// void PrintDictionary(Dictionary<int, bool> d)
// {
//     foreach(var (key, value) in d) {
//         System.Console.WriteLine(key + ": " + value);
//     }
// }
Console.WriteLine("Hello, World!");
// var inp = new List<List<int>>()
// {
//     new List<int> {9, 12},
//     new List<int> {9, 12},
//     new List<int> {9, 12},
//     new List<int> {10, 13},
// };


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

// AvailableTime(inp);
AvailableTime(inp2);

var t1 = new Tuple<int, int>(10, 11);
var t2 = new Tuple<int, int>(10, 12);

System.Console.WriteLine(t1.ToString());
System.Console.WriteLine(t2.ToString());
System.Console.WriteLine(t1.ToString().Equals(t2.ToString()));

var d = new Dictionary<Tuple<int, int>, bool>();
d[new Tuple<int, int>(9, 10)] = true;
d[new Tuple<int, int>(10, 11)] = true;
d[new Tuple<int, int>(11, 12)] = true;
d[new Tuple<int, int>(13, 14)] = true;
d.ContainsKey(new Tuple<int, int>(11, 12));

var l1 = new List<int> {1, 2, 3, 4, 5, 6, 7};
var l2 = new List<int> {1, 2, 3, 4, 5, 6, 7};

l1.RemoveRange(0, 4);
l1.ForEach(System.Console.WriteLine);


