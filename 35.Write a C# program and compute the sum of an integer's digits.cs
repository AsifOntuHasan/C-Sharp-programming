using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer:");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine("The sum of the digits is: " + sum);
    }
}