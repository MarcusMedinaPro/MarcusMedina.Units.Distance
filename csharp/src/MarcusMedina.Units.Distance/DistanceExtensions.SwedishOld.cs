namespace MarcusMedina.Units.Distance.SwedishOld;

/// <summary>
/// Gamla svenska längdenheter — före metersystemets införande (1889).
/// Baseras på Rhenländsk fot (före 1855).
/// <code>
/// 5.SwedishMiles().ToKilometers()  // 53.44 km
/// 3.Alnar().ToMeters()             // ≈ 1.88 m
/// </code>
/// </summary>
public static class SwedishOldDistanceExtensions
{
    /// <summary>1 tum = 1/12 fot ≈ 0.02615 m</summary>
    public static Distance Tum(this int value) => new(value * 0.026154);
    public static Distance Tum(this double value) => new(value * 0.026154);
    /// <summary>1 fot (Rhenländsk) ≈ 0.31385 m</summary>
    public static Distance Fot(this int value) => new(value * 0.31385);
    public static Distance Fot(this double value) => new(value * 0.31385);
    /// <summary>1 kvart = 6 tum = 1/2 fot ≈ 0.1569 m</summary>
    public static Distance Kvart(this int value) => new(value * 0.1569);
    public static Distance Kvart(this double value) => new(value * 0.1569);
    /// <summary>1 aln = 2 fot ≈ 0.6277 m</summary>
    public static Distance Alnar(this int value) => new(value * 0.6277);
    public static Distance Alnar(this double value) => new(value * 0.6277);
    /// <summary>1 famn = 3 alnar ≈ 1.8831 m</summary>
    public static Distance Famnar(this int value) => new(value * 1.8831);
    public static Distance Famnar(this double value) => new(value * 1.8831);
    /// <summary>1 ref = 1/4 gammal mil = 2672 m</summary>
    public static Distance Ref(this int value) => new(value * 2672);
    public static Distance Ref(this double value) => new(value * 2672);
    /// <summary>1 gammal svensk landmil = 10 688 m (före 1889)</summary>
    public static Distance SwedishMiles(this int value) => new(value * 10_688);
    public static Distance SwedishMiles(this double value) => new(value * 10_688);

    public static double ToTum(this Distance d) => d.Meters / 0.026154;
    public static double ToFot(this Distance d) => d.Meters / 0.31385;
    public static double ToKvart(this Distance d) => d.Meters / 0.1569;
    public static double ToAlnar(this Distance d) => d.Meters / 0.6277;
    public static double ToFamnar(this Distance d) => d.Meters / 1.8831;
    public static double ToRef(this Distance d) => d.Meters / 2672;
    public static double ToSwedishMiles(this Distance d) => d.Meters / 10_688;
}
