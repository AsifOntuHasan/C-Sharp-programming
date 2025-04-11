using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers to divide:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        else
        {
            double result = (double)num1 / num2;
            Console.WriteLine("The result of the division is: " + result);
        }
    }
}
