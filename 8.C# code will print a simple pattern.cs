using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 5;
        for(int i = 1; i <= num; i++)
        {
            for(int j = 1; j <= num - i; j++)
            {
                Console.Write(" ");
            }
            for(int k = 1; k <= i; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
    }
}