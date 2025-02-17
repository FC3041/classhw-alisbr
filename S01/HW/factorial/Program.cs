using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a non-negative integer to calculate its factorial:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"Factorial of {number} is: {factorial}");
        }
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1; // Base case: 0! and 1! are both 1
        }

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i; // Multiply result by each number from 2 to n
        }

        return result;
    }
}