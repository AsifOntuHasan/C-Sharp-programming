using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers: ");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = double.Parse(Console.ReadLine());

        // Calculate (x+y).z
        double result1 = (x + y) * z;
        Console.WriteLine("Result 1: " + result1);

        // Calculate x.y + y.z
        double result2 = (x * y) + (y * z);
        Console.WriteLine("Result 2: " + result2);
    }
}
