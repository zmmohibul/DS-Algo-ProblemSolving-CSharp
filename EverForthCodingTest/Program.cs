// See https://aka.ms/new-console-template for more information
void AvailableTime(List<List<int>> arr) 
{
    // var pd = new Dictionary<int, bool>();
    // var ar = arr[0];
    // var c = ar[1] - ar[0];
    // var s = ar[0];

    // for (int i = 0; i < c + 1; i++) {
    //     pd[s] = true;
    //     s += 1;
    // }

    var availableTimeOfPlayers = new List<Dictionary<int, bool>>();

    foreach (var item in arr) {
        var startTime = item[0];
        var endTime = item[1];

        var playerTimeAvailability = new Dictionary<int, bool>();
        var time = startTime;
        for (int i = 0; i < endTime - startTime + 1; i++) {
            playerTimeAvailability[time] = true;
            time += 1;
        }
        availableTimeOfPlayers.Add(playerTimeAvailability);
    }

    foreach (var item in availableTimeOfPlayers) {
        PrintDictionary(item);
        System.Console.WriteLine("--------------");
        System.Console.WriteLine();

    }

}

void PrintDictionary(Dictionary<int, bool> d)
{
    foreach(var (key, value) in d) {
        System.Console.WriteLine(key + ": " + value);
    }
}
Console.WriteLine("Hello, World!");
var inp = new List<List<int>>()
{
    new List<int> {9, 12},
    new List<int> {9, 12},
    new List<int> {9, 12},
    new List<int> {10, 13},
};

AvailableTime(inp);
