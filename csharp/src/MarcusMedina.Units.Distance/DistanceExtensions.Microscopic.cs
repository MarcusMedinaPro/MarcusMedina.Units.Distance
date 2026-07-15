namespace MarcusMedina.Units.Distance.Microscopic;

/// <summary>Microscopic and subatomic distance units.</summary>
public static class MicroscopicDistanceExtensions
{
    /// <summary>Creates a Distance from angstroms (Å).</summary>
    public static Distance Angstroms(this int value) => new(value * 1e-10);
    /// <summary>Creates a Distance from angstroms (Å).</summary>
    public static Distance Angstroms(this double value) => new(value * 1e-10);

    /// <summary>Creates a Distance from picometers.</summary>
    public static Distance Picometers(this int value) => new(value * 1e-12);
    /// <summary>Creates a Distance from picometers.</summary>
    public static Distance Picometers(this double value) => new(value * 1e-12);

    /// <summary>Creates a Distance from femtometers.</summary>
    public static Distance Femtometers(this int value) => new(value * 1e-15);
    /// <summary>Creates a Distance from femtometers.</summary>
    public static Distance Femtometers(this double value) => new(value * 1e-15);

    /// <summary>Creates a Distance from attometers.</summary>
    public static Distance Attometers(this int value) => new(value * 1e-18);
    /// <summary>Creates a Distance from attometers.</summary>
    public static Distance Attometers(this double value) => new(value * 1e-18);

    /// <summary>Creates a Distance from Bohr radii (a₀).</summary>
    public static Distance BohrRadii(this int value) => new(value * 5.29177210903e-11);
    /// <summary>Creates a Distance from Bohr radii (a₀).</summary>
    public static Distance BohrRadii(this double value) => new(value * 5.29177210903e-11);

    /// <summary>Creates a Distance from Planck lengths.</summary>
    public static Distance PlanckLengths(this int value) => new(value * 1.616255e-35);
    /// <summary>Creates a Distance from Planck lengths.</summary>
    public static Distance PlanckLengths(this double value) => new(value * 1.616255e-35);

    /// <summary>Converts to angstroms (Å).</summary>
    public static double ToAngstroms(this Distance d) => d.Meters / 1e-10;

    /// <summary>Converts to picometers.</summary>
    public static double ToPicometers(this Distance d) => d.Meters / 1e-12;

    /// <summary>Converts to femtometers.</summary>
    public static double ToFemtometers(this Distance d) => d.Meters / 1e-15;

    /// <summary>Converts to attometers.</summary>
    public static double ToAttometers(this Distance d) => d.Meters / 1e-18;

    /// <summary>Converts to Bohr radii.</summary>
    public static double ToBohrRadii(this Distance d) => d.Meters / 5.29177210903e-11;

    /// <summary>Converts to Planck lengths.</summary>
    public static double ToPlanckLengths(this Distance d) => d.Meters / 1.616255e-35;
}
