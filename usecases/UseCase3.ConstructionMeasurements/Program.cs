using MarcusMedina.Units.Distance;

// Construction and building measurements

Console.OutputEncoding = System.Text.Encoding.UTF8; // Enable emoji support
Console.WriteLine("=== Construction Measurement Calculator ===\n");

// Building dimensions
Console.WriteLine("--- Building Specifications ---");
var buildingLength = Distance.FromMeters(50);
var buildingWidth = Distance.FromMeters(30);
var buildingHeight = Distance.FromMeters(15);

Console.WriteLine($"Length: {buildingLength.ToMeters()} m ({buildingLength.ToFeet():F0} ft)");
Console.WriteLine($"Width: {buildingWidth.ToMeters()} m ({buildingWidth.ToFeet():F0} ft)");
Console.WriteLine($"Height: {buildingHeight.ToMeters()} m ({buildingHeight.ToFeet():F0} ft)");
var perimeter = buildingLength.Multiply(2).Add(buildingWidth.Multiply(2));
Console.WriteLine($"Perimeter: {perimeter.ToMeters()} m\n");

// Foundation measurements
Console.WriteLine("--- Foundation Planning ---");
var foundationDepth = Distance.FromFeet(3.5);
var foundationWidth = Distance.FromFeet(2);
Console.WriteLine($"Depth: {foundationDepth.ToFeet()} ft ({foundationDepth.ToMeters():F2} m)");
Console.WriteLine($"Width: {foundationWidth.ToFeet()} ft ({foundationWidth.ToMeters():F2} m)\n");

// Material quantities
Console.WriteLine("--- Material Estimation ---");
var wallLength = Distance.FromMeters(100);
var brickSize = Distance.FromInches(8);
var estimatedBricks = (int)(wallLength.ToInches() / brickSize.ToInches());
Console.WriteLine($"Wall length: {wallLength.ToMeters()} m");
Console.WriteLine($"Brick size: {brickSize.ToInches()} inches");
Console.WriteLine($"Estimated bricks: {estimatedBricks:N0}\n");

// Spacing calculations
Console.WriteLine("--- Spacing & Layout ---");
var totalDistance = Distance.FromMeters(30);
var spacing = Distance.FromMeters(1.5);
var numberOfSpacings = (int)(totalDistance.ToMeters() / spacing.ToMeters());
Console.WriteLine($"Total distance: {totalDistance.ToMeters()} m");
Console.WriteLine($"Spacing between items: {spacing.ToMeters()} m");
Console.WriteLine($"Number of items: {numberOfSpacings}\n");

Console.WriteLine("✓ Construction calculations complete!");
