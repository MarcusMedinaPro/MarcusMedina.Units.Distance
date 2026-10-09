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
    extension(int value)
    {
        /// <summary>1 svensk mil = 10 000 m (modern definition)</summary>
        public Distance Mil() => new(value * 10_000.0);
    }

    extension(double value)
    {
        public Distance Mil() => new(value * 10_000);
    }

    extension(Distance d)
    {
        public double ToMil() => d.Meters / 10_000;
    }
}
