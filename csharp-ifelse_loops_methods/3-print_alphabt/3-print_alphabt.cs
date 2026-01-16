using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";
        
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (letter != 'e' && letter != 'q')
            {
                result += letter;
            }
        }
        
        Console.Write(result);
    }
}