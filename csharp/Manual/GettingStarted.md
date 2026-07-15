# Getting Started

## Installation

```bash
dotnet add package MarcusMedina.Units.Distance
```

## Basic Usage

```csharp
using MarcusMedina.Units.Distance;

// Create a distance
var distance = Distance.FromKilometers(10);

// Convert to different units
var miles = distance.ToMiles();
var meters = distance.ToMeters();
var feet = distance.ToFeet();

// Arithmetic
var doubled = distance.Multiply(2);
var half = distance.Divide(2);
```

## Supported Units

- Kilometers (km)
- Meters (m)
- Miles (mi)
- Feet (ft)
- Inches (in)
- Centimeters (cm)
- Yards (yd)

---

**Next:** See [Examples](./Examples/) or [API Reference](./API.md)
