using static System.Math;

namespace Figures;

public class Triangle : Figure
{
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Длинна стороны треугольника не может быть меньше или равно 0");
        if (b > a) Helpers.Swap(ref a, ref b);
        if (c > a) Helpers.Swap(ref a, ref c);
        if (b + c - a <= 0)
            throw new ArgumentException("Сумма длинн двух сторон треугольника не может быть меньше или равным длины третьей");
        EdgeA = a;
        EdgeB = b;
        EdgeC = c;
    }
    public double EdgeA { get; }
    public double EdgeB { get; }
    public double EdgeC { get; }
    private bool? _isRigth;
    public bool IsRigth => _isRigth ??= Round(Pow(EdgeA, 2) - Pow(EdgeB, 2) - Pow(EdgeC, 2), 2) == 0;
    public override double Area
    {
        get
        {
            if (_area.HasValue) return _area.Value;
            double p = (EdgeA + EdgeB + EdgeC) / 2;
            double temp = p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC);
            return _area ??= Round(Sqrt(temp), 2);
        }
    }
}