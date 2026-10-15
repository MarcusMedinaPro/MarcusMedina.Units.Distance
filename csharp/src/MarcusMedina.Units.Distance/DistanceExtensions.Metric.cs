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
    extension(int value)
    {
        public Distance Nanometers() => new(value * 1e-9);
        public Distance Micrometers() => new(value * 1e-6);
        public Distance Millimeters() => new(value * 0.001);
        public Distance Centimeters() => new(value * 0.01);
        public Distance Decimeters() => new(value * 0.1);
        public Distance Meters() => new(value);
        public Distance Decameters() => new(value * 10.0);
        public Distance Hectometers() => new(value * 100.0);
        public Distance Kilometers() => new(value * 1000.0);
        public Distance Myriameters() => new(value * 10_000.0);
    }

    extension(double value)
    {
        public Distance Nanometers() => new(value * 1e-9);
        public Distance Micrometers() => new(value * 1e-6);
        public Distance Millimeters() => new(value * 0.001);
        public Distance Centimeters() => new(value * 0.01);
        public Distance Decimeters() => new(value * 0.1);
        public Distance Meters() => new(value);
        public Distance Decameters() => new(value * 10);
        public Distance Hectometers() => new(value * 100);
        public Distance Kilometers() => new(value * 1000);
        public Distance Myriameters() => new(value * 10_000);
    }

    extension(Distance d)
    {
        public double ToNanometers() => d.Meters / 1e-9;
        public double ToMicrometers() => d.Meters / 1e-6;
        public double ToMillimeters() => d.Meters / 0.001;
        public double ToCentimeters() => d.Meters / 0.01;
        public double ToDecimeters() => d.Meters / 0.1;
        public double ToMeters() => d.Meters;
        public double ToDecameters() => d.Meters / 10;
        public double ToHectometers() => d.Meters / 100;
        public double ToKilometers() => d.Meters / 1000;
        public double ToMyriameters() => d.Meters / 10_000;
    }
}
