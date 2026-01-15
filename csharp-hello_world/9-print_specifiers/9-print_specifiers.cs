using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Console.WriteLine($"Percent: {percent:P2}\nCurrency: {currency:C}");
    }
}