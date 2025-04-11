using System;

class Program
{
    static bool ContainsOddNumber(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        bool hasOddNumber = ContainsOddNumber(numbers);
        Console.WriteLine("The array contains an odd number: " + hasOddNumber);
    }
}