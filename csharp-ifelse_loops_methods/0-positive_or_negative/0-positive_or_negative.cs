using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        
        // YOUR CODE GOES HERE
        if (number > 0)
        {
            Console.WriteLine($"{number} is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine($"{number} is zero");
        }
        else
        {
            Console.WriteLine($"{number} is negative");
        }
    }
}