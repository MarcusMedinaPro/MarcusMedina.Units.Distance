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
    extension(int value)
    {
        /// <summary>1 tum = 1/12 fot ≈ 0.02615 m</summary>
        public Distance Tum() => new(value * 0.026154);
        /// <summary>1 fot (Rhenländsk) ≈ 0.31385 m</summary>
        public Distance Fot() => new(value * 0.31385);
        /// <summary>1 kvart = 6 tum = 1/2 fot ≈ 0.1569 m</summary>
        public Distance Kvart() => new(value * 0.1569);
        /// <summary>1 aln = 2 fot ≈ 0.6277 m</summary>
        public Distance Alnar() => new(value * 0.6277);
        /// <summary>1 famn = 3 alnar ≈ 1.8831 m</summary>
        public Distance Famnar() => new(value * 1.8831);
        /// <summary>1 ref = 1/4 gammal mil = 2672 m</summary>
        public Distance Ref() => new(value * 2672.0);
        /// <summary>1 gammal svensk landmil = 10 688 m (före 1889)</summary>
        public Distance SwedishMiles() => new(value * 10_688.0);
    }

    extension(double value)
    {
        public Distance Tum() => new(value * 0.026154);
        public Distance Fot() => new(value * 0.31385);
        public Distance Kvart() => new(value * 0.1569);
        public Distance Alnar() => new(value * 0.6277);
        public Distance Famnar() => new(value * 1.8831);
        public Distance Ref() => new(value * 2672);
        public Distance SwedishMiles() => new(value * 10_688);
    }

    extension(Distance d)
    {
        public double ToTum() => d.Meters / 0.026154;
        public double ToFot() => d.Meters / 0.31385;
        public double ToKvart() => d.Meters / 0.1569;
        public double ToAlnar() => d.Meters / 0.6277;
        public double ToFamnar() => d.Meters / 1.8831;
        public double ToRef() => d.Meters / 2672;
        public double ToSwedishMiles() => d.Meters / 10_688;
    }
}
