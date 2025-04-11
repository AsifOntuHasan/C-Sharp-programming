using System;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "HelloWorld";
        string result = "";
        
        for (int i = 0; i < inputString.Length; i += 2)
        {
            result += inputString[i];
        }
        
        Console.WriteLine(result);
    }
}