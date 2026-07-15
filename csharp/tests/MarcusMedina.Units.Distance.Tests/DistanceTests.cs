using MarcusMedina.Units.Distance;
using MarcusMedina.Units.Distance.Metric;
using Xunit;
using FluentAssertions;
using MarcusMedina.Units.Distance.British;
using MarcusMedina.Units.Distance.BritishOld;
using MarcusMedina.Units.Distance.US;
using MarcusMedina.Units.Distance.Swedish;
using MarcusMedina.Units.Distance.SwedishOld;
using MarcusMedina.Units.Distance.Astronomical;
using MarcusMedina.Units.Distance.Microscopic;

namespace MarcusMedina.Units.Distance.Tests;

public class DistanceStructTests
{
    [Fact]
    public void Distance_StoresMeters()
    {
        var d = new Distance(100);
        d.Meters.Should().Be(100);
    }

    [Fact]
    public void Distance_Addition()
    {
        (new Distance(100) + new Distance(50)).Meters.Should().Be(150);
    }

    [Fact]
    public void Distance_Subtraction()
    {
        (new Distance(100) - new Distance(30)).Meters.Should().Be(70);
    }

    [Fact]
    public void Distance_Multiplication()
    {
        (new Distance(100) * 3).Meters.Should().Be(300);
    }

    [Fact]
    public void Distance_DivisionByFactor()
    {
        (new Distance(100) / 4).Meters.Should().Be(25);
    }

    [Fact]
    public void Distance_DivisionByDistance()
    {
        (new Distance(100) / new Distance(25)).Should().Be(4.0);
    }

    [Fact]
    public void Distance_Equality()
    {
        (new Distance(100) == new Distance(100)).Should().BeTrue();
        (new Distance(100) != new Distance(101)).Should().BeTrue();
    }

    [Fact]
    public void Distance_Comparison()
    {
        (new Distance(100) < new Distance(200)).Should().BeTrue();
        (new Distance(200) > new Distance(100)).Should().BeTrue();
    }

    [Fact]
    public void Distance_ToString()
    {
        new Distance(42.5).ToString().Should().Be("42.5 m");
    }
}

public class MetricDistanceTests
{
    [Fact]
    public void Meters_ToKilometers()
    {
        1000.Meters().ToKilometers().Should().BeApproximately(1.0, 1e-9);
    }

    [Fact]
    public void Millimeters_ToCentimeters()
    {
        25.Millimeters().ToCentimeters().Should().BeApproximately(2.5, 1e-9);
    }

    [Fact]
    public void Centimeters_ToMeters()
    {
        250.Centimeters().ToMeters().Should().BeApproximately(2.5, 1e-9);
    }

    [Fact]
    public void Decimeters_ToMeters()
    {
        10.Decimeters().ToMeters().Should().BeApproximately(1.0, 1e-9);
    }

    [Fact]
    public void Decameters_ToMeters()
    {
        3.Decameters().ToMeters().Should().Be(30);
    }

    [Fact]
    public void Hectometers_ToKilometers()
    {
        2.Hectometers().ToKilometers().Should().BeApproximately(0.2, 1e-9);
    }

    [Fact]
    public void Myriameters_ToKilometers()
    {
        1.Myriameters().ToKilometers().Should().Be(10);
    }

    [Fact]
    public void Micrometers_ToMeters()
    {
        1_000_000.0.Micrometers().ToMeters().Should().BeApproximately(1.0, 1e-6);
    }

    [Fact]
    public void Nanometers_ToMeters()
    {
        1_000_000_000.0.Nanometers().ToMeters().Should().BeApproximately(1.0, 1e-3);
    }

    [Fact]
    public void DoubleOverload_Works()
    {
        2.5.Kilometers().ToMeters().Should().Be(2500);
    }

    [Fact]
    public void FromMeters_ToMyriameters()
    {
        20000.Meters().ToMyriameters().Should().Be(2);
    }

    [Fact]
    public void FromMeters_ToDecameters()
    {
        50.Meters().ToDecameters().Should().Be(5);
    }

    [Fact]
    public void FromMeters_ToHectometers()
    {
        300.Meters().ToHectometers().Should().Be(3);
    }
}

public class BritishDistanceTests
{
    [Fact]
    public void Kilometers_ToMiles()
    {
        5.Kilometers().ToMiles().Should().BeApproximately(3.10686, 1e-4);
    }

