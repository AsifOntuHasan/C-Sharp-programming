using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        int century = year / 100 + 1;
        Console.WriteLine("The century of the year " + year + " is " + century);
    }
}