using MarcusMedina.Units.Distance;

// Travel distance tracking and conversion

Console.OutputEncoding = System.Text.Encoding.UTF8; // Enable emoji support
Console.WriteLine("=== Travel Distance Tracker ===\n");

// Road trip tracking
Console.WriteLine("--- Road Trip Tracking ---");
var dailyDistances = new[]
{
    Distance.FromMiles(250),
    Distance.FromMiles(280),
    Distance.FromMiles(220)
};

var totalTrip = dailyDistances.Aggregate((a, b) => a.Add(b));
Console.WriteLine($"Day 1: {dailyDistances[0].ToMiles():F0} miles");
Console.WriteLine($"Day 2: {dailyDistances[1].ToMiles():F0} miles");
Console.WriteLine($"Day 3: {dailyDistances[2].ToMiles():F0} miles");
Console.WriteLine($"Total: {totalTrip.ToMiles():F0} miles ({totalTrip.ToKilometers():F0} km)\n");

// Fuel efficiency calculation
Console.WriteLine("--- Fuel Economy ---");
var distance = Distance.FromMiles(300);
var fuelUsed = 12.5;  // gallons
var efficiency = distance.ToMiles() / fuelUsed;
Console.WriteLine($"Distance: {distance.ToMiles()} miles");
Console.WriteLine($"Fuel used: {fuelUsed} gallons");
Console.WriteLine($"Efficiency: {efficiency:F2} mpg\n");

// Weekly running tracker
Console.WriteLine("--- Running Tracker ---");
var runs = new[]
{
    Distance.FromMiles(3),
    Distance.FromMiles(5),
    Distance.FromMiles(4),
    Distance.FromMiles(6),
};

var weeklyDistance = runs.Aggregate((a, b) => a.Add(b));
var averageRun = Distance.FromMeters(weeklyDistance.ToMeters() / runs.Length);
Console.WriteLine($"Runs: {string.Join(", ", runs.Select(r => r.ToMiles().ToString("F1") + "mi"))}");
Console.WriteLine($"Weekly total: {weeklyDistance.ToMiles():F1} miles");
Console.WriteLine($"Average run: {averageRun.ToMiles():F2} miles\n");

Console.WriteLine("✓ Travel tracking complete!");
