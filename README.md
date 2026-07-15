# MarcusMedina.Units.Distance

[![NuGet](https://img.shields.io/nuget/v/MarcusMedina.Units.Distance.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Units.Distance/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/MarcusMedina.Units.Distance.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Units.Distance/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=csharp&logoColor=white)](#)
[![.NET](https://img.shields.io/badge/.NET-10.0+-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)
[![Open Source](https://raw.githubusercontent.com/MarcusMedinaPro/MarcusMedina.Units.Distance/main/assets/open-source.svg)](https://opensource.org)
[![Build](https://img.shields.io/github/actions/workflow/status/MarcusMedinaPro/MarcusMedina.Units.Distance/release.yml?branch=main&label=Build&style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Distance/actions)
[![Signed](https://img.shields.io/badge/Signed-Sigstore-green?style=for-the-badge&logo=linux)](https://docs.sigstore.dev)
[![Wiki](https://img.shields.io/badge/docs-wiki-blue?style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Distance/wiki)

**Fluent distance unit conversion for .NET 10+** — metric, US customary, British imperial (current and historical), historical Swedish, astronomical, and microscopic units, all in one strongly-typed `Distance` struct.

From Ångström to gigaparsec, and kvart to survey mile — convert without ever guessing which raw `double` means what.

> This one actually wasn't born from teaching — it genuinely fascinated me on its own. It started with something mundane: working out how far you'd driven, and realising the answer depends on which country you're reporting the distance to, since they don't all agree on units or rounding. That rabbit hole is what got the whole thing started. Then I went a bit overboard and threw in astronomical and microscopic units too — parsecs and Bohr radii have nothing to do with mileage reports, but once I was building unit families I couldn't stop at just the practical ones.
>
> In this case, I wanted each unit conversion to be broken into the same small, obvious steps, whether you're measuring a commute or the distance to a star.

---

## Features

- ✅ **Metric** — nm, µm, mm, cm, dm, m, dam, hm, km, myriameter
- ✅ **US customary** — survey foot, survey mile, US rod, US chain
- ✅ **British imperial** — inch, foot, yard, mile, nautical mile
- ✅ **British historical** — link, rod, chain, furlong, league, fathom, cable
- ✅ **Swedish (modern)** — mil
- ✅ **Historical Swedish** — tum, fot, kvart, aln, famn, ref, Swedish mile
- ✅ **Astronomical** — light-second/minute/hour/day/year, astronomical unit, parsec, kiloparsec, megaparsec, gigaparsec
- ✅ **Microscopic** — Ångström, picometer, femtometer, attometer, Bohr radius, Planck length
- ✅ **Strongly typed** — `Distance` struct instead of a raw `double`, so units can't be mixed up by accident
- ✅ **Fluent API** — `1.Parsecs().ToLightYears()`
- ✅ **Comparable & arithmetic** — `+`, `-`, `*`, `/`, and full comparison operators
- ✅ **Zero dependencies** — pure .NET, no external packages

---

## Installation

```bash
dotnet add package MarcusMedina.Units.Distance
```

**Requirements:** .NET 10.0+, C# 14.0+

---

## Quick Start

```csharp
using MarcusMedina.Units.Distance.Metric;
using MarcusMedina.Units.Distance.Astronomical;
using MarcusMedina.Units.Distance.SwedishOld;

// Create a Distance from any supported unit
Distance trip = 42.Kilometers();
Distance star = 4.24.LightYears();

// Convert to whatever unit you need
double miles     = trip.ToMiles();          // ≈ 26.1
double parsecs   = star.ToParsecs();        // ≈ 1.3

// Historical Swedish units work the same way
Distance oldMap = 10.Alnar();

// Arithmetic works directly on Distance values
Distance total = trip + 1.SwedishMiles();

// Comparisons
bool farther = star > trip;
```

---

## API Overview

| Namespace | Unit family |
|-----------|-------------|
| `MarcusMedina.Units.Distance.Metric` | nm, µm, mm, cm, dm, m, dam, hm, km, myriameter |
| `MarcusMedina.Units.Distance.US` | survey foot, survey mile, US rod, US chain |
| `MarcusMedina.Units.Distance.British` | inch, foot, yard, mile, nautical mile |
| `MarcusMedina.Units.Distance.BritishOld` | link, rod, chain, furlong, league, fathom, cable |
| `MarcusMedina.Units.Distance.Swedish` | mil |
| `MarcusMedina.Units.Distance.SwedishOld` | tum, fot, kvart, aln, famn, ref, Swedish mile |
| `MarcusMedina.Units.Distance.Astronomical` | light-second/minute/hour/day/year, AU, parsec, kiloparsec, megaparsec, gigaparsec |
| `MarcusMedina.Units.Distance.Microscopic` | Ångström, picometer, femtometer, attometer, Bohr radius, Planck length |

Every unit exposes a creation extension (`1.Parsecs()`) and a conversion extension
(`distance.ToParsecs()`). The `Distance` struct itself always stores the value in meters,
so mixing units in the same expression is always safe — whether you're measuring a
construction site or the distance to a star.

---

## Sample Projects

The repository includes a demo console app and three worked use cases:

- **Demo** (`samples/MarcusMedina.Units.Distance.Demo`) — quick tour of the API
- **UseCase1.GPSCalculations** — distance calculations for GPS coordinates
- **UseCase2.TravelDistance** — everyday travel distance conversions
- **UseCase3.ConstructionMeasurements** — construction-site measurements with imperial/metric mixing

---

## Testing

```bash
cd csharp
dotnet test --configuration Release
```

Tests: **73 passed** — covering all unit families, arithmetic operators, and edge cases.

---

## License

MIT — see [LICENSE](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Distance/blob/main/LICENSE) for details.

---

## Built with Human + AI Collaboration

This library was written by **Marcus Medina** together with **Claude Code** (Anthropic) — not through "vibe coding" where you just describe and accept, but through genuine collaboration: planning together, reviewing each other's decisions, pushing back when something felt wrong, and iterating until the result felt right.

The goal was always to write code worth reading and code worth using — the kind a student can open, understand, and learn from, and the kind any programmer can drop into real, professional work without wanting to rewrite it from scratch. AI was a partner in that process, not a shortcut around it.

If you're curious about this way of working, the source code and git history are open. Every decision has a reason behind it.

## Made for Curious Minds

This library was built with students in mind — not as a black box to copy and paste, but as a real-world example of how clean, purposeful code is written and shared.

Whether you're discovering C# for the first time, need a reliable helper for your school project, or are simply trying to fall in love with writing code — you're exactly who this was made for.

The source is open. Read it, fork it, break it, improve it. That's the whole point.

And if this library saved you an afternoon, or made something click that didn't before — that's everything.

*Non-students are equally welcome. Good code doesn't care about your diploma.*

⭐ If this helped you, consider starring the project on GitHub — it helps other students find it too.

💬 Have an idea, a feature request, or just want to say hi? Open an issue on GitHub — I'd love to hear from you.

## Package Integrity

All releases are signed with [cosign](https://docs.sigstore.dev) (Sigstore keyless signing).

To verify a downloaded package, download both the `.nupkg` and its `.sigstore.json` bundle from the [GitHub Release](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Distance/releases), then run:

```bash
cosign verify-blob <package.nupkg> \
  --bundle <package.nupkg.sigstore.json> \
  --certificate-identity-regexp "https://github.com/MarcusMedinaPro/.*/release.yml" \
  --certificate-oidc-issuer https://token.actions.githubusercontent.com
```

Expected output: `Verified OK`

## Related Projects

- [MarcusMedina.Units.Area](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Area) — Fluent area unit conversion
- [MarcusMedina.Units.Volume](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Volume) — Fluent volume unit conversion
- [MarcusMedina.Units.Weight](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Weight) — Fluent weight unit conversion
- [MarcusMedina.Units.Math](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Math) — Unit-aware mathematical operations
- [MarcusMedina.Maths.Algebra](https://github.com/MarcusMedinaPro/MarcusMedina.Maths.Algebra) — Algebraic expressions and symbolic math
