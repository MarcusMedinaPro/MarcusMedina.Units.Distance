namespace MarcusMedina.Units.Distance.Astronomical;

/// <summary>Astronomical distance units.</summary>
public static class AstronomicalDistanceExtensions
{
    /// <summary>Creates a Distance from light-seconds.</summary>
    public static Distance LightSeconds(this int value) => new(value * 299_792_458.0);
    /// <summary>Creates a Distance from light-seconds.</summary>
    public static Distance LightSeconds(this double value) => new(value * 299_792_458.0);

    /// <summary>Creates a Distance from light-minutes.</summary>
    public static Distance LightMinutes(this int value) => new(value * 17_987_547_480.0);
    /// <summary>Creates a Distance from light-minutes.</summary>
    public static Distance LightMinutes(this double value) => new(value * 17_987_547_480.0);

    /// <summary>Creates a Distance from light-hours.</summary>
    public static Distance LightHours(this int value) => new(value * 1_079_252_848_800.0);
    /// <summary>Creates a Distance from light-hours.</summary>
    public static Distance LightHours(this double value) => new(value * 1_079_252_848_800.0);

    /// <summary>Creates a Distance from light-days.</summary>
    public static Distance LightDays(this int value) => new(value * 25_902_068_371_200.0);
    /// <summary>Creates a Distance from light-days.</summary>
    public static Distance LightDays(this double value) => new(value * 25_902_068_371_200.0);

    /// <summary>Creates a Distance from light-years.</summary>
    public static Distance LightYears(this int value) => new(value * 9_460_730_472_580_800.0);
    /// <summary>Creates a Distance from light-years.</summary>
    public static Distance LightYears(this double value) => new(value * 9_460_730_472_580_800.0);

    /// <summary>Creates a Distance from astronomical units (AU).</summary>
    public static Distance AstronomicalUnits(this int value) => new(value * 149_597_870_700.0);
    /// <summary>Creates a Distance from astronomical units (AU).</summary>
    public static Distance AstronomicalUnits(this double value) => new(value * 149_597_870_700.0);

    /// <summary>Creates a Distance from parsecs.</summary>
    public static Distance Parsecs(this int value) => new(value * 3.085677581e16);
    /// <summary>Creates a Distance from parsecs.</summary>
    public static Distance Parsecs(this double value) => new(value * 3.085677581e16);

    /// <summary>Creates a Distance from kiloparsecs.</summary>
    public static Distance Kiloparsecs(this int value) => new(value * 3.085677581e19);
    /// <summary>Creates a Distance from kiloparsecs.</summary>
    public static Distance Kiloparsecs(this double value) => new(value * 3.085677581e19);

    /// <summary>Creates a Distance from megaparsecs.</summary>
    public static Distance Megaparsecs(this int value) => new(value * 3.085677581e22);
    /// <summary>Creates a Distance from megaparsecs.</summary>
    public static Distance Megaparsecs(this double value) => new(value * 3.085677581e22);

    /// <summary>Creates a Distance from gigaparsecs.</summary>
    public static Distance Gigaparsecs(this int value) => new(value * 3.085677581e25);
    /// <summary>Creates a Distance from gigaparsecs.</summary>
    public static Distance Gigaparsecs(this double value) => new(value * 3.085677581e25);

    /// <summary>Converts to light-seconds.</summary>
    public static double ToLightSeconds(this Distance d) => d.Meters / 299_792_458.0;

    /// <summary>Converts to light-minutes.</summary>
    public static double ToLightMinutes(this Distance d) => d.Meters / 17_987_547_480.0;

    /// <summary>Converts to light-hours.</summary>
    public static double ToLightHours(this Distance d) => d.Meters / 1_079_252_848_800.0;

    /// <summary>Converts to light-days.</summary>
    public static double ToLightDays(this Distance d) => d.Meters / 25_902_068_371_200.0;

    /// <summary>Converts to light-years.</summary>
    public static double ToLightYears(this Distance d) => d.Meters / 9_460_730_472_580_800.0;

    /// <summary>Converts to astronomical units (AU).</summary>
    public static double ToAstronomicalUnits(this Distance d) => d.Meters / 149_597_870_700.0;

    /// <summary>Converts to parsecs.</summary>
    public static double ToParsecs(this Distance d) => d.Meters / 3.085677581e16;

    /// <summary>Converts to kiloparsecs.</summary>
    public static double ToKiloparsecs(this Distance d) => d.Meters / 3.085677581e19;

    /// <summary>Converts to megaparsecs.</summary>
    public static double ToMegaparsecs(this Distance d) => d.Meters / 3.085677581e22;

    /// <summary>Converts to gigaparsecs.</summary>
    public static double ToGigaparsecs(this Distance d) => d.Meters / 3.085677581e25;

    /// <summary>Converts parsecs to time. (Spoiler: it doesn't.)</summary>
    public static TimeSpan ToKesselRun(this Distance d) =>
        throw new InvalidOperationException(
            $"A parsec ({d.ToParsecs():F2} pc) is a unit of distance, not time. " +
            "Han Solo flew close to black holes to shorten the route — " +
            "not because the Millennium Falcon was fast, but because gravity warps spacetime. " +
            "That's general relativity. Try ToLightYears() instead.");
}
