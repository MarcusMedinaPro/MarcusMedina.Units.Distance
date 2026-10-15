namespace MarcusMedina.Units.Distance.Astronomical;

/// <summary>Astronomical distance units.</summary>
public static class AstronomicalDistanceExtensions
{
    extension(int value)
    {
        /// <summary>Creates a Distance from light-seconds.</summary>
        public Distance LightSeconds() => new(value * 299_792_458.0);
        /// <summary>Creates a Distance from light-minutes.</summary>
        public Distance LightMinutes() => new(value * 17_987_547_480.0);
        /// <summary>Creates a Distance from light-hours.</summary>
        public Distance LightHours() => new(value * 1_079_252_848_800.0);
        /// <summary>Creates a Distance from light-days.</summary>
        public Distance LightDays() => new(value * 25_902_068_371_200.0);
        /// <summary>Creates a Distance from light-years.</summary>
        public Distance LightYears() => new(value * 9_460_730_472_580_800.0);
        /// <summary>Creates a Distance from astronomical units (AU).</summary>
        public Distance AstronomicalUnits() => new(value * 149_597_870_700.0);
        /// <summary>Creates a Distance from parsecs.</summary>
        public Distance Parsecs() => new(value * 3.085677581e16);
        /// <summary>Creates a Distance from kiloparsecs.</summary>
        public Distance Kiloparsecs() => new(value * 3.085677581e19);
        /// <summary>Creates a Distance from megaparsecs.</summary>
        public Distance Megaparsecs() => new(value * 3.085677581e22);
        /// <summary>Creates a Distance from gigaparsecs.</summary>
        public Distance Gigaparsecs() => new(value * 3.085677581e25);
    }

    extension(double value)
    {
        /// <summary>Creates a Distance from light-seconds.</summary>
        public Distance LightSeconds() => new(value * 299_792_458.0);
        /// <summary>Creates a Distance from light-minutes.</summary>
        public Distance LightMinutes() => new(value * 17_987_547_480.0);
        /// <summary>Creates a Distance from light-hours.</summary>
        public Distance LightHours() => new(value * 1_079_252_848_800.0);
        /// <summary>Creates a Distance from light-days.</summary>
        public Distance LightDays() => new(value * 25_902_068_371_200.0);
        /// <summary>Creates a Distance from light-years.</summary>
        public Distance LightYears() => new(value * 9_460_730_472_580_800.0);
        /// <summary>Creates a Distance from astronomical units (AU).</summary>
        public Distance AstronomicalUnits() => new(value * 149_597_870_700.0);
        /// <summary>Creates a Distance from parsecs.</summary>
        public Distance Parsecs() => new(value * 3.085677581e16);
        /// <summary>Creates a Distance from kiloparsecs.</summary>
        public Distance Kiloparsecs() => new(value * 3.085677581e19);
        /// <summary>Creates a Distance from megaparsecs.</summary>
        public Distance Megaparsecs() => new(value * 3.085677581e22);
        /// <summary>Creates a Distance from gigaparsecs.</summary>
        public Distance Gigaparsecs() => new(value * 3.085677581e25);
    }

    extension(Distance d)
    {
        /// <summary>Converts to light-seconds.</summary>
        public double ToLightSeconds() => d.Meters / 299_792_458.0;
        /// <summary>Converts to light-minutes.</summary>
        public double ToLightMinutes() => d.Meters / 17_987_547_480.0;
        /// <summary>Converts to light-hours.</summary>
        public double ToLightHours() => d.Meters / 1_079_252_848_800.0;
        /// <summary>Converts to light-days.</summary>
        public double ToLightDays() => d.Meters / 25_902_068_371_200.0;
        /// <summary>Converts to light-years.</summary>
        public double ToLightYears() => d.Meters / 9_460_730_472_580_800.0;
        /// <summary>Converts to astronomical units (AU).</summary>
        public double ToAstronomicalUnits() => d.Meters / 149_597_870_700.0;
        /// <summary>Converts to parsecs.</summary>
        public double ToParsecs() => d.Meters / 3.085677581e16;
        /// <summary>Converts to kiloparsecs.</summary>
        public double ToKiloparsecs() => d.Meters / 3.085677581e19;
        /// <summary>Converts to megaparsecs.</summary>
        public double ToMegaparsecs() => d.Meters / 3.085677581e22;
        /// <summary>Converts to gigaparsecs.</summary>
        public double ToGigaparsecs() => d.Meters / 3.085677581e25;
        /// <summary>Converts parsecs to time. (Spoiler: it doesn't.)</summary>
        public TimeSpan ToKesselRun() =>
            throw new InvalidOperationException(
                $"A parsec ({d.ToParsecs():F2} pc) is a unit of distance, not time. " +
                "Han Solo flew close to black holes to shorten the route — " +
                "not because the Millennium Falcon was fast, but because gravity warps spacetime. " +
                "That's general relativity. Try ToLightYears() instead.");
    }
}
