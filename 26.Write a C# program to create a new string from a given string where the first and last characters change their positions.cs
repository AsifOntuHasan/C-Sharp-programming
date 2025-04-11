using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();
        if (input.Length > 1)
        {
            string firstChar = input[0].ToString();
            string lastChar = input[input.Length - 1].ToString();
            string middle = input.Substring(1, input.Length - 2);
            string newString = lastChar + middle + firstChar;
            Console.WriteLine("New string with first and last characters swapped: " + newString);
        }
        else
        {
            Console.WriteLine("The string must have at least 2 characters to swap the first and last position.");
        }
    }
}