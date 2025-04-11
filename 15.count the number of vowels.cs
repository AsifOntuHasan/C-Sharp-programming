using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter to count the vowels:");
        string input = Console.ReadLine();
        
        int vowelCount = 0;
        foreach (char c in input)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                vowelCount++;
            }
        }
        
        Console.WriteLine("The number of vowels is: " + vowelCount);
    }
}