using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Fraction number = new Fraction();
        Fraction number2 = new Fraction(5);
        Fraction number3 = new Fraction(3, 4);
        Fraction number4 = new Fraction(1, 3);
        Console.WriteLine(number.GetFractionString());
        Console.WriteLine(number.GetDecimalValue());
        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number2.GetDecimalValue());
        Console.WriteLine(number3.GetFractionString());
        Console.WriteLine(number3.GetDecimalValue());
        Console.WriteLine(number4.GetFractionString());
        Console.WriteLine(number4.GetDecimalValue());
    }
}