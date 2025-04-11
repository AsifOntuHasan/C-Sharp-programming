using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string number = Console.ReadLine();

        Console.WriteLine(number + " " + number + " " + number + " ");
        Console.WriteLine(number + number + number + number);
    }
}