using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int count = Convert.ToInt32(Console.ReadLine());

        PrintHelloWorld(count);
    }

    static void PrintHelloWorld(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}