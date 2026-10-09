namespace MarcusMedina.Units.Distance.Microscopic;

/// <summary>Microscopic and subatomic distance units.</summary>
public static class MicroscopicDistanceExtensions
{
    extension(int value)
    {
        /// <summary>Creates a Distance from angstroms (Å).</summary>
        public Distance Angstroms() => new(value * 1e-10);
        /// <summary>Creates a Distance from picometers.</summary>
        public Distance Picometers() => new(value * 1e-12);
        /// <summary>Creates a Distance from femtometers.</summary>
        public Distance Femtometers() => new(value * 1e-15);
        /// <summary>Creates a Distance from attometers.</summary>
        public Distance Attometers() => new(value * 1e-18);
        /// <summary>Creates a Distance from Bohr radii (a₀).</summary>
        public Distance BohrRadii() => new(value * 5.29177210903e-11);
        /// <summary>Creates a Distance from Planck lengths.</summary>
        public Distance PlanckLengths() => new(value * 1.616255e-35);
    }

    extension(double value)
    {
        /// <summary>Creates a Distance from angstroms (Å).</summary>
        public Distance Angstroms() => new(value * 1e-10);
        /// <summary>Creates a Distance from picometers.</summary>
        public Distance Picometers() => new(value * 1e-12);
        /// <summary>Creates a Distance from femtometers.</summary>
        public Distance Femtometers() => new(value * 1e-15);
        /// <summary>Creates a Distance from attometers.</summary>
        public Distance Attometers() => new(value * 1e-18);
        /// <summary>Creates a Distance from Bohr radii (a₀).</summary>
        public Distance BohrRadii() => new(value * 5.29177210903e-11);
        /// <summary>Creates a Distance from Planck lengths.</summary>
        public Distance PlanckLengths() => new(value * 1.616255e-35);
    }

    extension(Distance d)
    {
        /// <summary>Converts to angstroms (Å).</summary>
        public double ToAngstroms() => d.Meters / 1e-10;
        /// <summary>Converts to picometers.</summary>
        public double ToPicometers() => d.Meters / 1e-12;
        /// <summary>Converts to femtometers.</summary>
        public double ToFemtometers() => d.Meters / 1e-15;
        /// <summary>Converts to attometers.</summary>
        public double ToAttometers() => d.Meters / 1e-18;
        /// <summary>Converts to Bohr radii.</summary>
        public double ToBohrRadii() => d.Meters / 5.29177210903e-11;
        /// <summary>Converts to Planck lengths.</summary>
        public double ToPlanckLengths() => d.Meters / 1.616255e-35;
    }
}
