using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 1 };

        bool areFirstAndLastEqual = CheckIfFirstAndLastAreEqual(array);
        Console.WriteLine("Are the first and last elements of the array equal? " + areFirstAndLastEqual);
    }

    static bool CheckIfFirstAndLastAreEqual(int[] arr)
    {
        if (arr.Length < 2)
        {
            Console.WriteLine("The array must have at least 2 elements.");
            return false;
        }

        return arr[0] == arr[arr.Length - 1];
    }
}