using System;

class LowercaseString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to convert to lowercase: ");
        string input = Console.ReadLine();
        string lowercase = input.ToLower();
        Console.WriteLine("Lowercase string: " + lowercase);
    }
}