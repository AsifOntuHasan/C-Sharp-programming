using System;

class SwapNumbers
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 20;

        Console.WriteLine("Before swapping:");
        Console.WriteLine("Number 1: " + num1);
        Console.WriteLine("Number 2: " + num2);

        // Swap the two numbers using a temporary variable
        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After swapping:");
        Console.WriteLine("Number 1: " + num1);
        Console.WriteLine("Number 2: " + num2);
    }
}