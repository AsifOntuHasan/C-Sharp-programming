using System;

class MultipleChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a positive number:");
        int number = int.Parse(Console.ReadLine());

        bool isMultipleOfThree = number % 3 == 0;
        bool isMultipleOfSeven = number % 7 == 0;

        Console.WriteLine("Is the number a multiple of 3? " + isMultipleOfThree);
        Console.WriteLine("Is the number a multiple of 7? " + isMultipleOfSeven);
    }
}