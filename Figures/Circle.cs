namespace Figures;
using static System.Math;

public class Circle : Figure
{
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть больше 0");
        Radius = radius;
    }
    public double Radius { get; }
    public override double Area => _area ??= Round(PI * Pow(Radius, 2), 2);
}