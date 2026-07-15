using System.Text;
using MarcusMedina.Units.Distance;
using MarcusMedina.Units.Distance.Conversion;
using MarcusMedina.Units.Distance.Core;
using MarcusMedina.Units.Distance.Enums;
using MarcusMedina.Units.Distance.Errors;
using MarcusMedina.Units.Distance.Extensions;
using MarcusMedina.Units.Distance.Imperial;
using MarcusMedina.Units.Distance.Metric;

Console.OutputEncoding = System.Text.Encoding.UTF8; // Enable emoji support
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== Fluent Distance Demo ===");
Console.WriteLine();

// Build a commute distance and surface in kilometres.
var commute = Distance.Metric()
    .SetValue(12_500)
    .As(MetricUnit.Metre)
    .To(MetricUnit.Kilometre);

Console.WriteLine($"Commute: {commute.ToHumanReadable()} ({commute.Metres:N0} metres)");

// Model a hiking trail in imperial units but view it in metric via converters.
var ridgeHeight = Distance.Imperial()
    .SetValue(5_280)
    .As(ImperialUnit.Foot)
    .To(ImperialUnit.Mile);

var ridgeMiles = DistanceConverter.Convert<Mile>(ridgeHeight);
var ridgeMetres = DistanceConverter.Convert<Mile, Metre>(ridgeMiles);
Console.WriteLine($"Ridge height: {ridgeMiles.Value} {ridgeHeight.Symbol} ≈ {ridgeMetres.Value:F2} m");

// Use numeric extensions and parsing helpers for ad-hoc calculations.
var panelWidth = 750.Millimetres();
var panelGap = DistanceConverter.Convert<Centimetre>(LengthExtensions.FromExpression("2.5cm"));
var totalSpan = LengthOperators.Add(panelWidth, panelGap);

Console.WriteLine($"Panel span: {Length.From(totalSpan).ToHumanReadable()}");

// Cosmic scale: convert light-years to human-friendly kilometres.
var neighbourStar = Distance.Cosmic()
    .SetValue(0.25)
    .As(CosmicUnit.LightYear)
    .To(CosmicUnit.Kilometre);

Console.WriteLine($"Nearest star sample: {neighbourStar.Metres / 1_000_000_000_000_000:N3} trillion km");

// Validate guard rails – this will trip the Han Solo easter egg.
try
{
    _ = LengthExtensions.FromExpression("twelve parsecs");
}
catch (HanSoloException ex)
{
    Console.WriteLine($"Caught expected guard: {ex.Message}");
}

Console.WriteLine();
Console.WriteLine("Range example:");
var acceptable = new DistanceRange(Length.From(new Metre(0.5)), Length.From(new Metre(2.0)));
Console.WriteLine($"  Within range? {acceptable.Contains(Length.From(panelWidth))}");

Console.WriteLine();
Console.WriteLine("Demo complete.");
