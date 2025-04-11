using System;

class TemperatureConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Temperature Conversion Program!");
        Console.Write("Enter a temperature in Celsius (°C): ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double kelvin = ConvertCelsiusToKelvin(celsius);
        Console.WriteLine($"The temperature in Kelvin (K) is: {kelvin} K");

        double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"The temperature in Fahrenheit (°F) is: {fahrenheit} °F");
    }

    static double ConvertCelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}