using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter four numbers to calculate the average:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());
        double number3 = Convert.ToDouble(Console.ReadLine());
        double number4 = Convert.ToDouble(Console.ReadLine());

        double sum = number1 + number2 + number3 + number4;
        double average = sum / 4;

        Console.WriteLine("The average of the four numbers is: " + average);
    }
}