// See https://aka.ms/new-console-template for more information
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

    var playerAvailabilityTimeTable = new List<List<int>>();

    foreach (var item in arr) {
        var array = new int[18 - 9 + 1];
        var startTime = item[0];
        var endTime = item[1];
        var c = startTime;
        for (int i = startTime; i <= endTime; i++) {
            array[c - 9] = 1;
            c += 1;
        }
        playerAvailabilityTimeTable.Add(array.ToList());
    }

    foreach(var item in playerAvailabilityTimeTable) {
        foreach(var element in item) {
            System.Console.Write(element + " ");
        }
        System.Console.WriteLine();
    }

    foreach (var playerTime in playerAvailabilityTimeTable) {
        var l = new List<int>();
        for (int i = 0; i < playerTime.Count; i++) {
            if (playerTime[i] == 1) {
                l.Add(i);
            }
        }
        
    }

    System.Console.WriteLine(playerAvailabilityTimeTable[0][0]);

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

