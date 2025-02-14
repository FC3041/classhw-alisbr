using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter temperature in Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
    }

    static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}