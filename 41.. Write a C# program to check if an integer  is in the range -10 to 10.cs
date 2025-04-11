using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two integers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        if (num1 >= -10 && num1 <= 10)
        {
            Console.WriteLine("Integer 1 is in the range -10 to 10.");
        }
        else if (num2 >= -10 && num2 <= 10)
        {
            Console.WriteLine("Integer 2 is in the range -10 to 10.");
        }
        else
        {
            Console.WriteLine("Neither Integer is in the range -10 to 10.");
        }
    }
}