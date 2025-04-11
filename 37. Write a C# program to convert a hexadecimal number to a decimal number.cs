using System;

class HexToDec
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a hexadecimal number : ");
        string hexNumber = Console.ReadLine();

        int decimalNumber = Convert.ToInt32(hexNumber, 16);
        Console.WriteLine("The decimal equivalent of " + hexNumber + " is: " + decimalNumber);
    }
}