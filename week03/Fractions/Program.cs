using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine($"{f1.GetFractionString()}");
        f1.SetTop(1);
        f1.GetBottom();
        f1.SetBottom(5);
        f1.GetBottom();
        f1.GetDecimalValue();
    }
}