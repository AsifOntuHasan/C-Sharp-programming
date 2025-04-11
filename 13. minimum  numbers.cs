using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int min = num1;
        if (num2 < min)
        {
            min = num2;
        }
        if (num3 < min)
        {
            min = num3;
        }

        Console.WriteLine("The minimum of the three numbers is: " + min);
    }
}
