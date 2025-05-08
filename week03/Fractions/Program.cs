using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal: {f1.GetDecimalValue()}");
        Console.WriteLine();

        Fraction f2 = new Fraction(5);
        Console.WriteLine($"Fraction: {f2.GetFractionString()}");
        Console.WriteLine($"Decimal: {f2.GetDecimalValue()}");
        Console.WriteLine();

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction: {f3.GetFractionString()}");
        Console.WriteLine($"Decimal: {f3.GetDecimalValue()}");
        Console.WriteLine();

        f1.SetTop(2);
        f1.SetBottom(5);
        Console.WriteLine($"Fraction: {f1.GetFractionString()}");  
        Console.WriteLine($"Decimal: {f1.GetDecimalValue()}");    
        Console.WriteLine();

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction: {f4.GetFractionString()}");
        Console.WriteLine($"Decimal: {f4.GetDecimalValue()}");
        Console.WriteLine();
    }
}
