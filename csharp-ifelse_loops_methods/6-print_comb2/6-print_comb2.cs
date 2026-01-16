using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";
        
        for (int i = 0; i <= 8; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                result += $"{i}{j}";
                
                if (!(i == 8 && j == 9))
                {
                    result += ", ";
                }
            }
        }
        
        Console.WriteLine(result);
    }
}