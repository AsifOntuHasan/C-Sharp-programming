using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;
        int currentPrime = 2;

        while (count < 500)
        {
            if (IsPrime(currentPrime))
            {
                sum += currentPrime;
                count++;
            }
            currentPrime++;
        }

        Console.WriteLine("The sum of the first 500 prime numbers is: " + sum);
    }
}