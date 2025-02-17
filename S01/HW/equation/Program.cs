using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter coefficient a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coefficient b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter coefficient c:");
        double c = Convert.ToDouble(Console.ReadLine());

        SolveQuadraticEquation(a, b, c);
    }

    static void SolveQuadraticEquation(double a, double b, double c)
    {
        if (a == 0)
        {
            Console.WriteLine("This is not a quadratic equation (a cannot be 0).");
            return;
        }

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Two distinct real roots: {root1} and {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"One real root (repeated): {root}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine($"Two complex roots: {realPart} + {imaginaryPart}i and {realPart} - {imaginaryPart}i");
        }
    }
}