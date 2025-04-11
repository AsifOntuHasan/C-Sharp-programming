using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Prime numbers from 1 to " + n + ":");
        
        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            
            if (isPrime)
            {
                Console.WriteLine(i);
            }
        }
    }
}