using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to et factorial:");
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Factorial is not defined.");
        }
        else
        {
            long factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of {0} is {1}", num, factorial);
        }
    }
}