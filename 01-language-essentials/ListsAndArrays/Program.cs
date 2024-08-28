// See https://aka.ms/new-console-template for more information
var bikes = new List<string>
{
    "Kawasaki",
    "Yamaha",
    "Suzuki",
    "Ducati"
};

Console.WriteLine("Bikes available:");
foreach (var bike in bikes)
{
    Console.WriteLine(bike);
}

Console.WriteLine($"There are {bikes.Count} bikes available.");