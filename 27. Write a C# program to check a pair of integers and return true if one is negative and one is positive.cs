using System;

class PairCheck
{
    static bool CheckPair(int num1, int num2)
    {
        return (num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first integer:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second integer:");
        int secondNumber = int.Parse(Console.ReadLine());

        bool isOneNegativeOnePositive = CheckPair(firstNumber, secondNumber);
        Console.WriteLine("Are the numbers one negative and one positive? " + isOneNegativeOnePositive);
    }
}