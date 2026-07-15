namespace MarcusMedina.Units.Distance.US;

/// <summary>
/// USA:s customary units — skiljer sig något från imperiala mått.
/// US survey foot = 1200/3937 m ≈ 0.3048006 m (istället för 0.3048).
/// <code>
/// 5.SurveyMiles().ToMeters()  // ≈ 8046.74 m (något mer än 5 internationella miles)
/// </code>
/// </summary>
public static class USDistanceExtensions
{
    /// <summary>1 US survey foot = 1200/3937 m ≈ 0.3048006 m</summary>
    public static Distance SurveyFeet(this int value) => new(value * 1200.0 / 3937.0);
    public static Distance SurveyFeet(this double value) => new(value * 1200.0 / 3937.0);
    /// <summary>1 US survey mile = 5280 survey feet ≈ 1609.347 m</summary>
    public static Distance SurveyMiles(this int value) => new(value * 5280.0 * 1200.0 / 3937.0);
    public static Distance SurveyMiles(this double value) => new(value * 5280.0 * 1200.0 / 3937.0);
    /// <summary>1 US rod = 16.5 survey feet ≈ 5.02921 m</summary>
    public static Distance UsRods(this int value) => new(value * 16.5 * 1200.0 / 3937.0);
    public static Distance UsRods(this double value) => new(value * 16.5 * 1200.0 / 3937.0);
    /// <summary>1 US chain = 66 survey feet ≈ 20.11684 m</summary>
    public static Distance UsChains(this int value) => new(value * 66.0 * 1200.0 / 3937.0);
    public static Distance UsChains(this double value) => new(value * 66.0 * 1200.0 / 3937.0);

    public static double ToSurveyFeet(this Distance d) => d.Meters / (1200.0 / 3937.0);
    public static double ToSurveyMiles(this Distance d) => d.Meters / (5280.0 * 1200.0 / 3937.0);
    public static double ToUsRods(this Distance d) => d.Meters / (16.5 * 1200.0 / 3937.0);
    public static double ToUsChains(this Distance d) => d.Meters / (66.0 * 1200.0 / 3937.0);
}
