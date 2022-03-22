// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Collections;
void AvailableTime(List<List<int>> arr) 
{
    // var availableTimeOfPlayers = new List<Dictionary<int, bool>>();

    // foreach (var item in arr) {
    //     var startTime = item[0];
    //     var endTime = item[1];

    //     var playerTimeAvailability = new Dictionary<int, bool>();
    //     var time = startTime;
    //     for (int i = 0; i < endTime - startTime + 1; i++) {
    //         playerTimeAvailability[time] = true;
    //         time += 1;
    //     }

    //     availableTimeOfPlayers.Add(playerTimeAvailability);
    // }

    // var doubleTime = 0;

    // var playerOneTimeAvailability = availableTimeOfPlayers[0].Keys.ToArray();
    // for (int i = 0; i < playerOneTimeAvailability.Length - 1; i++) {
    //     var b = true;
        
    //     foreach (var item in availableTimeOfPlayers) {

    //         if (!(item.ContainsKey(playerOneTimeAvailability[i]) && item.ContainsKey(playerOneTimeAvailability[i + 1]))) {
    //             b = false;
    //         }
    //     }

    //     if (b) {
    //         doubleTime += 1;
    //     }
    // }

    // System.Console.WriteLine(doubleTime);

    // var playerAvailabilityTimeTable = new List<List<int>>();

    // foreach (var item in arr) {
    //     var array = new int[18 - 9 + 1];
    //     var startTime = item[0];
    //     var endTime = item[1];
    //     var c = startTime;
    //     for (int i = startTime; i <= endTime; i++) {
    //         array[c - 9] = 1;
    //         c += 1;
    //     }
    //     playerAvailabilityTimeTable.Add(array.ToList());
    // }

    // foreach(var item in playerAvailabilityTimeTable) {
    //     foreach(var element in item) {
    //         System.Console.Write(element + " ");
    //     }
    //     System.Console.WriteLine();
    // }

    // foreach (var playerTime in playerAvailabilityTimeTable) {
    //     var l = new List<int>();
    //     for (int i = 0; i < playerTime.Count; i++) {
    //         if (playerTime[i] == 1) {
    //             l.Add(i);
    //         }
    //     }

    // }

    // System.Console.WriteLine(playerAvailabilityTimeTable[0][0]);

    // var playerAvailabilityTimeTable = new List<List<Tuple<int, int>>>();

    // foreach (var item in arr) 
    // {
    //     var playerStartTime = item[0];
    //     var playerEndTime = item[1];

    //     var playerTimeAvailability = new List<Tuple<int, int>>();
    //     for (int i = playerStartTime; i < playerEndTime; i++)
    //     {
    //         playerTimeAvailability.Add(new Tuple<int, int>(i, i + 1));
    //     }
    //     playerAvailabilityTimeTable.Add(playerTimeAvailability);
    // }

    // var pi = 1;
    // foreach (var item in playerAvailabilityTimeTable)
    // {
    //     System.Console.Write($"Player-{pi}: ");
    //     foreach (var element in item) 
    //     {
    //         System.Console.Write(element.ToString() + ", ");
    //     }
    //     System.Console.WriteLine();
    //     pi += 1;
    // }

    // for (int i = 0; i < playerAvailabilityTimeTable.Count; i++)
    // {

    // }

    // var playerAvailabilityTimeTable = new List<Dictionary<Tuple<int, int>, bool>>();

    // foreach (var item in arr) 
    // {
    //     var startTime = item[0];
    //     var endTime = item[1];

    //     var playerTimeAvailability = new Dictionary<Tuple<int, int>, bool>();
    //     for (int i = startTime; i < endTime; i++)
    //     {
    //         playerTimeAvailability[new Tuple<int, int>(i, i + 1)] = true;
    //     }
    //     playerAvailabilityTimeTable.Add(playerTimeAvailability);
    // }

    // foreach (var item in playerAvailabilityTimeTable)
    // {
    //     foreach (var (key, value) in item) 
    //     {
    //         System.Console.Write($"{key.ToString()}, ");
    //     }
    //     System.Console.WriteLine();
    // }


    // for (int i = 0; i < playerAvailabilityTimeTable.Count; i++) 
    // {
    //     var iPlayerTime = playerAvailabilityTimeTable[i];

    //     var playersAvailableAtSlot = new Dictionary<Tuple<int, int>, int>();

    //     foreach (var (timeSlot, available) in iPlayerTime) 
    //     {
            
    //         for (int j = i + 1; j < playerAvailabilityTimeTable.Count; j++) 
    //         {
    //             if (playerAvailabilityTimeTable[j].ContainsKey(timeSlot) && playerAvailabilityTimeTable[j][timeSlot])
    //             {
                    
    //             }
    //         }
    //     }
    // }


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


