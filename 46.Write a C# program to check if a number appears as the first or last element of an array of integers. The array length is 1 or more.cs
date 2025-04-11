using System;

class Program
{
    static bool NumberAppearsAtEnd(int[] arr, int num)
    {
        if (arr.Length == 0)
            throw new ArgumentException("The array must have at least 1 element.");

        return arr[0] == num || arr[arr.Length - 1] == num;
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int number = 1;

        bool isFirstOrLast = NumberAppearsAtEnd(array, number);

        Console.WriteLine("Does the number " + number + " appear as the first or last element of the array? " + isFirstOrLast);
    }
}