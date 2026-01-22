using System;

public static class Array
{
    public static void PrintArray()
    {
        int[,] array = new int[5, 5];
        
        // Initialize all elements to 0 (already done by default)
        // Set [2,2] to 1
        array[2, 2] = 1;
        
        // Print the array
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j]);
                if (j < 4)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Array.PrintArray();
    }
}