    [Fact]
    public void Miles_ToKilometers()
    {
        3.Miles().ToKilometers().Should().BeApproximately(4.82803, 1e-4);
    }

    [Fact]
    public void Inches_ToCentimeters()
    {
        12.Inches().ToCentimeters().Should().BeApproximately(30.48, 1e-9);
    }

    [Fact]
    public void Feet_ToMeters()
    {
        10.Feet().ToMeters().Should().BeApproximately(3.048, 1e-9);
    }

    [Fact]
    public void Yards_ToMeters()
    {
        5.Yards().ToMeters().Should().BeApproximately(4.572, 1e-9);
    }

    [Fact]
    public void NauticalMiles_ToKilometers()
    {
        1.NauticalMiles().ToKilometers().Should().BeApproximately(1.852, 1e-9);
    }

    [Fact]
    public void FromMeters_ToInches()
    {
        1.Meters().ToInches().Should().BeApproximately(39.3701, 1e-3);
    }

    [Fact]
    public void FromMeters_ToFeet()
    {
        1.Meters().ToFeet().Should().BeApproximately(3.28084, 1e-4);
    }

    [Fact]
    public void FromMeters_ToYards()
    {
        1.Meters().ToYards().Should().BeApproximately(1.09361, 1e-4);
    }

    [Fact]
    public void FromMeters_ToMiles()
    {
        1609.344.Meters().ToMiles().Should().BeApproximately(1.0, 1e-9);
    }

    [Fact]
    public void Kilometers_ToNauticalMiles()
    {
        1852.Kilometers().ToNauticalMiles().Should().BeApproximately(1000.0, 1e-3);
    }
}

public class BritishOldDistanceTests
{
    [Fact]
    public void Furlongs_ToMeters()
    {
        1.Furlongs().ToMeters().Should().BeApproximately(201.168, 1e-3);
    }

    [Fact]
    public void Meters_ToFurlongs()
    {
        201.168.Meters().ToFurlongs().Should().BeApproximately(1.0, 1e-4);
    }

    [Fact]
    public void Leagues_ToKilometers()
    {
        1.Leagues().ToKilometers().Should().BeApproximately(4.82803, 1e-4);
    }

    [Fact]
    public void Rods_ToMeters()
    {
        1.Rods().ToMeters().Should().BeApproximately(5.0292, 1e-4);
    }

    [Fact]
    public void Chains_ToMeters()
    {
        1.Chains().ToMeters().Should().BeApproximately(20.1168, 1e-4);
    }

    [Fact]
    public void Links_ToMeters()
    {
        100.Links().ToMeters().Should().BeApproximately(20.1168, 1e-4);
    }

    [Fact]
    public void Fathoms_ToMeters()
    {
        1.Fathoms().ToMeters().Should().BeApproximately(1.8288, 1e-4);
    }

    [Fact]
    public void Meters_ToFathoms()
    {
        1.8288.Meters().ToFathoms().Should().BeApproximately(1.0, 1e-4);
    }

    [Fact]
    public void Cables_ToMeters()
    {
        1.Cables().ToMeters().Should().Be(185.2);
    }

    [Fact]
    public void Leagues_ToMiles()
    {
        1.Leagues().ToMiles().Should().BeApproximately(3.0, 1e-9);
    }
}

public class USDistanceTests
{
    [Fact]
    public void SurveyFeet_ToMeters()
    {
        1.SurveyFeet().ToMeters().Should().BeApproximately(0.3048006, 1e-6);
    }

    [Fact]
    public void SurveyMiles_ToMeters()
    {
        1.SurveyMiles().ToMeters().Should().BeApproximately(1609.347, 1e-2);
    }

    [Fact]
    public void InternationalMile_IsSlightlyDifferentFromSurveyMile()
    {
        var survey = 1.SurveyMiles().ToMeters();
        var inter = 1.Miles().ToMeters();
        survey.Should().BeGreaterThan(inter);
    }

    [Fact]
    public void UsRods_ToMeters()
    {
        1.UsRods().ToMeters().Should().BeApproximately(5.02921, 1e-4);
    }

    [Fact]
    public void UsChains_ToMeters()
    {
        1.UsChains().ToMeters().Should().BeApproximately(20.11684, 1e-4);
    }

