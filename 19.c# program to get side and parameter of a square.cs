using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the side length of the square:");
        double side = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The side length of the square is: {0}", side);

        Console.WriteLine("The perimeter of the square is: {0}", 4 * side);
        Console.WriteLine("The area of the square is: {0}", Math.Pow(side, 2));
    }
}