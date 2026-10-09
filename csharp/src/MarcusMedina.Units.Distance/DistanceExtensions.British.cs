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
    extension(int value)
    {
        /// <summary>1 inch (tum) = 0.0254 m</summary>
        public Distance Inches() => new(value * 0.0254);
        /// <summary>1 foot = 0.3048 m</summary>
        public Distance Feet() => new(value * 0.3048);
        /// <summary>1 yard = 0.9144 m</summary>
        public Distance Yards() => new(value * 0.9144);
        /// <summary>1 mile = 1609.344 m</summary>
        public Distance Miles() => new(value * 1609.344);
        /// <summary>1 nautisk mil = 1852 m</summary>
        public Distance NauticalMiles() => new(value * 1852.0);
    }

    extension(double value)
    {
        public Distance Inches() => new(value * 0.0254);
        public Distance Feet() => new(value * 0.3048);
        public Distance Yards() => new(value * 0.9144);
        public Distance Miles() => new(value * 1609.344);
        public Distance NauticalMiles() => new(value * 1852);
    }

    extension(Distance d)
    {
        public double ToInches() => d.Meters / 0.0254;
        public double ToFeet() => d.Meters / 0.3048;
        public double ToYards() => d.Meters / 0.9144;
        public double ToMiles() => d.Meters / 1609.344;
        public double ToNauticalMiles() => d.Meters / 1852;
    }
}
