# Advanced Topics

## Custom Conversions

```csharp
var distance = Distance.FromMiles(5);
var customUnit = distance.ToMeters() / 1000;  // Convert to custom unit
```

## Chaining Operations

```csharp
var distance = Distance.FromMeters(1000)
    .Multiply(2)
    .Add(Distance.FromMeters(500));
```

## Performance Tips

- Cache frequently converted values
- Use batch operations for multiple conversions
- Prefer ToMeters() as intermediate step

---

**Version:** 0.2.0
