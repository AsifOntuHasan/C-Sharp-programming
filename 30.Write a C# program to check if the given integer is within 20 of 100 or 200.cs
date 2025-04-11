using System;

class CheckIntegerRange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer:");
        int num = Convert.ToInt32(Console.ReadLine());

        bool isWithinRange = (Math.Abs(num - 100) <= 20 || Math.Abs(num - 200) <= 20);

        Console.WriteLine("Is the number within 20 of 100 or 200? " + isWithinRange);
    }
}