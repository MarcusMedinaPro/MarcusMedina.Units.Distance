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
    extension(int value)
    {
        /// <summary>1 US survey foot = 1200/3937 m ≈ 0.3048006 m</summary>
        public Distance SurveyFeet() => new(value * 1200.0 / 3937.0);
        /// <summary>1 US survey mile = 5280 survey feet ≈ 1609.347 m</summary>
        public Distance SurveyMiles() => new(value * 5280.0 * 1200.0 / 3937.0);
        /// <summary>1 US rod = 16.5 survey feet ≈ 5.02921 m</summary>
        public Distance UsRods() => new(value * 16.5 * 1200.0 / 3937.0);
        /// <summary>1 US chain = 66 survey feet ≈ 20.11684 m</summary>
        public Distance UsChains() => new(value * 66.0 * 1200.0 / 3937.0);
    }

    extension(double value)
    {
        public Distance SurveyFeet() => new(value * 1200.0 / 3937.0);
        public Distance SurveyMiles() => new(value * 5280.0 * 1200.0 / 3937.0);
        public Distance UsRods() => new(value * 16.5 * 1200.0 / 3937.0);
        public Distance UsChains() => new(value * 66.0 * 1200.0 / 3937.0);
    }

    extension(Distance d)
    {
        public double ToSurveyFeet() => d.Meters / (1200.0 / 3937.0);
        public double ToSurveyMiles() => d.Meters / (5280.0 * 1200.0 / 3937.0);
        public double ToUsRods() => d.Meters / (16.5 * 1200.0 / 3937.0);
        public double ToUsChains() => d.Meters / (66.0 * 1200.0 / 3937.0);
    }
}
