using Xunit;
using Figures;
using System;
using static System.Math;

namespace Figures.Tests;

public class CircleTest
{
    [Fact]
    public void ZeroRadiusTest()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }
    [Fact]
    public void NegativeRadiusTest()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
    [Theory]
    [InlineData(1)]
    [InlineData(250)]
    [InlineData(500000)]
    public void CaclulateAreaTest(double input)
    {
        double expected = Round(Pow(input, 2) * PI, 2);
        double actual = new Circle(input).Area;
        Assert.Equal(expected, actual);
    }
}