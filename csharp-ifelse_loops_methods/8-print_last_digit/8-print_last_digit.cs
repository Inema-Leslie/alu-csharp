using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit = Math.Abs(number % 10);
        
        
        Console.Write(lastDigit);
        
        
        return lastDigit;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int r;

        Number.PrintLastDigit(98);
        Number.PrintLastDigit(0);
        r = Number.PrintLastDigit(-1024);
        Console.WriteLine(r);
    }
}