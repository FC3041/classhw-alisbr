using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter base (a):");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter exponent (b):");
        int b = Convert.ToInt32(Console.ReadLine());

        double result = CalculatePower(a, b);
        Console.WriteLine($"{a}^{b} = {result}");
    }

    static double CalculatePower(double a, int b)
    {
        if (b == 0)
        {
            return 1;
        }

        double result = 1;
        int absExponent = Math.Abs(b);

        for (int i = 1; i <= absExponent; i++)
        {
            result *= a;
        }

        
        if (b < 0)
        {
            result = 1 / result;
        }

        return result;
    }
}