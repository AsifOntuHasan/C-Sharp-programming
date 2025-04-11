using System;

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The length of the rectangle is: {0}", length);
        Console.WriteLine("The width of the rectangle is: {0}", width);
    }