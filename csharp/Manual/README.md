# Distance Unit Conversions Manual

Complete guide to unit-safe distance conversions.

---

## Quick Start

```csharp
using MarcusMedina.Units.Distance;

var distance = Distance.FromMeters(1000);
var miles = distance.ToMiles();    // ~0.621 miles
var kilometers = distance.ToKilometers();  // 1 km
```

---

## Supported Conversions

- Meters, Kilometers, Miles, Feet, Inches, Centimeters, Yards

---

## Documentation

- [Getting Started](./GettingStarted.md)
- [API Reference](./API.md)
- [Advanced Topics](./Advanced.md)

---

**Version:** 0.2.0
