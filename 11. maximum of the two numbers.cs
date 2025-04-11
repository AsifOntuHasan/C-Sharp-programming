using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        
        int max = Math.Max(num1, num2);
        Console.WriteLine("The maximum of the two numbers is: " + max);
    }
}