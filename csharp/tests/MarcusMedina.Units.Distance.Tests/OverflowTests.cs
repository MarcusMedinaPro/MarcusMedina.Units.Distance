using MarcusMedina.Units.Distance;
using MarcusMedina.Units.Distance.Metric;
using MarcusMedina.Units.Distance.British;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Distance.Tests;

public class OverflowTests
{
    [Fact]
    public void Kilometers_LargeInt_DoesNotOverflow()
    {
        3_000_000.Kilometers().Meters.Should().Be(3_000_000_000d);
    }

    [Fact]
    public void NauticalMiles_LargeInt_DoesNotOverflow()
    {
        2_000_000.NauticalMiles().Meters.Should().Be(3_704_000_000d);
    }
}
