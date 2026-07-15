namespace MarcusMedina.Units.Distance.BritishOld;

/// <summary>
/// Historiska engelska/brittiska längdenheter.
/// <code>
/// 5.Furlongs().ToMeters()    // ≈ 1005.84 m
/// 3.Leagues().ToKilometers() // ≈ 14.48 km
/// </code>
/// </summary>
public static class BritishOldDistanceExtensions
{
    /// <summary>1 link = 0.201168 m</summary>
    public static Distance Links(this int value) => new(value * 0.201168);
    public static Distance Links(this double value) => new(value * 0.201168);
    /// <summary>1 rod = 25 links = 5.0292 m</summary>
    public static Distance Rods(this int value) => new(value * 5.0292);
    public static Distance Rods(this double value) => new(value * 5.0292);
    /// <summary>1 chain = 4 rods = 100 links = 20.1168 m</summary>
    public static Distance Chains(this int value) => new(value * 20.1168);
    public static Distance Chains(this double value) => new(value * 20.1168);
    /// <summary>1 furlong = 10 chains = 201.168 m</summary>
    public static Distance Furlongs(this int value) => new(value * 201.168);
    public static Distance Furlongs(this double value) => new(value * 201.168);
    /// <summary>1 league = 3 miles = 4828.032 m</summary>
    public static Distance Leagues(this int value) => new(value * 4828.032);
    public static Distance Leagues(this double value) => new(value * 4828.032);
    /// <summary>1 fathom = 6 feet = 1.8288 m</summary>
    public static Distance Fathoms(this int value) => new(value * 1.8288);
    public static Distance Fathoms(this double value) => new(value * 1.8288);
    /// <summary>1 cable = 1/10 nautisk mil = 185.2 m</summary>
    public static Distance Cables(this int value) => new(value * 185.2);
    public static Distance Cables(this double value) => new(value * 185.2);

    public static double ToLinks(this Distance d) => d.Meters / 0.201168;
    public static double ToRods(this Distance d) => d.Meters / 5.0292;
    public static double ToChains(this Distance d) => d.Meters / 20.1168;
    public static double ToFurlongs(this Distance d) => d.Meters / 201.168;
    public static double ToLeagues(this Distance d) => d.Meters / 4828.032;
    public static double ToFathoms(this Distance d) => d.Meters / 1.8288;
    public static double ToCables(this Distance d) => d.Meters / 185.2;
}
