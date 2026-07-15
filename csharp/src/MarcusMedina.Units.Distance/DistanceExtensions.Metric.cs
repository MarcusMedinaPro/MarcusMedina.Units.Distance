namespace MarcusMedina.Units.Distance.Metric;

/// <summary>
/// Metriska längdenheter — SI-standard med meter som basenhet.
/// <code>
/// 5.Kilometers().ToMeters()      // 5000
/// 100.Centimeters().ToMeters()   // 1.0
/// </code>
/// </summary>
public static class MetricDistanceExtensions
{
    public static Distance Nanometers(this int value) => new(value * 1e-9);
    public static Distance Nanometers(this double value) => new(value * 1e-9);
    public static Distance Micrometers(this int value) => new(value * 1e-6);
    public static Distance Micrometers(this double value) => new(value * 1e-6);
    public static Distance Millimeters(this int value) => new(value * 0.001);
    public static Distance Millimeters(this double value) => new(value * 0.001);
    public static Distance Centimeters(this int value) => new(value * 0.01);
    public static Distance Centimeters(this double value) => new(value * 0.01);
    public static Distance Decimeters(this int value) => new(value * 0.1);
    public static Distance Decimeters(this double value) => new(value * 0.1);
    public static Distance Meters(this int value) => new(value);
    public static Distance Meters(this double value) => new(value);
    public static Distance Decameters(this int value) => new(value * 10);
    public static Distance Decameters(this double value) => new(value * 10);
    public static Distance Hectometers(this int value) => new(value * 100);
    public static Distance Hectometers(this double value) => new(value * 100);
    public static Distance Kilometers(this int value) => new(value * 1000);
    public static Distance Kilometers(this double value) => new(value * 1000);
    public static Distance Myriameters(this int value) => new(value * 10_000);
    public static Distance Myriameters(this double value) => new(value * 10_000);

    public static double ToNanometers(this Distance d) => d.Meters / 1e-9;
    public static double ToMicrometers(this Distance d) => d.Meters / 1e-6;
    public static double ToMillimeters(this Distance d) => d.Meters / 0.001;
    public static double ToCentimeters(this Distance d) => d.Meters / 0.01;
    public static double ToDecimeters(this Distance d) => d.Meters / 0.1;
    public static double ToMeters(this Distance d) => d.Meters;
    public static double ToDecameters(this Distance d) => d.Meters / 10;
    public static double ToHectometers(this Distance d) => d.Meters / 100;
    public static double ToKilometers(this Distance d) => d.Meters / 1000;
    public static double ToMyriameters(this Distance d) => d.Meters / 10_000;
}
