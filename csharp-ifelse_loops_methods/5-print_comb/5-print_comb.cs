using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 99; i++)
        {
            Console.Write(i.ToString("D2"));
            
            if (i < 99)
            {
                Console.Write(", ");
            }
        }
        
        Console.WriteLine();
    }
}