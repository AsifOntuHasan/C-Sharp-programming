using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}