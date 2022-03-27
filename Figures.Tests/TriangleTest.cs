using Xunit;
using Figures;
using System;
using static System.Math;

namespace Figures.Tests;

public class TriangleTest
{
    [Fact]
    public void ZeroInputTest()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(2, 0, 2));
    }
    [Theory]
    [InlineData(4, 3, 8)]
    [InlineData(13, 6, 7)]
    public void IvalidTriangleTest(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
    [Theory]
    [InlineData(4, 5, 6)]
    [InlineData(14, 9, 9)]
    public void CaclulateAreaTest(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double expected = Round(Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
        double actual = new Triangle(a, b, c).Area;
        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 4, 6, false)]
    public void IsRigthTriangleTest(double a, double b, double c, bool expected)
    {
        Assert.Equal(new Triangle(a, b, c).IsRigth, expected);
    }
}