using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 1;
        double b = -3;
        double c = 2;

        var solutions = SolveQuadratic(a, b, c);

        Console.WriteLine("x1 = " + solutions.Item1);
        Console.WriteLine("x2 = " + solutions.Item2);
    }

    static Tuple<double, double> SolveQuadratic(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        double x1, x2;

        if (discriminant >= 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }
        else
        {
            // Complex roots, set x1 and x2 to NaN
            x1 = double.NaN;
            x2 = double.NaN;
        }

        return Tuple.Create(x1, x2);
    }
}