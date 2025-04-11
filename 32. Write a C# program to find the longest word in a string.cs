using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = "The quick brown fox jumps over the lazy dog";
        string[] words = input.Split(' ');
        string longestWord = words.OrderByDescending(word => word.Length).First();
        Console.WriteLine("The longest word is: " + longestWord);
    }
}