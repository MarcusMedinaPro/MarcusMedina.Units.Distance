using MarcusMedina.Units.Distance;

// GPS and mapping calculations using distance units

Console.OutputEncoding = System.Text.Encoding.UTF8; // Enable emoji support
Console.WriteLine("=== GPS Distance Calculator ===\n");

// Route planning
Console.WriteLine("--- Route Planning ---");
var leg1 = Distance.FromMiles(5.2);
var leg2 = Distance.FromKilometers(8.3);
var leg3 = Distance.FromMeters(1200);

var totalDistance = leg1.Add(leg2).Add(leg3);
Console.WriteLine($"Leg 1: {leg1.ToMiles():F2} miles");
Console.WriteLine($"Leg 2: {leg2.ToKilometers():F2} km");
Console.WriteLine($"Leg 3: {leg3.ToMeters():F0} meters");
Console.WriteLine($"Total: {totalDistance.ToKilometers():F2} km ({totalDistance.ToMiles():F2} miles)\n");

// Radius calculations
Console.WriteLine("--- Search Radius ---");
var searchRadius = Distance.FromMiles(1.5);
var inKm = searchRadius.ToKilometers();
var inMeters = searchRadius.ToMeters();
Console.WriteLine($"Search within: {searchRadius.ToMiles()} miles");
Console.WriteLine($"            = {inKm:F2} km");
Console.WriteLine($"            = {inMeters:F0} meters\n");

// Elevation conversions
Console.WriteLine("--- Altitude ---");
var mountainHeight = Distance.FromMeters(4000);
var inFeet = mountainHeight.ToFeet();
Console.WriteLine($"Peak altitude: {mountainHeight.ToMeters()} m");
Console.WriteLine($"             = {inFeet:F0} feet\n");

Console.WriteLine("✓ GPS calculations complete!");
