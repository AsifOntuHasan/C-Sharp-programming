using System;

public class Program
{
    public static bool CheckForTwenty(int a, int b)
    {
        return (a == 20 || b == 20 || a + b == 20);
    }

    public static void Main()
    {
        Console.WriteLine("Enter two integers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        bool result = CheckForTwenty(num1, num2);
        Console.WriteLine("The sum of the two integers is 20 or one of them is 20: " + result);
    }
}