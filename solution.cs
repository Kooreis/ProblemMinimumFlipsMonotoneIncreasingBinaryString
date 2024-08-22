using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a binary string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Minimum number of flips: " + MinFlips(input));
    }
}