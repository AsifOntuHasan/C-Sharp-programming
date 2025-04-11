using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third integer:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int max = num1;
        int min = num1;

        if (num2 > max)
            max = num2;
        if (num3 > max)
            max = num3;

        if (num2 < min)
            min = num2;
        if (num3 < min)
            min = num3;

        Console.WriteLine("The largest value is: " + max);
        Console.WriteLine("The smallest value is: " + min);
    }
}