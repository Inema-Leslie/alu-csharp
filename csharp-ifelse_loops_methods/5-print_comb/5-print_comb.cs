using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";
        
        for (int i = 0; i <= 99; i++)
        {
            result += $"{i:D2}";
            
            if (i < 99)
            {
                result += ", ";
            }
        }
        
        Console.Write(result + "\n");
    }
}