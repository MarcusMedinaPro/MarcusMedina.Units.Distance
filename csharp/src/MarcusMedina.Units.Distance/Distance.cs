using System.Globalization;

namespace MarcusMedina.Units.Distance;

/// <summary>
/// Representerar ett avstånd med meters som basenhet.
/// Alla konverteringar sker genom att multiplicera/dividera meter-värdet.
/// </summary>
public readonly struct Distance : IComparable<Distance>, IEquatable<Distance>
{
    /// <summary>Värdet i meter (basenhet).</summary>
    public double Meters { get; }

    /// <summary>Skapa ett avstånd med angivet meter-värde.</summary>
    public Distance(double meters)
    {
        Meters = meters;
    }

    public int CompareTo(Distance other) => Meters.CompareTo(other.Meters);

    public bool Equals(Distance other) => Meters.Equals(other.Meters);
    public override bool Equals(object? obj) => obj is Distance d && Equals(d);
    public override int GetHashCode() => HashCode.Combine(Meters);
    public override string ToString() => $"{Meters.ToString("G", CultureInfo.InvariantCulture)} m";

    // Comparison operators
    public static bool operator ==(Distance a, Distance b) => a.Equals(b);
    public static bool operator !=(Distance a, Distance b) => !(a == b);
    public static bool operator <(Distance a, Distance b) => a.Meters < b.Meters;
    public static bool operator >(Distance a, Distance b) => a.Meters > b.Meters;
    public static bool operator <=(Distance a, Distance b) => a.Meters <= b.Meters;
    public static bool operator >=(Distance a, Distance b) => a.Meters >= b.Meters;

    // Arithmetic operators
    public static Distance operator +(Distance a, Distance b) => new(a.Meters + b.Meters);
    public static Distance operator -(Distance a, Distance b) => new(a.Meters - b.Meters);
    public static Distance operator *(Distance d, double factor) => new(d.Meters * factor);
    public static Distance operator /(Distance d, double divisor) => new(d.Meters / divisor);
    public static double operator /(Distance a, Distance b) => a.Meters / b.Meters;
}
