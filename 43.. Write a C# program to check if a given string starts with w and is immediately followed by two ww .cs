using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to check:");
        string inputString = Console.ReadLine();

        if (inputString.StartsWith("ww"))
        {
            Console.WriteLine("The string starts with 'ww'.");
        }
        else
        {
            Console.WriteLine("The string does not start with 'ww'.");
        }

        Console.ReadKey();
    }
}