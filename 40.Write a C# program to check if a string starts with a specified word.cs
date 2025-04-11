using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello, how can I help you?.";
        string startWord = "Hello";

        if (str.StartsWith(startWord))
        {
            Console.WriteLine("The string starts with the specified word: " + startWord);
        }
        else
        {
            Console.WriteLine("The string does not start with the specified word: " + startWord);
        }
    }
}