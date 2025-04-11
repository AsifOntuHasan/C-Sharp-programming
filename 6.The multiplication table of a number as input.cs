using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number for the multiplication table:");
        int num = int.Parse(Console.ReadLine());
        int limit = 10; 

        Console.WriteLine("Multiplication Table of {0}:", num);

        for (int i = 1; i <= limit; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
        }
    }