    [Fact]
    public void Meters_ToSurveyFeet()
    {
        0.3048006.Meters().ToSurveyFeet().Should().BeApproximately(1.0, 1e-4);
    }
}

public class SwedishDistanceTests
{
    [Fact]
    public void Mil_ToKilometers()
    {
        5.Mil().ToKilometers().Should().BeApproximately(50.0, 1e-9);
    }

    [Fact]
    public void Kilometers_ToMil()
    {
        50.0.Kilometers().ToMil().Should().BeApproximately(5.0, 1e-9);
    }

    [Fact]
    public void DoubleOverload_Works()
    {
        2.5.Mil().ToKilometers().Should().Be(25.0);
    }
}

public class SwedishOldDistanceTests
{
    [Fact]
    public void SwedishMiles_ToKilometers()
    {
        1.SwedishMiles().ToKilometers().Should().BeApproximately(10.688, 1e-9);
    }

    [Fact]
    public void Kilometers_ToSwedishMiles()
    {
        53.44.Kilometers().ToSwedishMiles().Should().BeApproximately(5.0, 1e-2);
    }

    [Fact]
    public void Alnar_ToMeters()
    {
        3.Alnar().ToMeters().Should().BeApproximately(1.8831, 1e-4);
    }

    [Fact]
    public void Meters_ToAlnar()
    {
        1.8831.Meters().ToAlnar().Should().BeApproximately(3.0, 1e-4);
    }

    [Fact]
    public void Famnar_ToMeters()
    {
        2.Famnar().ToMeters().Should().BeApproximately(3.7662, 1e-4);
    }

    [Fact]
    public void Fot_ToMeters()
    {
        10.Fot().ToMeters().Should().BeApproximately(3.1385, 1e-4);
    }

    [Fact]
    public void Meters_ToFot()
    {
        3.1385.Meters().ToFot().Should().BeApproximately(10.0, 1e-3);
    }

    [Fact]
    public void Tum_ToMeters()
    {
        12.Tum().ToMeters().Should().BeApproximately(0.31385, 1e-4);
    }

    [Fact]
    public void Kvart_ToMeters()
    {
        4.Kvart().ToMeters().Should().BeApproximately(0.6276, 1e-3);
    }

    [Fact]
    public void Ref_ToKilometers()
    {
        1.Ref().ToKilometers().Should().BeApproximately(2.672, 1e-9);
    }

    [Fact]
    public void Kilometers_ToRef()
    {
        26.72.Kilometers().ToRef().Should().BeApproximately(10.0, 1e-2);
    }

    [Fact]
    public void DoubleOverload_Works()
    {
        1.5.SwedishMiles().ToKilometers().Should().BeApproximately(16.032, 1e-2);
    }
}

public class AstronomicalDistanceTests
{
    [Fact]
    public void LightYear_ToMeters()
    {
        1.LightYears().Meters.Should().BeApproximately(9_460_730_472_580_800.0, 1e6);
    }

    [Fact]
    public void Parsec_ToLightYears()
    {
        1.Parsecs().ToLightYears().Should().BeApproximately(3.2616, 1e-3);
    }

    [Fact]
    public void AU_ToMeters()
    {
        1.AstronomicalUnits().Meters.Should().BeApproximately(149_597_870_700.0, 1.0);
    }

    [Fact]
    public void KesselRun_Throws()
    {
        var act = () => 12.Parsecs().ToKesselRun();
        act.Should().Throw<InvalidOperationException>().WithMessage("*parsec*");
    }

    [Fact]
    public void LightSecond_ToMeters()
    {
        1.LightSeconds().Meters.Should().BeApproximately(299_792_458.0, 1.0);
    }
}

public class MicroscopicDistanceTests
{
    [Fact]
    public void Angstrom_ToNanometers()
    {
        1.Angstroms().ToNanometers().Should().BeApproximately(0.1, 1e-5);
    }

    [Fact]
    public void Femtometer_ToMeters()
    {
        1.Femtometers().Meters.Should().BeApproximately(1e-15, 1e-20);
    }

    [Fact]
    public void PlanckLength_ToMeters()
    {
        1.PlanckLengths().Meters.Should().BeApproximately(1.616255e-35, 1e-40);
    }

    [Fact]
    public void BohrRadius_ToAngstroms()
    {
        1.BohrRadii().ToAngstroms().Should().BeApproximately(0.529177, 1e-4);
    }
}
