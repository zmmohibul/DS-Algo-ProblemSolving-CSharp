using System.Text.Json;
using System.Text.Json.Serialization;

var fileContent = await File.ReadAllTextAsync("data.json");
var cars = JsonSerializer.Deserialize<CarData[]>(fileContent);

// print all cars with at least 4 doors
// var carsWithAtLeastFourDoors = cars.Where(car => car.NumberOfDoors >= 4).ToList();
// foreach (var car in carsWithAtLeastFourDoors)
// {
//     Console.WriteLine($"{car.Model} has {car.NumberOfDoors} doors.");
// }



// print all Mazda cars with at least 4 doors
// var mazdaCarsWithAtLeastFourDoors = cars.Where(car => car.NumberOfDoors >= 4 && string.Equals(car.Make, "Mazda"));
// foreach (var car in mazdaCarsWithAtLeastFourDoors)
// {
//     Console.WriteLine($"Make: {car.Make} - Model: {car.Model} - Doors: {car.NumberOfDoors}");
// }



// print Make + Model for all Makes that start with 'M'
// cars.Where(car => car.Make.StartsWith("M"))
//     .Select(car => $"{car.Make} - {car.Model}")
//     .ToList()
//     .ForEach(item =>
//     {
//         Console.WriteLine(item);
//     });



// print a list of 10 most powerful cars (in terms of hp)
// cars.OrderByDescending(car => car.HP)
//     .Take(10)
//     .Select(car => $"{car.Make} - {car.Model} - {car.HP}")
//     .ToList()
//     .ForEach(Console.WriteLine);



// print the number of Models per Make that appeared after 1995
// cars.Where(car => car.Year > 1995)
//     .GroupBy(car => car.Make)
//     .Select(car => $"{car.Key} - {car.Count()}")
//     .ToList()
//     .ForEach(Console.WriteLine);


// print the number of Models per Make that appeared after 1995
// Makes should be displayed with a number of zero if there are no models after 2008
// cars.Where(car => car.Year > 1995)
//     .GroupBy(car => car.Make)
//     .Select(car => new
//     {
//         Key = car.Key,
//         Count = car.Where(car => car.Year > 2008).Count()
//     })
//     .ToList()
//     .ForEach(car =>
//     {
//         Console.WriteLine($"{car.Key} - {car.Count}");
//     });
// alternate syntax
// cars.Where(car => car.Year > 1995)
//     .GroupBy(car => car.Make)
//     .Select(car => new
//     {
//         Key = car.Key,
//         Count = car.Count(car => car.Year > 2008)
//     })
//     .ToList()
//     .ForEach(car =>
//     {
//         Console.WriteLine($"{car.Key} - {car.Count}");
//     });

class CarData
{
    [JsonPropertyName("id")]
    public int ID { get; set; }

    [JsonPropertyName("car_make")]
    public string Make { get; set; }

    [JsonPropertyName("car_models")]
    public string Model { get; set; }

    [JsonPropertyName("car_year")]
    public int Year { get; set; }

    [JsonPropertyName("number_of_doors")]
    public int NumberOfDoors { get; set; }

    [JsonPropertyName("hp")]
    public int HP { get; set; }
}