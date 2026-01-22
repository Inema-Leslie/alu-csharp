using System;

// Custom Array class with CreatePrint method
public static class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }
        
        // Create and fill the array
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = i;
        }
        
        // Print the array
        for (int i = 0; i < size; i++)
        {
            Console.Write(result[i]);
            if (i < size - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
        
        return result;
    }
}

// Main program class - this is what runs when you execute
class Program
{
    static void Main(string[] args)
    {
        // Test cases
        int[] array;
        
        array = Array.CreatePrint(5);
        if (array != null)
            Console.WriteLine("Array Length: " + array.Length);
        Console.WriteLine();
        
        array = Array.CreatePrint(0);
        if (array != null)
            Console.WriteLine("Array Length: " + array.Length);
        Console.WriteLine();
        
        array = Array.CreatePrint(-5);
    }
}