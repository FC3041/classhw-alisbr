using System;

class Program
{
    static void Main()
    {
        int n = 5; // Example input
        double averageOfSquares = CalculateAverageOfSquaresUpTo(n);
        Console.WriteLine($"Average of squares from 1 to {n}: {averageOfSquares}");
    }

    static double CalculateAverageOfSquaresUpTo(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("The number must be greater than 0.");
        }

        double sumOfSquares = 0;
        for (int i = 1; i <= n; i++)
        {
            sumOfSquares += i * i; // Square each number and add to the sum
        }

        double average = sumOfSquares / n;
        return average;
    }
}