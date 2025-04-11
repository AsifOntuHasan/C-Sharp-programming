using System;

class MultiplyArrays
{
    static void Main()
    {
        int[] array1 = { 2, 4, 6, 8 };
        int[] array2 = { 3, 5, 7, 9 };
        int[] result = new int[array1.Length];
        
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] * array2[i];
            Console.WriteLine("The product of " + array1[i] + " and " + array2[i] + " is " + result[i]);
        }
    }
}