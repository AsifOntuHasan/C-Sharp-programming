using System;

class MaxNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double max = num1;

        if (num2 > max)
            max = num2;

        if (num3 > max)
            max = num3;

        Console.WriteLine("The maximum value among the three numbers is: " + max);
    }
}