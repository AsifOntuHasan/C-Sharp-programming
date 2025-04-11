using System;

class Program
{
    static void RotateArrayLeft(int[] arr)
    {
        int temp = arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[arr.Length - 1] = temp;
    }

    static void Main(string[] args)
    {
        int[] inputArray = { 1, 2, 3 };

        Console.WriteLine("Original Array: {0}", string.Join(" ", inputArray));
        RotateArrayLeft(inputArray);
        Console.WriteLine("Rotated Array (left): {0}", string.Join(" ", inputArray));
    }
}