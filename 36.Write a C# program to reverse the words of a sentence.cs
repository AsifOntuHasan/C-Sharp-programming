using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        string reversed = string.Join(" ", words.Reverse());
        Console.WriteLine("Reversed sentence: " + reversed);
    }
}