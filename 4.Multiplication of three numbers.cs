using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double result = num1 * num2 * num3;
        Console.WriteLine("The product of the three numbers is: " + result);
    }
}