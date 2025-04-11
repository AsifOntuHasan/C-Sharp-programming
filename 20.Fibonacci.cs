using System;

class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter the number of terms in the Fibonacci sequence:");
        int n = int.Parse(Console.ReadLine());
        int[] fib = new int[n];
        fib[0] = 0;
        fib[1] = 1;
        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        Console.WriteLine("The first " + n + " terms of the Fibonacci sequence are:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(fib[i]);
        }
    }
}