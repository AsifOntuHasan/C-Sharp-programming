using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize an array of integers
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;

        // Loop through the array and sum the elements
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        // Output the sum of the array elements
        Console.WriteLine("The sum of all elements in the array is: " + sum);
    }
}