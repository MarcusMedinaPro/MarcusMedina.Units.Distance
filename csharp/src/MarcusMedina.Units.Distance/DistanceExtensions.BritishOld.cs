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
    extension(int value)
    {
        /// <summary>1 link = 0.201168 m</summary>
        public Distance Links() => new(value * 0.201168);
        /// <summary>1 rod = 25 links = 5.0292 m</summary>
        public Distance Rods() => new(value * 5.0292);
        /// <summary>1 chain = 4 rods = 100 links = 20.1168 m</summary>
        public Distance Chains() => new(value * 20.1168);
        /// <summary>1 furlong = 10 chains = 201.168 m</summary>
        public Distance Furlongs() => new(value * 201.168);
        /// <summary>1 league = 3 miles = 4828.032 m</summary>
        public Distance Leagues() => new(value * 4828.032);
        /// <summary>1 fathom = 6 feet = 1.8288 m</summary>
        public Distance Fathoms() => new(value * 1.8288);
        /// <summary>1 cable = 1/10 nautisk mil = 185.2 m</summary>
        public Distance Cables() => new(value * 185.2);
    }

    extension(double value)
    {
        public Distance Links() => new(value * 0.201168);
        public Distance Rods() => new(value * 5.0292);
        public Distance Chains() => new(value * 20.1168);
        public Distance Furlongs() => new(value * 201.168);
        public Distance Leagues() => new(value * 4828.032);
        public Distance Fathoms() => new(value * 1.8288);
        public Distance Cables() => new(value * 185.2);
    }

    extension(Distance d)
    {
        public double ToLinks() => d.Meters / 0.201168;
        public double ToRods() => d.Meters / 5.0292;
        public double ToChains() => d.Meters / 20.1168;
        public double ToFurlongs() => d.Meters / 201.168;
        public double ToLeagues() => d.Meters / 4828.032;
        public double ToFathoms() => d.Meters / 1.8288;
        public double ToCables() => d.Meters / 185.2;
    }
}
