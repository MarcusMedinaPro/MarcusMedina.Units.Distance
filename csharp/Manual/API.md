# API Reference

## Distance Class

```csharp
public class Distance
{
    // Factory methods
    public static Distance FromMeters(double value);
    public static Distance FromKilometers(double value);
    public static Distance FromMiles(double value);
    public static Distance FromFeet(double value);
    public static Distance FromInches(double value);
    public static Distance FromCentimeters(double value);
    public static Distance FromYards(double value);

    // Conversions
    public double ToMeters();
    public double ToKilometers();
    public double ToMiles();
    public double ToFeet();
    public double ToInches();
    public double ToCentimeters();
    public double ToYards();

    // Operations
    public Distance Multiply(double scalar);
    public Distance Divide(double scalar);
    public Distance Add(Distance other);
    public Distance Subtract(Distance other);
}
```

## Conversion Table

| From | To | Factor |
|------|-----|--------|
| 1 m | km | 0.001 |
| 1 m | miles | 0.000621371 |
| 1 m | feet | 3.28084 |
| 1 m | inches | 39.3701 |
| 1 m | cm | 100 |
| 1 m | yards | 1.09361 |

---

**Last Updated:** 2025-03-16
