using System;

class Circle
{
    public static void Main()
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("The radius of the circle is: " + radius);

        Console.WriteLine("The area of the circle is: " + (Math.PI * radius * radius));
        Console.WriteLine("The circumference of the circle is: " + (2 * Math.PI * radius));
        Console.WriteLine("The parameter of the circle is: " + (2 * Math.Sqrt(Math.Pow(radius, 2)) * Math.Sin(Math.PI / 4));
    }
}