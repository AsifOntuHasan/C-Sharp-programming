using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The sum of the two numbers is: " + (num1 + num2));
        Console.WriteLine("The difference between the two numbers is: " + (num1 - num2));
        Console.WriteLine("The product of the two numbers is: " + (num1 * num2));
        Console.WriteLine("The quotient of the two numbers is: " + (num1 / num2));
    }
}