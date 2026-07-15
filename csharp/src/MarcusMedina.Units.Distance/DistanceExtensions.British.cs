namespace MarcusMedina.Units.Distance.British;

/// <summary>
/// Moderna brittiska/imperiala längdenheter.
/// <code>
/// 5.Miles().ToKilometers()   // ≈ 8.047
/// 6.Feet().ToMeters()        // ≈ 1.829
/// </code>
/// </summary>
public static class BritishDistanceExtensions
{
    /// <summary>1 inch (tum) = 0.0254 m</summary>
    public static Distance Inches(this int value) => new(value * 0.0254);
    public static Distance Inches(this double value) => new(value * 0.0254);
    /// <summary>1 foot = 0.3048 m</summary>
    public static Distance Feet(this int value) => new(value * 0.3048);
    public static Distance Feet(this double value) => new(value * 0.3048);
    /// <summary>1 yard = 0.9144 m</summary>
    public static Distance Yards(this int value) => new(value * 0.9144);
    public static Distance Yards(this double value) => new(value * 0.9144);
    /// <summary>1 mile = 1609.344 m</summary>
    public static Distance Miles(this int value) => new(value * 1609.344);
    public static Distance Miles(this double value) => new(value * 1609.344);
    /// <summary>1 nautisk mil = 1852 m</summary>
    public static Distance NauticalMiles(this int value) => new(value * 1852);
    public static Distance NauticalMiles(this double value) => new(value * 1852);

    public static double ToInches(this Distance d) => d.Meters / 0.0254;
    public static double ToFeet(this Distance d) => d.Meters / 0.3048;
    public static double ToYards(this Distance d) => d.Meters / 0.9144;
    public static double ToMiles(this Distance d) => d.Meters / 1609.344;
    public static double ToNauticalMiles(this Distance d) => d.Meters / 1852;
}
