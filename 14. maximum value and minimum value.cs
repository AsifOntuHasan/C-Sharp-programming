using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];
        int max = 0;
        int min = 0;

        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            if (i == 0)
            {
                max = numbers[i];
                min = numbers[i];
            }
            else
            {
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
            }
        }

        Console.WriteLine("The maximum number is: " + max);
        Console.WriteLine("The minimum number is: " + min);
    }
}
