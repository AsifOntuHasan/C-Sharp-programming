using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the array elements:");
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the number to count:");
        int num = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i] == num)
            {
                count++;
            }
        }

        Console.WriteLine("The number {0} occurs {1} times in the array.", num, count);
    }
}