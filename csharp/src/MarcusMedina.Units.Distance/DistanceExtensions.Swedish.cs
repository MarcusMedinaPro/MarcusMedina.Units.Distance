namespace MarcusMedina.Units.Distance.Swedish;

/// <summary>
/// Modern svensk längdenhet.
/// Sverige använder SI (meter) sedan 1889, men "mil" är fortfarande vanligt i vardagsspråket.
/// <code>
/// 5.Mil().ToKilometers()     // 50
/// 50.0.Kilometers().ToMil()  // 5.0
/// </code>
/// </summary>
public static class SwedishDistanceExtensions
{
    /// <summary>1 svensk mil = 10 000 m (modern definition)</summary>
    public static Distance Mil(this int value) => new(value * 10_000);
    public static Distance Mil(this double value) => new(value * 10_000);

    public static double ToMil(this Distance d) => d.Meters / 10_000;
}
