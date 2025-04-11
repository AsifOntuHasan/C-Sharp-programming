using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two integers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        if (num1 == num2)
        {
            Console.WriteLine("The triple of the sum is: " + (sum * 3));
        }
        else
        {
            Console.WriteLine("The sum is: " + sum);
        }
    }
}